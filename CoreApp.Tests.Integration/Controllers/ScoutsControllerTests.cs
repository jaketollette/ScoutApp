using CoreApp.Core.Concrete;
using CoreApp.Tests.Integration.Fixtures;
using CoreApp.WebUI.Models;
using FluentAssertions;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
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
        public async Task Get_ReturnsListOfScouts()
        {
            var response = await fixture.Client.GetAsync("api/scouts");

            response.EnsureSuccessStatusCode();
            var responseString = await response.Content.ReadAsStringAsync();
            var scouts = JsonConvert.DeserializeObject<List<Scout>>(responseString);

            // Assert
            scouts.Count().Should().Be(5);
            scouts[0].FirstName.Should().Be("Johnny");
        }

        [Fact]
        public async Task Get_ReturnsScout_GivenId()
        {
            var response = await fixture.Client.GetAsync("api/scouts/3");

            response.EnsureSuccessStatusCode();
            var responseString = await response.Content.ReadAsStringAsync();
            var scout = JsonConvert.DeserializeObject<Scout>(responseString);

            // Assert
            scout.Should().NotBeNull();
            scout.FirstName.Should().Be("Billy");
            scout.LastName.Should().Be("Jones");
        }

        [Fact]
        public async Task Post_CreatesNewScout_GivenValidModel()
        {
            var model = new ScoutViewModel
            {
                FirstName = "Jake",
                LastName = "Tollette",
                Active = true,
                Birthday = new DateTime(1983, 8, 23),
                StartDate = DateTime.Now
            };

            var response = await fixture.Client.PostAsJsonAsync("api/scouts", model);

            response.EnsureSuccessStatusCode();
            var newScout = await response.Content.ReadAsAsync<ScoutViewModel>();
            var location = response.Headers.Location;

            // Assert
            newScout.FirstName.Should().Be("Jake");
            location.AbsolutePath.Should().Be("/api/Scouts/" + newScout.Id);

        }
    }
}
