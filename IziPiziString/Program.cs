using System;
using System.Linq;

namespace IziPiziString
{
    class Program
    {
        public static int Sum(string input)
        {
            int sum = 0;
            char[] temp = input.ToCharArray();
            string[] temp2 = new string[temp.Length];

            for (int i = 0; i < temp.Length; i++)
            {
                temp2[i] = Convert.ToString(temp[i]);
                sum += Convert.ToInt32(temp2[i]);
            }

            return sum;

        }

        public static int Sum2Linq(string input)
        {
            int sum = 0;
            int[] x = input.Select(number => number - '0').ToArray();
            foreach (var item in x)
            {
                sum += item;
            }
            return sum;
        }



        static void Main(string[] args)
        {
            string x = "155";
            int y = Sum(x);
            Console.WriteLine(y);
            int z = Sum2Linq(x);
            Console.WriteLine(z);
           

        }
    }
}
