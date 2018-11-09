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
    [Route("api/elevators")]
    [ApiController]
    public class ElevatorsController : ControllerBase
    {
        private readonly mathieu_appContext _context;

        public ElevatorsController(mathieu_appContext context)
        {
            _context = context;
        }


        // GET api/elevators Will get all the list of elevators from database
        [HttpGet]
        public ActionResult<List<Elevators>> Get()
        {
            return _context.Elevators.ToList();
        }

        // GET api/elevators/5 Allow you to specify an elevator from the database to see their id and status
        [HttpGet("{id}")]
        public ActionResult<Elevators> Get(long id)
        {
            var item = _context.Elevators.Find(id);
            if (item == null)
            {
                return NotFound();
            }
            var res = new JObject();
            res["id"] = item.Id;
            res["status"] = item.Status;
            return Content(res.ToString(), "application/json");
        }

        [HttpGet("status")] // GET api/elevators/status  Will return the list of all elevators with the status of Intervention or Inactive
        public ActionResult<List<Elevators>> Get(string status)
        {
            var item = _context.Elevators.Where(s => s.Status != "Active");
            if (item == null)
            {
                return NotFound();
            }
            var res = new JObject();
            // res["id"] = item.Id;
            // res["status"] = item.Status;
            return item.ToList();
        }


        // PUT api/elevators/5 Allow you update the status of a specific elevator from the database
        [HttpPut("{id}")]
                public IActionResult Update(long id, Elevators item)
        {
            var change = _context.Elevators.Find(id);
            if (change == null)
            {
                return NotFound();
            }
            //change.IsComplete = item.IsComplete;
            change.Status = item.Status;

            _context.Elevators.Update(change);
            _context.SaveChanges();
            return NoContent();
        }


    }
}