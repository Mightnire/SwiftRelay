param (
	[Parameter()]
	[ValidateSet('Debug', 'Release')]
	[string]
	$Configuration = 'Release',

	[Parameter()]
	[ValidateNotNullOrEmpty()]
	[string]
	$OutputPath = 'release',

	[Parameter()]
	[bool]
	$SelfContained = $True,

	[Parameter()]
	[bool]
	$PublishSingleFile = $True,

	[Parameter()]
	[bool]
	$PublishReadyToRun = $False
)

Push-Location (Split-Path $MyInvocation.MyCommand.Path -Parent)

if ( Test-Path -Path $OutputPath ) {
    rm -Recurse -Force $OutputPath
}
New-Item -ItemType Directory -Name $OutputPath | Out-Null

Push-Location $OutputPath
New-Item -ItemType Directory -Name 'bin'  | Out-Null
cp -Recurse -Force '..\Storage\i18n' '.'  | Out-Null
cp -Recurse -Force '..\Storage\mode' '.'  | Out-Null
cp -Recurse -Force '..\Storage\stun.txt' 'bin'  | Out-Null
cp -Recurse -Force '..\Storage\nfdriver.sys' 'bin'  | Out-Null
try {
    Invoke-WebRequest -Uri 'https://raw.githubusercontent.com/Loyalsoldier/geoip/release/Country.mmdb' -OutFile 'bin\GeoLite2-Country.mmdb'
} catch {}
cp -Recurse -Force '..\Storage\tun2socks.bin' 'bin'  | Out-Null
cp -Recurse -Force '..\Storage\README.md' 'bin'  | Out-Null
Pop-Location

if ( -Not ( Test-Path '.\Other\release' ) ) {
	.\Other\build.ps1
	if ( -Not $? ) {
		exit $lastExitCode
	}
}
cp -Force '.\Other\release\*.bin' "$OutputPath\bin"
cp -Force '.\Other\release\*.dll' "$OutputPath\bin"
cp -Force '.\Other\release\*.exe' "$OutputPath\bin"

if ( -Not ( Test-Path ".\Netch\bin\$Configuration" ) ) {
	Write-Host
	Write-Host 'Building Netch'

	dotnet publish `
		-c $Configuration `
		-r 'win-x64' `
		-p:Platform='x64' `
		-p:SelfContained=$SelfContained `
		-p:PublishTrimmed=$PublishReadyToRun `
		-p:PublishSingleFile=$PublishSingleFile `
		-p:PublishReadyToRun=$PublishReadyToRun `
		-p:PublishReadyToRunShowWarnings=$PublishReadyToRun `
		-p:IncludeNativeLibrariesForSelfExtract=$SelfContained `
		-o ".\Netch\bin\$Configuration" `
		'.\Netch\Netch.csproj'
	if ( -Not $? ) { exit $lastExitCode }
}
cp -Force ".\Netch\bin\$Configuration\Netch.exe" $OutputPath

if ( -Not ( Test-Path ".\Redirector\Redirector.bin" ) -and -Not ( Test-Path ".\Redirector\bin\$Configuration\Redirector.bin" ) ) {
	Write-Host
	Write-Host 'Building Redirector'

	if (Get-Command msbuild -ErrorAction SilentlyContinue) {
		msbuild `
			-property:Configuration=$Configuration `
			-property:Platform=x64 `
			'.\Redirector\Redirector.vcxproj'
		if ( -Not $? ) { exit $lastExitCode }
	} else {
		$gpp = "D:\Program Files\RedPanda-Cpp\MinGW64\bin\g++.exe"
		Push-Location .\Redirector
		& $gpp -shared -O3 -std=c++17 -fpermissive -Iinclude Based.cpp DNSHandler.cpp EventHandler.cpp IPEventHandler.cpp Redirector.cpp SocksHelper.cpp TCPHandler.cpp Utils.cpp -Llib -lnfapi -Lstatic -lnfapi -lws2_32 -static-libgcc -static-libstdc++ -o Redirector.bin
		Pop-Location
	}
}

if (Test-Path ".\Redirector\bin\$Configuration\Redirector.bin") {
	cp -Force ".\Redirector\bin\$Configuration\nfapi.dll"      "$OutputPath\bin"
	cp -Force ".\Redirector\bin\$Configuration\Redirector.bin" "$OutputPath\bin"
} else {
	cp -Force ".\Redirector\static\nfapi.dll" "$OutputPath\bin"
	cp -Force ".\Redirector\Redirector.bin"   "$OutputPath\bin"
}

if ( -Not ( Test-Path ".\RouteHelper\RouteHelper.bin" ) -and -Not ( Test-Path ".\RouteHelper\bin\$Configuration\RouteHelper.bin" ) ) {
	Write-Host
	Write-Host 'Building RouteHelper'

	if (Get-Command msbuild -ErrorAction SilentlyContinue) {
		msbuild `
			-property:Configuration=$Configuration `
			-property:Platform=x64 `
			'.\RouteHelper\RouteHelper.vcxproj'
		if ( -Not $? ) { exit $lastExitCode }
	} else {
		$gpp = "D:\Program Files\RedPanda-Cpp\MinGW64\bin\g++.exe"
		Push-Location .\RouteHelper
		& $gpp -shared -O3 -std=c++17 -fpermissive RouteHelper.cpp WaitGroup.cpp -o RouteHelper.bin -liphlpapi -lws2_32 -static-libgcc -static-libstdc++
		Pop-Location
	}
}

if (Test-Path ".\RouteHelper\bin\$Configuration\RouteHelper.bin") {
	cp -Force ".\RouteHelper\bin\$Configuration\RouteHelper.bin" "$OutputPath\bin"
} else {
	cp -Force ".\RouteHelper\RouteHelper.bin" "$OutputPath\bin"
}

if ( $Configuration.Equals('Release') ) {
	rm -Force "$OutputPath\*.pdb"
	rm -Force "$OutputPath\*.xml"
}

Pop-Location
exit 0
