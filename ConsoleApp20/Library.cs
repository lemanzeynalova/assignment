using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp20
{
    internal class Library
    {
        Book[] myArray = new Book[0];

        public int Id { get; private set; }

        public void AddBook(Book book)
        {
            Array.Resize(ref myArray, myArray.Length+1);
            myArray[myArray.Length-1] = book;
        }
        public Book GetBookById(int id)
        {
            int i = Index(id);
            if (Id == -1)
                Console.WriteLine("BELE DEYER YOXDUR");
           else 
           {
                return myArray[i];
           }

            return null;

        }

        int Index(int id)
        {
            for (int i = 0; i < myArray.Length; i++)
            {
                if (myArray[i].Id == id) return i;
            }
            return -1;
        }
       
    }
}
