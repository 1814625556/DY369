using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpringIoc
{
    public class Animals
    {
        private IEnumerable<Fruit> _fruits;

        public Animals(IEnumerable<Fruit> fruits)
        {
            _fruits = fruits;
        }

        public IList<int> FruitStr { get; set; }
    }

    public class Fruit
    {
        public string FruitName { get; set; }
    }
}
