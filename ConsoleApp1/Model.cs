using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Model
    {
        public List<Cars> cars = new List<Cars>();
        private void Import()
        {
            cars = File.ReadAllLines("cars.txt").Skip(1).Select(x => new Cars(x)).ToList();
        }
        public Model()
        {
            Import();
        }
    }
}
