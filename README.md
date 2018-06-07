DependencyInjection
-------------------

[![Build status](https://ci.appveyor.com/api/projects/status/iuo60eg8q0cuh5p7/branch/dev?svg=true)](https://ci.appveyor.com/project/AppCoreNet/dependencyinjection/branch/dev)

This repository includes projects containing abstractions and implementations for various dependency injection containers.
The AppCore .NET DI framework provides dependency injection container APIs which are agnostic of the actual DI container. 

## Packages

Package                                            | Description
---------------------------------------------------|------------------------------------------------------------------
`AppCore.DependencyInjection.Abstractions`         | Provides the container agnostic public API of the DI framework.
`AppCore.DependencyInjection.AssemblyExtensions`   | Provides extensions to register component via assembly scanning.
`AppCore.DependencyInjection.Autofac`              | Autofac based implementations.
`AppCore.DependencyInjection.Microsoft.Extensions` | Microsoft.Extensions.DependencyInjection based implementations.
`AppCore.DependencyInjection.StructureMap`         | StructureMap based implementations.
