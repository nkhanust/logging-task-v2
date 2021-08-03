using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Serilog;
using System;
using System.Collections.Generic;
using System.IO;

namespace logging_task_v2
{
    class Program
    {
        static void Main (string[] args)
        {
            var builder = new ConfigurationBuilder();
            BuildConfig(builder);
                                                                // Set up for Log

            Log.Logger = new LoggerConfiguration()
                .ReadFrom.Configuration(builder.Build())       
                .CreateLogger();
            Log.Logger.Information("Starting now");
            var host = Host.CreateDefaultBuilder()
                .ConfigureServices((context, services) =>
                {
                    services.AddTransient<IGreetingService, GreetingService>();
                })
                .UseSerilog()
                .Build();

            var svc = ActivatorUtilities.CreateInstance<GreetingService>(host.Services);
            List<Animal> List = new List<Animal>();
            Animal L = new Lion();
            Animal D = new Dog();
            List.Add(L);
            List.Add(D);

            D.Sound();
            D.Print();
            L.Print();

            try
            {
                //Pass the filepath and filename to the StreamWriter Constructor
                StreamWriter sw = new StreamWriter("D:\\UST Work\\Test.txt");
                sw.WriteLine("Animal makes a sound");
                sw.WriteLine("This is a dog, a domestic animal");
                sw.WriteLine("This is a lion, a wild animal");
                sw.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
            }
            finally
            {
                Console.WriteLine("I think this works now");
            }

        }

        static void BuildConfig(IConfigurationBuilder Builder)
        {
            Builder.SetBasePath(Directory.GetCurrentDirectory())
               .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
               .AddJsonFile($"appsettings.{Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT") ?? "Production"}.json", optional: true)
               .AddEnvironmentVariables();
        }

    }

}