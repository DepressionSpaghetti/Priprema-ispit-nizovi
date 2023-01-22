using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Priprema_ispit_niz2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr1 = { 1, 2, 3, 4, 5, 6, 7 };
            int[] arr2 = { 3, 2, 8, 5, 5, 7 };
            int x, count = 0;
            if (arr1.Length < arr2.Length)
                x = arr1.Length;
            else
                x = arr2.Length;
            for (int i = 0; i < x; i++)
                if (arr1[i] == arr2[i])
                    count++;
            Console.WriteLine("Broj zajedničkih članova je {0}", count);

            Console.ReadKey();
        }
    }
}
