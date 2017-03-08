FROM sitecore:8.1.160519

ARG source

WORKDIR /inetpub/wwwroot

COPY ${source:-obj/Docker/publish} .

#SHELL ["powershell", "-NoProfile", "-Command", "$ErrorActionPreference = 'Stop';"] 
  
#ADD inetpub/ /inetpub

# TODO: Run ConnectionStrings
# TODO: Run Watch-Directory

#CMD C:\inetpub\scripts\Setup-ConnectionStrings.ps1; \
#    C:\inetpub\scripts\Watch-Directory.ps1 -Path 'C:\Workspace' -Destination 'C:\inetpub\wwwroot'

# microsoft/iis does this so if there is no command here, this will run:
#ENTRYPOINT ["C:\\ServiceMonitor.exe", "w3svc"]