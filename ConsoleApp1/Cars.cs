using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Cars
    {
        public string Brand { get; set; }
        public string Type { get; set; }
        public int BuiltYear { get; set; }
        public int Hp { get; set; }
        public int Price { get; set; }
        public Cars(string line)
        {
            string[] data = line.Split(';');
            Brand = data[0];
            Type = data[1];
            BuiltYear = int.Parse(data[2]);
            Hp = int.Parse(data[3]);
            Price = int.Parse(data[4]);
        }
    }
}
