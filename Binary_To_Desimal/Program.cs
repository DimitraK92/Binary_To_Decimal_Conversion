using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Binary_To_Desimal
{
    class Program
    {
        static void Main(string[] args)
        {
            int decimalNumber = ConvertBinaryToDecimal(new List<int>() { 0, 0, 0, 1, 0, 0, 0, 0 });

            Console.WriteLine(decimalNumber);
            Console.ReadKey();
        }

        static int ConvertBinaryToDecimal(List<int> binaryFormat)
        {
            binaryFormat.Reverse();          

            for (int i = 0; i < binaryFormat.Count; i++)
            {
                binaryFormat[i] *= (int) Math.Pow(2, i);               
            }

            int decimalFormat = binaryFormat.Sum();
        
            return decimalFormat;

        }




    }
}
