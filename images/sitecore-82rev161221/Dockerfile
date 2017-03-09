FROM microsoft/aspnet

SHELL ["powershell", "-NoProfile", "-Command", "$ErrorActionPreference = 'Stop';"] 

ADD *.zip .

RUN Expand-Archive -Path 'C:\Sitecore*.zip' -DestinationPath 'C:\\'; \
    Remove-Item 'C:\Sitecore*.zip' -Force;

RUN Get-ChildItem -Path 'C:\Sitecore *' | % { Move-Item $_ -Destination 'C:\Sitecore' }; \
    Remove-Item 'C:\Sitecore *' -Recurse -Force; \
    Remove-Item 'C:\Sitecore\Databases' -Recurse -Force;

ADD Sitecore /Sitecore

RUN Import-Module WebAdministration; \
    Set-ItemProperty 'IIS:\Sites\Default Web Site\' -Name 'physicalPath' -Value 'C:\Sitecore\Website';