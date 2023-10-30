using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp20
{
    internal abstract class Product
    {
        public static int _id;
        public int Id { get; set; }
        public int Price { get; set; }
        public string Name { get; set; }
        public float Count { get; set; }
        public int TotalIntCome { get; set; }
        public abstract float Sell();
        public abstract void ShowInfo();

    }
}
