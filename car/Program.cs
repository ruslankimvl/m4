using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hw
{
    class car
    {
        public car()
        {
            this.brand = "";
            this.model = "";
            this.hp = 0;
            this.volume = 0;
            this.color = "white";
        }
        private int hp { get; set; }
        private double volume { get; set; }
        private string model { set; get; }
        private string brand { set; get; }
        private string color { set; get; }
        public void get_info()
        {
            Console.WriteLine("Brand - {0}", brand);
            Console.WriteLine("Model - {0}", model);
            Console.WriteLine("Horse powers - {0}", hp);
            Console.WriteLine("Volume - {0}", volume);
            Console.WriteLine("Color - {0}", color);
        }
        public void get_engine_info()
        {
            Console.WriteLine("Horse powers - {0}", hp);

            Console.WriteLine("Volume - {0}", volume);
        }






    }
}