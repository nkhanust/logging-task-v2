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
        static void Main(string[] args)
        {

            
            List<Animal> List = new List<Animal>();
            Animal L = new Lion();
            Animal D = new Dog();
            List.Add(L);
            List.Add(D);

            D.Sound();
            D.Print();
            L.Print();


        }

    }

}