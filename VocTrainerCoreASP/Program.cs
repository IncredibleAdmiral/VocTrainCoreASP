using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using VocTrainerCoreASP.Models;

namespace VocTrainerCoreASP
{
    public class Program
    {
        public static void Main(string[] args)
        {

            GeneralWordAndExamplesRepository.InitializationObjects();
            RandomExercise r = new RandomExercise();
            BuildWebHost(args).Run();

        }

        public static IWebHost BuildWebHost(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                .UseStartup<Startup>()
                .Build();
    }
}
