using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace logging_task_v2
{
    class Dog : Animal
    {
        public override void Print()
        {
            Console.WriteLine("This is a dog, a domestic animal");
        }
    }
}
