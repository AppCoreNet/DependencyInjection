// Licensed under the MIT License.
// Copyright (c) 2018 the AppCore .NET project.

using AppCore.DependencyInjection.Facilities;

namespace AppCore.DependencyInjection
{
    class TestFacilityExtension : FacilityExtension<TestFacility>
    {
        protected override void RegisterComponents(IComponentRegistry registry, TestFacility facility)
        {
            registry.Register<ITestFacilityService>()
                    .Add<TestFacilityExtensionService>();
        }
    }
}