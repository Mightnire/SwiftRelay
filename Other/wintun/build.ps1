Set-Location (Split-Path $MyInvocation.MyCommand.Path -Parent)

if (-Not (Test-Path 'wintun.zip')) {
    try {
        Invoke-WebRequest `
            -Uri 'https://www.wintun.net/builds/wintun-0.13.zip' `
            -OutFile 'wintun.zip'
    }
    catch {
        exit 1
    }
}

if (-Not (Test-Path 'wintun_extracted')) {
    Expand-Archive -Force -Path 'wintun.zip' -DestinationPath 'wintun_extracted'
}

if (Test-Path 'wintun_extracted\wintun\bin\amd64\wintun.dll') {
    cp -Force 'wintun_extracted\wintun\bin\amd64\wintun.dll' '..\release\wintun.dll'
}
elseif (Test-Path 'wintun\bin\amd64\wintun.dll') {
    cp -Force 'wintun\bin\amd64\wintun.dll' '..\release\wintun.dll'
}

exit 0
