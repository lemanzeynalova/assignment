using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp20
{
    internal class Book:Product
    {
        public string AuthorName { get; set; }
        public int PageCount { get; set; }
        
        public Book()
        {
                _id++;
                _id = Id;
        }
        public override float Sell()
        {
            return Price * Count;
        }

        public override void ShowInfo()
        {
            Console.WriteLine($"{AuthorName} {Count} {Id} {Name} {PageCount} {Price} {TotalIntCome}");

        }
    }
}
