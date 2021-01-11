// Copyright (c) .NET Foundation and contributors. All rights reserved. Licensed under the Microsoft Reciprocal License. See LICENSE.TXT file in the project root for full license information.

namespace WixToolsetTest.ManagedHost
{
    using System.IO;
    using WixBuildTools.TestSupport;
    using WixToolset.Core.TestPackage;
    using Xunit;

    public class DncHostFixture
    {
        static readonly string bundleBasePath = TestData.Get("..", "examples");

        [Fact]
        public void CanLoadWPFCoreBundleTrimCopyUsedMBA()
        {
            using (var fs = new DisposableFileSystem())
            {
                var baseFolder = fs.GetFolder();
                var bundleFile = TestData.Get(bundleBasePath, "WPFCoreBundleTrimCopyUsed.exe");
                var testEngine = new TestEngine();

                var result = testEngine.RunShutdownEngine(bundleFile, baseFolder);
                var logMessages = result.Output;
                Assert.Equal("Loading .NET Core SCD bootstrapper application.", logMessages[0]);
                Assert.Equal("Creating BA thread to run asynchronously.", logMessages[1]);
                Assert.Equal("WPFCoreBA", logMessages[2]);
                Assert.Equal("Shutdown,ReloadBootstrapper,0", logMessages[3]);
            }
        }

        [Fact]
        public void CanLoadWPFCoreBundleUntrimmedMBA()
        {
            using (var fs = new DisposableFileSystem())
            {
                var baseFolder = fs.GetFolder();
                var bundleFile = TestData.Get(bundleBasePath, "WPFCoreBundleUntrimmed.exe");
                var testEngine = new TestEngine();

                var result = testEngine.RunShutdownEngine(bundleFile, baseFolder);
                var logMessages = result.Output;
                Assert.Equal("Loading .NET Core SCD bootstrapper application.", logMessages[0]);
                Assert.Equal("Creating BA thread to run asynchronously.", logMessages[1]);
                Assert.Equal("WPFCoreBA", logMessages[2]);
                Assert.Equal("Shutdown,ReloadBootstrapper,0", logMessages[3]);
            }
        }

        [Fact]
        public void CanLoadWPFCoreBundleTrimLinkMBA()
        {
            using (var fs = new DisposableFileSystem())
            {
                var baseFolder = fs.GetFolder();
                var bundleFile = TestData.Get(bundleBasePath, "WPFCoreBundleTrimLink.exe");
                var testEngine = new TestEngine();

                var result = testEngine.RunShutdownEngine(bundleFile, baseFolder);
                var logMessages = result.Output;
                Assert.Equal("Loading .NET Core SCD bootstrapper application.", logMessages[0]);
                Assert.Equal("Creating BA thread to run asynchronously.", logMessages[1]);
                Assert.Equal("WPFCoreBA", logMessages[2]);
                Assert.Equal("Shutdown,ReloadBootstrapper,0", logMessages[3]);
            }
        }
    }
}
