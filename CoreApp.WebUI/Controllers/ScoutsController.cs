using AutoMapper;
using CoreApp.Core.Abstract;
using CoreApp.Core.Concrete;
using CoreApp.WebUI.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace CoreApp.WebUI.Controllers
{
    [Route("api/[controller]")]
    public class ScoutsController : Controller
    {
        private readonly IScoutService scoutService;
        private readonly IMapper mapper;

        public ScoutsController(IScoutService scoutService, IMapper mapper)
        {
            this.scoutService = scoutService;
            this.mapper = mapper;
        }

        [HttpGet]
        public IActionResult Get()
        {
            var model = new List<ScoutViewModel>();
            scoutService.GetScouts().ToList().ForEach(s =>
            {
                ScoutViewModel scout = mapper.Map<Scout, ScoutViewModel>(s);
                model.Add(scout);
            });

            if (model.Count() == 0)
            {
                model.Add(new ScoutViewModel());
            }
            return Ok(model);
        }
    }
}