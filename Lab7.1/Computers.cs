using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab7._1
{
    class Computers : IEnumerable
    {
        private Computer[] computers;
        private int n;

        public Computers()
        {
            computers = new Computer[10];
            n = 0;
        }
        public IEnumerator GetEnumerator()
        {
            for (int i = 0; i < n; ++i)
                yield return computers[i];
        }

        public void Add(Computer computer)
        {
            if (n >= 10) return;
            computers[n] = computer;
            ++n;
        }
    }
}
