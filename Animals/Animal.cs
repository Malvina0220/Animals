using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals
{
    class Animal
    {
        public string Name { get; set; }
        public string View { get; set; }

        public Animal()
        {


        }

        public Animal (string name, string view)
        {
            Name = name;
            View = view;

        }

        public void Going()
        {
            Console.WriteLine("Умеет ходить");
        }

        public void Voice()
        {
            Console.WriteLine("Может издавать звуки");
        }

        virtual public void Food()
        {
            Console.WriteLine("Ест пищу");
        }

        virtual public void Laziness()
        {
            Console.WriteLine("Оно ленивое");
        }

        virtual public void Movement()
        {
            Console.WriteLine("Может лазить по деревьям");
        }


    }
}
