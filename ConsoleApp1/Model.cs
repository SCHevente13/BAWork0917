using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
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
        public List<string> AfterYear(int year)
        {
            return cars.Where(x=> x.BuiltYear > year).Select(x=> x.Type).ToList();
        }
        public List<string> StrongerHp(int hp)
        {
            return cars.Where(x=> x.Hp > hp).Select(x=> x.Type).ToList();
        }
        public List<string> ExpensiveThan(int price)
        {
            return cars.Where(x=> x.Price > price).Select(x=> x.Type).ToList();
        }
        public int SearchByBrand(string brand)
        {
            return cars.Where(x => x.Brand == brand).Count();
        }
        public bool CheckByBrand(string brand)
        {
            return cars.Where(x => x.Brand == brand).Any();
        }
        public bool IsThereStrongerThan(int hp)
        {
            return cars.Where(x=> x.Hp > hp).Any();
        }
        public int GetMostExpensive()
        {
            return cars.Select(x => x.Price).Max();
        }
        public double GetAverageByBrand(string brand)
        {
            return cars.Where(x=> x.Brand == brand).Average(x=> x.Price);
        }
        public double GetAverage()
        {
            return cars.Average(x => x.Price);
        }
        public List<string> SortByPrice()
        {
            return cars.OrderBy(x => x.Price).Select(x => x.Type).ToList();
        }
        public List<string> SortByHp()
        {
            return cars.OrderByDescending(x => x.Hp).Select(x => x.Type).ToList();
        }
        public List<string> BetwenTwoYears(int year1, int year2)
        {
            int bigger = year1 > year2 ? year1 : year2;
            int smaller = year1 < year2 ? year1 : year2;
            return cars.Where(x => x.BuiltYear < bigger && x.BuiltYear > smaller).Select(x => x.Type).ToList();
        }
        public List<string> GetByMinHpNMaxPrice(int minHp, int maxPrice)
        {
            return cars.Where(x => x.Hp > minHp && x.Price < maxPrice).Select(x => x.Type).ToList();
        }
        public string GetYoungest()
        {
            return cars.OrderByDescending(x => x.BuiltYear).Select(x => x.Type).First();
        }
        public string GetOldest()
        {
            return cars.OrderByDescending(x => x.BuiltYear).Select(x => x.Type).Last();
        }
        public List<string> GetExpensiveByCount(int count)
        {
            return cars.OrderByDescending(x => x.Price).Select(x => x.Type).Take(count).ToList();
        }
        public List<string> GetStrongestByCount(int count)
        {
            return cars.OrderByDescending(x => x.Hp).Select(x => x.Type).Take(count).ToList();
        }
        public List<string> GetByBrandWithHpOrder(string brand)
        {
            return cars.Where(x=> x.Brand == brand).OrderByDescending(x => x.Hp).Select(x => x.Type).ToList();
        }
        public int GetCountFromThatYear(int year)
        {
            return cars.Where(x => x.BuiltYear > year).Count();
        }
        public double GetAveragePriceByMinHP(int minHP)
        {
            return cars.Where(x => x.Hp > minHP).Average(x => x.Price);
        }
        public string GetMinPriceByLowestPrice(int minPrice)
        {
            return cars.Where(x => x.Price > minPrice).OrderBy(x => x.Price).Select(x => x.Type).First();
        }

    }
}
