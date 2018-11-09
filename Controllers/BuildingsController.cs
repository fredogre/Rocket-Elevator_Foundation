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
    [Route("api/buildings")]
    [ApiController]
    public class BuildingsController : ControllerBase
    {
        private readonly mathieu_appContext _context;
        public BuildingsController(mathieu_appContext context)
        {
            _context = context;
        }

        // GET api/buildings/intervention Will get the elevators from the batteries tables, columns table or elevators table that needs Intervention 
        [HttpGet("intervention")]
        public ActionResult<List<Buildings>> Get()
        {
            List<long> batteryIds = new List<long>();
            List<long> columnIds = new List<long>();
            List<long> elevatorIds = new List<long>();
            //batteryIds.Add(2915);
            var elevators = _context.Elevators.Where(e => e.Status == "Intervention");
            foreach (Elevators elevator in elevators)
            {
                if (elevator.ColumnId.HasValue)
                {
                    columnIds.Add(elevator.ColumnId.Value);
                }
            }
            var columns = _context.Columns.Where(column => column.Status == "Intervention" || columnIds.Contains(column.Id));
            foreach (Columns column in columns)
            {
                if (column.BatteryId.HasValue)
                {
                    batteryIds.Add(column.BatteryId.Value);
                }
            }

            var batteries = _context.Batteries.Where(battery => battery.Status == "Intervention" || batteryIds.Contains(battery.Id));
            var buildingIds = batteries.Select(b => b.BuildingId);
            var result = _context.Buildings.Where(building => buildingIds.Contains(building.Id));
            return result.ToList();
        }
    }
}