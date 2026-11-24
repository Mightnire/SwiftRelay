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
    try {
        rm -Recurse -Force $OutputPath -ErrorAction Stop
    } catch {
        Get-ChildItem -Path $OutputPath -Exclude '*.old*' | ForEach-Object {
            try { rm -Recurse -Force $_.FullName -ErrorAction Stop } catch {
                try { Move-Item -LiteralPath $_.FullName -Destination ($_.FullName + '.old.' + (Get-Random)) -Force -ErrorAction SilentlyContinue } catch {}
            }
        }
    }
}
if ( -Not (Test-Path -Path $OutputPath) ) {
    New-Item -ItemType Directory -Name $OutputPath | Out-Null
}

$ScriptDir = Split-Path $MyInvocation.MyCommand.Path -Parent

if ( -Not (Test-Path "$OutputPath\bin") ) {
    New-Item -ItemType Directory -Path "$OutputPath\bin" | Out-Null
}
cp -Recurse -Force "$ScriptDir\Storage\i18n" "$OutputPath"  | Out-Null
cp -Recurse -Force "$ScriptDir\Storage\mode" "$OutputPath"  | Out-Null
cp -Recurse -Force "$ScriptDir\Storage\stun.txt" "$OutputPath\bin"  | Out-Null
cp -Recurse -Force "$ScriptDir\Storage\nfdriver.sys" "$OutputPath\bin"  | Out-Null
try {
    if (Test-Path "$ScriptDir\release\bin\GeoLite2-Country.mmdb") {
        cp -Force "$ScriptDir\release\bin\GeoLite2-Country.mmdb" "$OutputPath\bin"
    } else {
        Invoke-WebRequest -Uri 'https://raw.githubusercontent.com/Loyalsoldier/geoip/release/Country.mmdb' -OutFile "$OutputPath\bin\GeoLite2-Country.mmdb"
    }
} catch {}
cp -Recurse -Force "$ScriptDir\Storage\tun2socks.bin" "$OutputPath\bin"  | Out-Null
cp -Recurse -Force "$ScriptDir\Storage\README.md" "$OutputPath\bin"  | Out-Null

if ( -Not ( Test-Path '.\Other\release' ) ) {
	.\Other\build.ps1
	if ( -Not $? ) {
		exit $lastExitCode
	}
}
cp -Force '.\Other\release\*.bin' "$OutputPath\bin"
cp -Force '.\Other\release\*.dll' "$OutputPath\bin"
cp -Force '.\Other\release\*.exe' "$OutputPath\bin"

Write-Host
Write-Host 'Building SwiftRelay'

$IntermediateOutput = if ($SelfContained) { ".\Netch\bin\$Configuration" } else { ".\Netch\bin\$Configuration-FDD" }

dotnet publish `
	-c $Configuration `
	-r 'win-x64' `
	-p:Platform='x64' `
	-p:SelfContained=$SelfContained `
	-p:PublishTrimmed=$PublishReadyToRun `
	-p:PublishSingleFile=$PublishSingleFile `
	-p:EnableCompressionInSingleFile=$SelfContained `
	-p:PublishReadyToRun=$PublishReadyToRun `
	-p:PublishReadyToRunShowWarnings=$PublishReadyToRun `
	-p:IncludeNativeLibrariesForSelfExtract=$SelfContained `
	-p:UseSharedCompilation=false `
	-o "$IntermediateOutput" `
	'.\Netch\Netch.csproj'
if ( -Not $? ) { exit $lastExitCode }

$TargetExe = if (Test-Path "$IntermediateOutput\SwiftRelay.exe") { "$IntermediateOutput\SwiftRelay.exe" } else { "$IntermediateOutput\Netch.exe" }
$DestExe = Join-Path $OutputPath (Split-Path $TargetExe -Leaf)
try {
    cp -Force $TargetExe $OutputPath -ErrorAction Stop
} catch {
    try {
        Move-Item -LiteralPath $DestExe -Destination ($DestExe + '.old.' + (Get-Random)) -Force -ErrorAction SilentlyContinue
        cp -Force $TargetExe $OutputPath
    } catch {
        Write-Warning "Could not copy $TargetExe to ${OutputPath}: $_"
    }
}

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
	if (Test-Path ".\Redirector\bin\$Configuration\nfapi.dll") {
		cp -Force ".\Redirector\bin\$Configuration\nfapi.dll"      "$OutputPath\bin"
	} else {
		cp -Force ".\Redirector\static\nfapi.dll" "$OutputPath\bin"
	}
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
