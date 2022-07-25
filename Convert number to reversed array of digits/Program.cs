using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Convert_number_to_reversed_array_of_digits
{
    class Program
    {
        static int[] ReversedArray(int value)
        {
            string elements = value.ToString(); 

            int[] newArray = new int[elements.Length];

            for (int i = 0; i < newArray.Length; i++)
            {
                newArray[i] = value % 10;
                value = value / 10;
            }
            return newArray;

        }
        static void Main(string[] args)
        {
            int number = 348597;

            int[] myArray = ReversedArray(number);

            foreach (int i in myArray)
                Console.Write(i + ", ");


            Console.ReadLine();
        }
    }
}
