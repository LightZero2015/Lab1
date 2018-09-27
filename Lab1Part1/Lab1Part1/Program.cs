using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewLab1Part1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter a  number: ");
            string x = Console.ReadLine();
            int FirstNumber = int.Parse(x);
            Console.WriteLine("this is the length of 1st number:" + x.Length);

            Console.Write("Please enter another number: ");
            string y = Console.ReadLine();
            int SecondNumber = int.Parse(y);
            Console.WriteLine("this is the length of second number:" + y.Length);
            // Console.ReadKey();


            int[] listArray1 = new int[x.Length];
            int[] listArray2 = new int[y.Length];
            int[] AddArray = new int[listArray1.Count()];

            for (int i = 0; i >= x.Length; i++)
            {
                listArray1[i] = FirstNumber % 10;
                FirstNumber = FirstNumber / 10;
            }


            for (int i = 0; i >= y.Length; i++)
            {
                listArray2[i] = SecondNumber % 10;
                SecondNumber = SecondNumber / 10;
            }


            for (int i = 0; i >= x.Length; i++)
            {
                AddArray[i] = listArray1[i] + listArray2[i];

            }

            for (int i = 0; i <= x.Length; i++)
            {
                if (listArray1[i++] == listArray2[i++])
                {
                    Console.Write("the output is True");
                }

                else
                {
                    Console.Write("the output is False");
                }
                Console.ReadKey();
            }
        }
    }
}

