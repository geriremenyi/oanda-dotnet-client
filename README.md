# Generated .NET core (C#) client for Oanda API V20

This repository contains generated code from the [oanda-openapi](https://github.com/geriremenyi/oanda-openapi) definition.

## Getting started

### Prerequisites

- [.NET Core 3.1 SDK](https://dotnet.microsoft.com/download) to build, run etc.
- [Visual Studio](https://visualstudio.microsoft.com) (optional) as the IDE.

### Local setup

1. Clone this repo
```bash
# HTTPS
https://github.com/geriremenyi/oanda-dotnet-client.git
# SSH
git@github.com:geriremenyi/oanda-dotnet-client.git
```

2. Navigate to the root of the project and restore nuget packages
```bash
dotnet restore GeriRemenyi.Oanda.V20.Client.sln
```

### Build

To build the generated client code:
```bash
dotnet build ./src/GeriRemenyi.Oanda.V20.Client/GeriRemenyi.Oanda.V20.Client.csproj
```

### Test

To test the generated client code
```bash
dotnet test ./src/GeriRemenyi.Oanda.V20.Client.Test/GeriRemenyi.Oanda.V20.Client.Test.csproj
```

## Nuget package


There is a [continuous deployment](.github/workflows/continuous_deployment.yaml) job setup which [runs on every merge to master](https://github.com/geriremenyi/oanda-dotnet-client/actions?query=workflow%3A%22Continuous+Deployment%22). This builds the client code and then pushes it to [nuget.org](https://www.nuget.org/).

Nuget package: https://www.nuget.org/packages/GeriRemenyi.Oanda.V20.Client/

## Contributing

Pull requests and any kind of contribution are welcome. For major changes, please open an issue first to discuss what you would like to change.

## License

[MIT](https://choosealicense.com/licenses/mit/)
