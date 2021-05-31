using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Деклариране на списък
            List<string> list = new List<string>();
            //Деклариране на масив
            int[] arr = new int[10];

            list.Add("name1");
            list.Add("name1");
            list.Add("name1");
            list.Add("name1");
            list.Add("name1");
            list.Add("name1");
            list.Add("name1");
            list.Add("name1");
            list.Add("name1");
            Console.WriteLine($"Capacity: {list.Capacity}" );
            Console.WriteLine($"Count: {list.Count}");

            //Деклариране на списък
            List<string> list1 = new List<string>(10000);
            list1.Add("1111");
            Console.WriteLine($"Capacity1: {list1.Capacity}");
            Console.WriteLine($"Count1: {list1.Count}");

        }
    }
}
