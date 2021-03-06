﻿// Licensed under the MIT License.
// Copyright (c) 2018,2019 the AppCore .NET project.

using System;
using System.ComponentModel;

namespace AppCore.DependencyInjection.Facilities
{
    /// <summary>
    /// Represents a type to configure facility extensions.
    /// </summary>
    /// <typeparam name="TFacility">The type of the facility.</typeparam>
    /// <typeparam name="TExtension">The type of the facility extension.</typeparam>
    /// <seealso cref="IFacility"/>
    /// <seealso cref="IFacilityExtension{TFacility}"/>
    public interface IFacilityExtensionBuilder<out TFacility, out TExtension>
        where TFacility : IFacility
        where TExtension : IFacilityExtension<TFacility>
    {
        /// <summary>
        /// Configures the <see cref="IFacilityExtension{TFacility}"/> which is being registered.
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Never)]
        void Configure(Action<TFacility, TExtension> configure);
    }
}