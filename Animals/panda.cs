using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals
{
    class panda: Animal
    {
        public string Postion { get; set; }

        public override void Laziness()
        {
            Console.WriteLine("Ленивая");
        }

        public override void Food()
        {
            Console.WriteLine("Ест бамбук");
        }
    }
}
