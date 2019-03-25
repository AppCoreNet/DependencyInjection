AppCore .NET Dependency Injection
---------------------------------

[![Build Status](https://dev.azure.com/AppCoreNet/DependencyInjection/_apis/build/status/AppCoreNet.DependencyInjection?branchName=dev)](https://dev.azure.com/AppCoreNet/DependencyInjection/_build/latest?definitionId=2&branchName=dev)

This repository contains dependency injection container abstractions and implementations targeting the .NET Framework and .NET Core.

All artifacts are licensed under the [MIT license](LICENSE). You are free to use them in open-source or commercial projects as long
as you keep the copyright notice intact when redistributing or otherwise reusing our artifacts.

## Packages

Package                                                         | Description
----------------------------------------------------------------|------------------------------------------------------------------------------------------------------
`AppCore.DependencyInjection.Abstractions`                | Contains the public API for the dependency injection framework.
`AppCore.DependencyInjection.AssemblyExtensions`         | Provides extensions to register components by scanning assemblies.
`AppCore.DependencyInjection.DependencyModelExtensions` | Provides extensions to register components by scanning the `DependencyContext` of the application.
`AppCore.DependencyInjection.Autofac`                      | Integrates [Autofac](https://autofac.org/) with the dependency injection framework.
`AppCore.DependencyInjection.Microsoft.Extensions`       | Integration of [Microsoft.Extensions.DependencyInjection](https://docs.microsoft.com/en-us/dotnet/api/microsoft.extensions.dependencyinjection).
`AppCore.DependencyInjection.StructureMap`                | Integration of [StructureMap](http://structuremap.github.io/).

### Abstractions

This packages includes the API for registering and resolving services, regardless of which dependency injection container your are using. It also provides support for
separating your registrations into units called `Facility` and `FacilityExtension`.

### AssemblyExtensions

Provides extensions to the registration API for dynamically registering services by scanning assemblies for implementations.

### DependencyModelExtensions

Provides extensions to the registration API for dynamically registering services by scanning assemblies known to the `DependencyContext`.

### Autofac

Adds support for using the Autofac DI container.

### Microsoft.Extensions

Adds support for using the Microsoft.Extensions DI container.

### StructureMap

Adds support for using the StructureMap DI container.

## Contributing

Contributions, whether you file an issue, fix some bug or implement a new feature, are highly appreciated. The whole user community
will benefit from them.

Please refer to the [Contribution guide](CONTRIBUTING.md).
