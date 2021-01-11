// Copyright (c) .NET Foundation and contributors. All rights reserved. Licensed under the Microsoft Reciprocal License. See LICENSE.TXT file in the project root for full license information.

[assembly: WixToolset.Mba.Core.BootstrapperApplicationFactory(typeof(Example.WPFCoreMBA.WPFCoreBAFactory))]
namespace Example.WPFCoreMBA
{
    using System.Diagnostics.CodeAnalysis;
    using WixToolset.Mba.Core;

    public class WPFCoreBAFactory : BaseBootstrapperApplicationFactory
    {
        private static int loadCount = 0;

        [DynamicDependency("GetFunctionPointer(System.IntPtr,System.IntPtr,System.IntPtr,System.IntPtr,System.IntPtr,System.IntPtr)", "Internal.Runtime.InteropServices.ComponentActivator", "System.Private.CoreLib")]
        public WPFCoreBAFactory() { }

        protected override IBootstrapperApplication Create(IEngine engine, IBootstrapperCommand bootstrapperCommand)
        {
            if (loadCount > 0)
            {
                engine.Log(LogLevel.Standard, $"Reloaded {loadCount} time(s)");
            }
            ++loadCount;
            return new WPFCoreBA(engine);
        }
    }
}
