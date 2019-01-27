﻿// Licensed under the MIT License.
// Copyright (c) 2018 the AppCore .NET project.

namespace AppCore.DependencyInjection.Facilities
{
    /// <summary>
    /// Abstract base class for the <see cref="IFacility"/> type.
    /// </summary>
    /// <seealso cref="IFacility"/>
    public abstract class Facility : IFacility
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Facility"/> class.
        /// </summary>
        protected Facility()
        {
        }

        /// <summary>
        /// Must be implemented to register the components of the facility.
        /// </summary>
        /// <param name="registry">The <see cref="IComponentRegistry"/> where components are registered.</param>
        protected abstract void RegisterComponents(IComponentRegistry registry);

        void IFacility.RegisterComponents(IComponentRegistry registry)
        {
            RegisterComponents(registry);
        }
    }
}