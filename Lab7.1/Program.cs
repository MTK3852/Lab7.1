using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab7._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.InputEncoding = Encoding.GetEncoding(1251);

            Computers computers = new Computers();
            computers.Add(new Computer("Asus", "ROG213", "black", 2145, 256));
            computers.Add(new Computer("Lenovo", "G550", "black", 4125, 512));
            computers.Add(new Computer("Aser", "ML-234", "silver", 4214, 512));
            computers.Add(new Computer("Asus", "Strigx", "yellow", 14216, 512));
            computers.Add(new Computer("Apple", "MacbookAir2", "white", 14895, 512));
            computers.Add(new Computer("Sony", "Vaio", "grey", 5125, 256));
            computers.Add(new Computer("Lenovo", "Ty-412", "black", 7235, 256));
            computers.Add(new Computer("Acer", "Po-2415", "green", 6526, 512));
            computers.Add(new Computer("Xiaomi", "Gaming Laptop1", "black", 8532, 256));
            computers.Add(new Computer("Samsung", "Jod-f131", "white", 12455, 512));

            ArrayList arrayList = new ArrayList();
            foreach (Computer c in computers)
                arrayList.Add(c);

            Console.WriteLine("Sort by price(ICompareble):");
            arrayList.Sort();
            foreach (Computer a in arrayList)
                a.showInfo();

            Console.WriteLine("Sort by price(IComparer):");
            arrayList.Sort(new Computer.SortByPrice());
            foreach (Computer a in arrayList)
                a.showInfo();

            Console.WriteLine("Sort by HDD-memory:");
            arrayList.Sort(new Computer.SortBySpace());
            foreach (Computer a in arrayList)
                a.showInfo();

            Console.ReadLine();

        }
    }
}
