using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            // List<int> integers = new List<int>() { 10, -5, 12, 100, 0, 7 };
            /*ArrayList integers = new ArrayList() { 10, -5, 12, 100, 0, 7 };
            // MySort.IntSortAsc(integers);

            // MySort.UniversalSort(integers, new MySort.MyComparator(Program.IntSortAsc));
            // integers.ForEach(Console.WriteLine);
            MySort.UniversalSort(integers, (o1, o2) => (int)o2 - (int)o1);
            foreach (var item in integers)
            {
                Console.WriteLine(item);
            }*/
            ArrayList goods = new ArrayList() {
                new Good(){ Id = 1, Title = "fgdgf", Price = 10.99m },
                new Good(){ Id = 3, Title = "uyrty", Price = 99.99m },
                new Good(){ Id = 2, Title = "dsfg", Price = 100.05m },
                new Good(){ Id = 4, Title = "abc", Price = 99.99m }
            };
            //MySort.UniversalSort(goods, (o1, o2) => (((Good)o1).Price).CompareTo(((Good)o2).Price));



            MySort.UniversalSortTwoArgs(goods,
                (o1, o2) => (((Good)o1).Price.CompareTo(((Good)o2).Price)),
                (o1, o2) => (((Good)o1).Title.CompareTo(((Good)o2).Title))
                );
            foreach (var item in goods)
            {
                Console.WriteLine(item);
            }
            // List<string> vs = new List<string>() { "Hello", "World", "!", "..." };
        }

        /* static int IntSortAsc(object o1, object o2) {
            return (int)o1 - (int)o2;
        } */
    }
}
