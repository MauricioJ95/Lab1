using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Put in a 3 digit integer");
            string int1 =
                Console.ReadLine();
            while (!IsThreeDigitiInt(int1))
            {
                Console.WriteLine("Please input a 3 digit integer");
                int1 =
                    Console.ReadLine();
            }

            Console.WriteLine("Put in second 3 digit integer");
            string int2 =
                Console.ReadLine();
            while (!IsThreeDigitiInt(int2))
            {
                Console.WriteLine("Please input a 3 digit integer");
                int2 =
                    Console.ReadLine();
            }

            string output;
            if (int1[0] + int2[0] == int1[1] + int2[1] && int1[1] + int2[1] == int1[2] + int2[2])
            {
                output = "True";
            }
            else
            {
                output = "False";
            }
            Console.WriteLine(output);
            Console.ReadLine();
        }
        private static bool IsThreeDigitiInt(string input)
        {
            int result;
            return int.TryParse(input, out result) && input.Length == 3;

        }

    }
}
