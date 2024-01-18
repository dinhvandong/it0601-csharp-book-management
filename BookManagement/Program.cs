using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookManagement
{
    internal class Program
    {
        static void Main(string[] args)
        {

            List<Publication> publications = new List<Publication>();

            //        public Book(string title, decimal price, int copies, string author)

            Book book1 = new Book("Programming1", 100, 100, "John Admit");
            Book book2 = new Book("Programming2", 100, 100, "John Admit");
            Book book3= new Book("Programming3", 100, 100, "John Admit");
            Book book4 = new Book("Programming4", 100, 100, "John Admit");
            Book book5 = new Book("Programming5", 100, 100, "John Admit");
            Book book6 = new Book("Programming6", 100, 100, "John Admit");
            Book book7 = new Book("Programming7", 100, 100, "John Admit");

            publications.Add(book1);
            publications.Add(book2);
            publications.Add(book3);
            publications.Add(book4);
            publications.Add(book5);
            publications.Add(book6);
            publications.Add(book7);

            Magazine magazine1 = new Magazine("Beauty1", 200, 10, 1, 1);
            Magazine magazine2 = new Magazine("Beauty2", 200, 10, 1, 1);
            Magazine magazine3 = new Magazine("Beauty3", 200, 10, 1, 1);
            Magazine magazine4 = new Magazine("Beauty4", 200, 10, 1, 1);
            Magazine magazine5 = new Magazine("Beauty5", 200, 10, 1, 1);
            Magazine magazine6 = new Magazine("Beauty6", 200, 10, 1, 1);

            publications.Add(magazine1);
            publications.Add(magazine2);
            publications.Add(magazine3);
            publications.Add(magazine4);
            publications.Add(magazine5);
            publications.Add(magazine6);

            int countBooks = 0;
            int countMagazines = 0;
            foreach (var item in publications)
            {

                if(item is
                    Magazine)
                {
                    countMagazines++;
                }else if(item is Book)
                {
                    countBooks++;
                }
            }

            Console.WriteLine("Number of Books is " + countBooks);
            Console.WriteLine("Number of Magazine is " + countMagazines);


            Console.ReadKey();



        }
    }
}
