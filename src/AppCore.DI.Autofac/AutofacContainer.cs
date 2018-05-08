﻿// Copyright 2018 the AppCore project.
// 
// Permission is hereby granted, free of charge, to any person obtaining a copy of this software and associated
// documentation files (the "Software"), to deal in the Software without restriction, including without limitation
// the rights to use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies of the Software, and
// to permit persons to whom the Software is furnished to do so, subject to the following conditions:
// 
// The above copyright notice and this permission notice shall be included in all copies or substantial portions
// of the Software.
// 
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING
// BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND
// NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM,
// DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
// OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.

using System;
using System.Linq;
using AppCore.Diagnostics;
using Autofac;
using Autofac.Features.Variance;

namespace AppCore.DependencyInjection.Autofac
{
    /// <summary>
    /// Autofac based <see cref="IContainer"/> implementation.
    /// </summary>
    public class AutofacContainer : IContainer
    {
        private readonly IComponentContext _context;

        public ContainerCapabilities Capabilities { get; }

        /// <summary>
        /// Initializes a new instance of the <see cref="AutofacContainer"/> class.
        /// </summary>
        /// <param name="context">The <see cref="IComponentContext"/>.</param>
        public AutofacContainer(IComponentContext context)
        {
            Ensure.Arg.NotNull(context, nameof(context));

            _context = context;

            var capabilities = ContainerCapabilities.None;
            if (context.ComponentRegistry.Sources.OfType<ContravariantRegistrationSource>().Any())
                capabilities = capabilities | ContainerCapabilities.ContraVariance;

            Capabilities = capabilities;
        }

        public object Resolve(Type contractType)
        {
            return _context.Resolve(contractType);
        }

        /// <inheritdoc />
        public object ResolveOptional(Type contractType)
        {
            return _context.ResolveOptional(contractType);
        }
    }
}