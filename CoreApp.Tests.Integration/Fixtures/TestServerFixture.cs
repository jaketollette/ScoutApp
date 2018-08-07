using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.TestHost;
using Microsoft.Extensions.PlatformAbstractions;
using System;
using System.IO;
using System.Net.Http;

namespace CoreApp.Tests.Integration.Fixtures
{
    public class TestServerFixture : IDisposable
    {
        private TestServer testServer;
        public HttpClient Client { get; set; }

        public TestServerFixture()
        {
            var builder = new WebHostBuilder()
                .UseContentRoot(GetContentRootPath())
                .UseEnvironment("Testing")
                .UseStartup<TestStartup>();

            testServer = new TestServer(builder);
            Client = testServer.CreateClient();
        }

        private string GetContentRootPath()
        {
            var testProjectPath = PlatformServices.Default.Application.ApplicationBasePath;
            var relativePathToHostProject = @"..\..\..\..\CoreApp.WebUI";
            return Path.GetFullPath(Path.Combine(testProjectPath, relativePathToHostProject));
        }

        public void Dispose()
        {
            Client.Dispose();
            testServer.Dispose();
        }
    }
}
