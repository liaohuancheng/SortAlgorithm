using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = new int[] { 12, 41, 34, 122, 441, 551, 56, 90 };
            Sort s = new Sort();
            //s.BubbleSort(a);
            s.QuickSort(a);
            foreach(int i in a)
            {
                Console.Write("{0}" + " ", i);
            }
            Console.Read();
        }
    }
}
