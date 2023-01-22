using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Priprema_ispit_niz1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr1 = new int[10];
            int[] arr2 = new int[10];
            int x, n1 = 0, n2 = 0;
            do
            {
                Console.WriteLine("Upišite broj:");
                x = Convert.ToInt32(Console.ReadLine());
                if (x % 2 != 0)
                    arr1[n1++] = x;
                else
                    arr2[n2++] = x;
            } while (x != 0 && n1 < 10 && n2 < 10);
            Console.WriteLine();
            for (int i = 0; i < n1; i++)
                Console.WriteLine(arr1[i]);
            Console.WriteLine();
            for (int i = 0; i < n2; i++)
                Console.WriteLine(arr2[i]);

            Console.ReadKey();
        }
    }
}
