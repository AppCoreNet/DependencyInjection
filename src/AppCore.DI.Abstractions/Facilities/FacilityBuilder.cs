﻿// Licensed under the MIT License.
// Copyright (c) 2018 the AppCore .NET project.

using System.Collections.Generic;
using AppCore.Diagnostics;

namespace AppCore.DependencyInjection.Facilities
{
    internal sealed class FacilityBuilder<TFacility> : IFacilityBuilder<TFacility>
        where TFacility : IFacility
    {
        private readonly List<IFacilityExtension<TFacility>> _extensions = new List<IFacilityExtension<TFacility>>();

        public TFacility Facility { get; }

        public FacilityBuilder(TFacility facility)
        {
            Facility = facility;
        }

        public void RegisterComponents(IComponentRegistry registry)
        {
            Facility.RegisterComponents(registry);

            foreach (IFacilityExtension<TFacility> facilityExtension in _extensions)
            {
                facilityExtension.RegisterComponents(registry, Facility);
            }
        }

        public IFacilityExtensionBuilder<TFacility, TExtension> AddExtension<TExtension>(TExtension extension)
            where TExtension : IFacilityExtension<TFacility>
        {
            Ensure.Arg.NotNull(extension, nameof(extension));
            _extensions.Add(extension);
            return new FacilityExtensionBuilder<TFacility, TExtension>(this, extension);
        }

        public IFacilityExtensionBuilder<TFacility, TExtension> AddExtension<TExtension>()
            where TExtension : IFacilityExtension<TFacility>, new()
        {
            return AddExtension(new TExtension());
        }
    }
}