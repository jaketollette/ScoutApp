using CoreApp.Core.Concrete;
using CoreApp.Tests.Integration.Fixtures;
using FluentAssertions;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace CoreApp.Tests.Integration.Controllers
{
    public class ScoutsControllerTests : IClassFixture<TestServerFixture>
    {
        private TestServerFixture fixture;

        public ScoutsControllerTests(TestServerFixture fixture)
        {
            this.fixture = fixture;
        }

        [Fact]
        public async Task Index_ReturnsListOfScouts()
        {
            var response = await fixture.Client.GetAsync("api/scouts");

            response.EnsureSuccessStatusCode();
            var responseString = await response.Content.ReadAsStringAsync();
            var scouts = JsonConvert.DeserializeObject<List<Scout>>(responseString);

            // Assert
            scouts.Count().Should().Be(4);
        }
    }
}
