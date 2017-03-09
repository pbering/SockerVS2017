# Socker = Sitecore :heart: Docker (now with Visual Studio 2017)

>This is the continuation of [https://github.com/pbering/Socker](https://github.com/pbering/Socker) where the Docker integration in Visual Studio 2017 RTM is used, for a even smother developer workflow!

Is is now possible to run Sitecore completely in Docker natively, you don't have to mess around with databases, IIS or anything, you don't even have to have SQL Server or IIS installed on your machine.

This repository shows how a solution running Sitecore is wired up for development with the following features:

- Databases is persisted between restarts
- Serialized items are also persisted
- Streaming log output

Besides the Visual Studio 2017 out-of-the-box docker features:

- Remote debugging also with auto attaching running containers
- Build, re-build, clear builds/stops/starts compose services (containers)

## Prerequisites

- Windows 10 Anniversary update with latest updates
- Docker for Windows
- Visual Studio 2017 RTM

## Preparations

>NOTE: Base images are build and consumed locally in this example, but in a real life senario you would also push to an remote private repository like
hub.docker.com, quay.io or an internal one, so that images can be shared within your organization.
Unfortunately it has to be **private** repositories due to Sitecore licensing terms so we can't share images in the community.

### Using Sitecore v8.1 rev. 160519

1. Copy **Sitecore 8.1 rev. 160519.zip** into **"/images/sitecore-81rev160519"**
1. Copy **license.xml** into **"/images/sitecore-81rev160519/Sitecore/Data"**
1. Build image:

    ```text
    docker build -t sitecore:8.1.160519 .\images\sitecore-81rev160519
    ```

1. Copy database files from **Sitecore 8.1 rev. 160519.zip** into **"/data/databases"**

## Daily usage

1. Open solution...
1. Make sure the "docker-compose" project is your startup project
1. CTRL+F5 to run or set breakpoint and F5, Visual Studio will open your default browser automatically when the containers are ready

To stop everything again just use "Build -> Clear",

### Tips

You can get the container id from the build output, in the examples below my container id is "b563056c227a", so I can just use "b56".

You can attach to a container to watch output from Sitecore logs:

```text
docker exec b56 powershell C:/Sitecore/Scripts/Stream-Log.ps1
```

or observe the output of the watcher script:

```text
docker attach b56
```
