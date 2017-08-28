using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace ModuleControlLINQ
{
    class Book
    {
        public string Author;
        public string Name;
        public int Year;
    }

    class Program
    {
        static void Main(string[] args)
        {
            //Первое задание
            Console.WriteLine("FIRST");
            List<Book> books = new List<Book>();
            books.Add(new Book { Name = "LINQ olda", Year = 1876, Author = "Dyadya" });
            books.Add(new Book { Name = "gfsdholda", Year = 1876, Author = "Dyadya" });
            books.Add(new Book { Name = "LINQ olda", Year = 1875, Author = "Tyotya" });
            books.Add(new Book { Name = "LINgfsdlda", Year = 1875, Author = "Tyotya" });
            books.Add(new Book { Name = "LINQgfds olda", Year = 1872, Author = "Tyotya" });
            books.Add(new Book { Name = "Lda", Year = 2002, Author = "LOLOLOLALALA" });
            var query1 = books.Where(x => DateTime.IsLeapYear(x.Year)).Where(x => Regex.IsMatch(x.Name, "LINQ"));
            foreach (var book in query1)
            {
                Console.WriteLine(book.Name);
            }
            Console.WriteLine("==============================================");

            //Второе здание
            Console.WriteLine("SECOND");
            List<string> words = new List<string>();
            words.Add("СВЫФОсвыф");
            words.Add("СВЫпфваыВваФОсв ыф");
            words.Add("СДпавыВЫ пфваыВваФОсв ыф");
            var query2 = words.SelectMany(x => x.ToLower()).Distinct().Where(x => x != ' ').Count();
            Console.WriteLine(query2);
            Console.WriteLine("==============================================");


            //Третье здание
            Console.WriteLine("THIRD");
            int[] integers = { 14, 12, 23, 20, 33, 32};
            var query3 = integers.OrderBy(x => x / 10).ThenByDescending(x => x % 10);
            foreach (var integer in query3)
            {
                Console.WriteLine(integer);
            }
            Console.WriteLine("==============================================");


            //Четвёртое здание
            Console.WriteLine("FOURTH");
            var query4 = books.GroupBy(x => x.Author).Select(x => $"{x.Key},  {x.Count()}");
            foreach (var item in query4)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("==============================================");


            //Пятое здание
            Console.WriteLine("FIFTH");

            Console.WriteLine("==============================================");

        }
    }
}
