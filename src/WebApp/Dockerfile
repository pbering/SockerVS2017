FROM sitecore:8.2.161221

SHELL ["powershell", "-NoProfile", "-Command", "$ErrorActionPreference = 'Stop';"] 

ARG source

COPY ${source:-obj/Docker/publish} "C:\inetpub\wwwroot"

RUN Set-ItemProperty -Path 'HKLM:\SYSTEM\CurrentControlSet\Services\Dnscache\Parameters' -Name ServerPriorityTimeLimit -Value 0 -Type DWord; \
	Import-Module WebAdministration; \
    Set-ItemProperty -Path 'IIS:\apppools\DefaultAppPool' -Name 'enable32BitAppOnWin64' -Value 'True';