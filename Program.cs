using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using RocketApi.Models;

namespace RocketApi
{
    public class Program
    {      
        public static IWebHostBuilder CreateWebHostBuilder(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                .UseStartup<Startup>();  
        public static void Main(string[] args)
        {
            CreateWebHostBuilder(args).Build().Run();

            var dbContext = new mathieu_appContext();
            var addresses = dbContext.Addresses.ToList();
            foreach(var c in addresses) {
                System.Console.WriteLine($"ID:{c.Id} Name:{c.City}");
            }
        }
    }
}
