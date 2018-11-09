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
    [Route("api/columns")]
    [ApiController]
    public class ColumnsController : ControllerBase
    {
        private readonly mathieu_appContext _context;

        public ColumnsController(mathieu_appContext context)
        {
            _context = context;
        }


        // GET api/columns  will fetch all columns in Database
        [HttpGet]
        public ActionResult<List<Columns>> Get()
        {
            return _context.Columns.ToList();
        }

        // GET api/columns/id   will fetch a specified column with Id
        [HttpGet("{id}")]
        public ActionResult<Columns> Get(long id)
        {
            var item = _context.Columns.Find(id);
            if (item == null)
            {
                return NotFound();
            }
            var res = new JObject(); // Phil Bouillon helped a lot with this one, it returns the results with only the Id and the Status of the column.
            res["id"] = item.Id;
            res["status"] = item.Status;
            return Content(res.ToString(), "application/json");
        }

        // PUT api/columns/{id}   Will change the Status of a specified column.
        [HttpPut("{id}")]
        public IActionResult Update(long id, Columns item)
        {
            var change = _context.Columns.Find(id); // Example from https://docs.microsoft.com/en-us/aspnet/core/tutorials/web-api-vsc?view=aspnetcore-2.1
            if (change == null)
            {
                return NotFound();
            }
            change.Status = item.Status;

            _context.Columns.Update(change);
            _context.SaveChanges();
            return NoContent();
        }
    }
}