﻿// Licensed under the MIT License.
// Copyright (c) 2018 the AppCore .NET project.

namespace AppCore.DependencyInjection.Builder
{
    public interface IComponentRegistrationInfoWithLifetime : IComponentRegistrationInfo
    {
        ComponentLifetime Lifetime { get; set; }
    }
}