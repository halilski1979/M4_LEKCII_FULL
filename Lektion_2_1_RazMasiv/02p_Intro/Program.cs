using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02p_Intro
{
    class Program
    {
        static void Main(string[] args)
        {
            //Разтеглив масив по видеолекции

            MyList<int> listInt = new MyList<int>();
            MyList<string> listString = new MyList<string>();

            listString.Add("Halil1");
            listString.Add("Halil2");
            listString.Add("Halil3");
            listString.Add("Halil4");
            listString.Add("Halil5");

            for (int i = 0; i < listString.Count; i++)
            {
                Console.WriteLine(listString[i]);
            }
            Console.WriteLine(listString.Count);
            //Console.WriteLine(listString[1]);
            Console.WriteLine(listString.Capacity());
            Console.WriteLine("==================");
            Console.WriteLine(listString[2]);

        }
    }
}
