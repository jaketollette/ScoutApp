using AutoMapper;
using CoreApp.Core.Abstract;
using CoreApp.Core.Concrete;
using CoreApp.WebUI.Models;
using Microsoft.AspNetCore.Mvc;
using System;
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

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var model = mapper.Map<Scout, ScoutViewModel>(scoutService.GetScout(id));
            if(model == null)
            {
                return NotFound();
            }
            return Ok(model);
        }

        [HttpPost]
        public IActionResult Post([FromBody] ScoutViewModel model)
        {
            if(model == null)
            {
                return BadRequest();
            }

            if(ModelState.IsValid)
            {
                // Valid model

                var scout = mapper.Map<ScoutViewModel, Scout>(model);
                try
                {
                    scoutService.AddScout(scout);
                    return CreatedAtAction("Get", new { id = scout.Id }, mapper.Map<Scout, ScoutViewModel>(scout));
                }
                catch (Exception ex)
                {
                    ModelState.AddModelError("", ex.Message);
                    return BadRequest(model);
                }
            }

            return BadRequest(model);
        }
    }
}