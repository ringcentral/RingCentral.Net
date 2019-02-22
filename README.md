# RingCentral.Net

This project is complete rewrite of [ringcentral/ringcentral-csharp-client](https://github.com/ringcentral/ringcentral-csharp-client).


## For maintainers

### Release

Update version number in `RingCentral.Net/RingCentral.Net.csproj`

```
cd RingCentral.Net
dotnet pack
```

Update version number in `RingCentral.Net.PubnubPCL/RingCentral.Net.PubnubPCL.csproj`

```
cd RingCentral.Net.PubnubPCL
dotnet pack
```

Update version number in `RingCentral.Net.Pubnub/RingCentral.Net.Pubnub.csproj`

Reference [Quickstart: Create and publish a package using Visual Studio (.NET Framework, Windows)](https://docs.microsoft.com/en-us/nuget/quickstart/create-and-publish-a-package-using-visual-studio-net-framework) to publish `RingCentral.Net.Pubnub`.
