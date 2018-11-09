using System;
using Newtonsoft.Json.Linq;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using RocketApi.Models;
using Microsoft.EntityFrameworkCore;


namespace RocketApi.Controllers
{    // this is from https://docs.microsoft.com/en-us/aspnet/core/tutorials/web-api-vsc?view=aspnetcore-2.1
    [Route("api/batteries")]
    [ApiController]
    public class BatteriesController : ControllerBase
    {
        private readonly mathieu_appContext _context;

        public BatteriesController(mathieu_appContext context)
        {
            _context = context;
        }

   
        // GET api/batteries Will get all the list of the batteries from the database
        [HttpGet]
        public ActionResult<List<Batteries>> Get()
        {
            return _context.Batteries.ToList();
        }

        // GET api/batteries/5 Allow you to specify a batteries from the database to see their id and status
        [HttpGet("{id}")]
        public ActionResult<Batteries> Get(long id)
        {
            var item = _context.Batteries.Find(id);
            if (item == null)
            {
                return NotFound();
            }
            var res = new JObject();
            res["id"] = item.Id;
            res["status"] = item.Status;
            return Content(res.ToString(), "application/json");
        }


        // PUT api/batteries/5 Allow you update the status of a specific batteries from the database
        [HttpPut("{id}")]
              public IActionResult Update(long id, Batteries item)
        {
            var change = _context.Batteries.Find(id);
            if (change == null)
            {
                return NotFound();
            }
            //change.IsComplete = item.IsComplete;
            change.Status = item.Status;

            _context.Batteries.Update(change);
            _context.SaveChanges();
            return NoContent();
        }

    }
}