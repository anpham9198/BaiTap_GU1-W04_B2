using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTap_GU1_W04_B2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 3, 4, 5 };
            Console.Write("Input: ");
            string a = Console.ReadLine();

            while (!int.TryParse(a, out int b))
            {
                Console.Write("Input: ");
                a = Console.ReadLine();
            }

            bool isFound = false;

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == Int32.Parse(a))
                {
                    isFound = true;
                }
            if ( isFound)
                {
                    Console.WriteLine("found");
                }
                else
                {
                    Console.WriteLine("not found");
                }

            
                Console.ReadKey();
            }
        }
    }
}