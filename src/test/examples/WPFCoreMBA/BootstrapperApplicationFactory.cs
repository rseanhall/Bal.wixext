// Copyright (c) .NET Foundation and contributors. All rights reserved. Licensed under the Microsoft Reciprocal License. See LICENSE.TXT file in the project root for full license information.

namespace WixToolset.Dnc.Host
{
    using System.Runtime.InteropServices;
    using Example.WPFCoreMBA;
    using WixToolset.Mba.Core;

    delegate IBootstrapperApplicationFactory StaticEntryDelegate([MarshalAs(UnmanagedType.LPWStr)] string baFactoryAssemblyName, [MarshalAs(UnmanagedType.LPWStr)] string baFactoryAssemblyPath);

    /// <summary>
    /// Entry point for the .NET Core host to create and return the BA to the engine.
    /// </summary>
    public static class BootstrapperApplicationFactory
    {
        // Entry point for the DNC host.
        public static IBootstrapperApplicationFactory CreateBAFactory([MarshalAs(UnmanagedType.LPWStr)] string baFactoryAssemblyName, [MarshalAs(UnmanagedType.LPWStr)] string baFactoryAssemblyPath)
        {
            return new WPFCoreBAFactory();
        }
    }
}
