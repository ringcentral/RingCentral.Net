# RingCentral.Net

This project is a complete rewrite of [ringcentral/ringcentral-csharp-client](https://github.com/ringcentral/ringcentral-csharp-client).

- [Announcing the New RingCentral SDK for .NET](https://medium.com/ringcentral-developers/new-ringcentral-sdk-for-net-a43417b2538c)
- [RingCentral SDK for .NET Upgrade Guide](https://medium.com/ringcentral-developers/ringcentral-sdk-for-net-upgrade-guide-8ead6bcdaf99)


## Installation

Package is avaiable on NuGet: https://www.nuget.org/packages/RingCentral.Net

You can install it just like you install any other NuGet packages.

If you need PubNub feature, you also need to install one of the following packages:

- If you want to target traditional .NET Framework: https://www.nuget.org/packages/RingCentral.Net.Pubnub
- If you want to target .NET Core, Mono, Xamarin...etc: https://www.nuget.org/packages/RingCentral.Net.PubnubPCL


## Code samples

You can find [sample code for all the endpoints](./samples.md).

There is also lots of useful code for your reference in our [test cases](./RingCentral.Tests).


## For maintainers

### Release

Update version number in `RingCentral.Net/RingCentral.Net.csproj` & `RingCentral.Net/RestClient.cs`

```
cd RingCentral.Net
dotnet pack
```

Update version number in `RingCentral.Net.PubnubPCL/RingCentral.Net.PubnubPCL.csproj`

```
cd RingCentral.Net.PubnubPCL
dotnet pack
```

Update version number in `RingCentral.Net.Pubnub\Properties\AssemblyInfo.css`

Rebuild solution

```
cd RingCentral.Net.Pubnub
nuget pack
```

Reference: [Quickstart: Create and publish a package using Visual Studio (.NET Framework, Windows)](https://docs.microsoft.com/en-us/nuget/quickstart/create-and-publish-a-package-using-visual-studio-net-framework)
