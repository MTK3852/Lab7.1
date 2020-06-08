using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab7._1
{
    public class Computer : IComparable
    {
        public string name;
        public string model;
        public string color;
        public int price;
        public int space;

        public string getName() { return name; }
        public string getModel() { return model; }

        public Computer(string name, string model, string color, int price, int space)
        {
            this.name = name;
            this.model = model;
            this.color = color;
            this.price = price;
            this.space = space;
        }
        public int CompareTo(object obj)
        {
            Computer comp = (Computer)obj;
            if (this.price > comp.price) return 1;
            if (this.price < comp.price) return -1;
            return 0;
        }

        public void showInfo()
        {
            Console.WriteLine("Model = {0} Space = {1} Price = {2}", model, space, price);
        }
        public class SortByPrice : IComparer
        {
            public int Compare(object c1, object c2)
            {
                Computer comp1 = (Computer)c1;
                Computer comp2 = (Computer)c2;
                if (comp1.price > comp2.price) return 1;
                if (comp1.price < comp2.price) return -1;
                return 0;
            }
        }
        public class SortBySpace : IComparer
        {
            public int Compare(object c1, object c2)
            {
                Computer comp1 = (Computer)c1;
                Computer comp2 = (Computer)c2;
                if (comp1.space > comp2.space) return 1;
                if (comp1.space < comp2.space) return -1;
                return 0;
            }
        }
    }
}
