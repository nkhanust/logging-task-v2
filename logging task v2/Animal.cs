using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace logging_task_v2
{
   public abstract class Animal
    {
        public virtual void Print()
        {
            Console.WriteLine("This is an animal");
        }
        public virtual void Sound()
        {
            Console.WriteLine("Animal makes a sound");
        }
    }
}
