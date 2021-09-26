using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals
{
    class koala: Animal
    {
        public string Postion { get; set; }

        public override void Food()
        {
            Console.WriteLine("Ест листья эвкалипта");
        }

        public override void Movement()
        {
            Console.WriteLine("прдепочитает перебираться на деревьях");
        }

    }
}
