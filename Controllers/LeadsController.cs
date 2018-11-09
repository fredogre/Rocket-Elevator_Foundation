using System;
using Newtonsoft.Json.Linq;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using RocketApi.Models;
using Microsoft.EntityFrameworkCore;


namespace RocketApi.Controllers
{   // this is from https://docs.microsoft.com/en-us/aspnet/core/tutorials/web-api-vsc?view=aspnetcore-2.1
    [Route("api/leads")]
    [ApiController]
    public class LeadsController : ControllerBase
    {
        private readonly mathieu_appContext _context;

        public LeadsController(mathieu_appContext context)
        {
            _context = context;
        }

        // GET api/leads  will fetch all leads in Database
        [HttpGet]
        public ActionResult<List<Leads>> Get()
        {
            return _context.Leads.ToList();
        }

        // GET api/leads/new   will fetch all leads in Database that are not customers yet in the last 30 days!
        [HttpGet("new")]
        public ActionResult<List<Leads>> GetByNew()
        {
            DateTime newDate = DateTime.Now.AddDays(-30); // Code idea found here https://bytes.com/topic/c-sharp/answers/838286-datetime-now-30-days
            var item = _context.Leads.Where(update => update.UpdatedAt > newDate && update.CustomerId == null); // Example from here http://www.entityframeworktutorial.net/efcore/querying-in-ef-core.aspx
            if (item == null)
            {
                return NotFound();
            }
            return item.ToList();
        }
    }
}