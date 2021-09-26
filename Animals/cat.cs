using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals
{
    class cat: Animal 
    {
        public string Postion { get; set; }

        public override void Food()
        {
            Console.WriteLine("Ест рыбу");
        }

        public override void Movement()
        {
            Console.WriteLine("Может подняться на дерево");
        }
    }
}
