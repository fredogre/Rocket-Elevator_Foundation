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
    [Route("api/users")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly mathieu_appContext _context;

        public UsersController(mathieu_appContext context)
        {
            _context = context;
        }


        // GET api/users Will get all the list of users from database
        [HttpGet ("{email}" , Name = "GetEmail")]
        public ActionResult<Users> Get(string email)
        {
            var _result = _context.Users.Where(s=>s.Email==email).FirstOrDefault();
            if (_result == null)
            {
                throw new HttpResponseException(HttpStatusCode.Unauthorized);
            } 
            return _result;
        }


    }
}