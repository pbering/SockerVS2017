FROM microsoft/aspnet

SHELL ["powershell", "-NoProfile", "-Command", "$ErrorActionPreference = 'Stop';"] 

ADD *.zip .

RUN Expand-Archive -Path 'C:\Sitecore*.zip' -DestinationPath 'C:\Temp'; \
    Remove-Item 'C:\Sitecore*.zip' -Force;

RUN robocopy ((Resolve-Path -Path "C:\Temp\Sitecore*").Path) 'C:\Sitecore' /E /NP /NFL /NDL /NJH /NJS; \
    $global:LASTEXITCODE = $null;

RUN New-Item 'C:\empty' -ItemType Directory | Out-Null; \
    robocopy 'C:\empty' 'C:\Sitecore\Temp' /purge /NP /NFL /NDL /NJH /NJS | Out-Null; \
    $global:LASTEXITCODE = $null; \
    Remove-Item 'C:\empty' -Force; \
    Remove-Item 'C:\Sitecore\Temp' -Force;
