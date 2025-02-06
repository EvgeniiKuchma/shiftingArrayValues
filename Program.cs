using System;

namespace shiftingArrayValues
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int temp = 0;
            int[] numberes = { 1, 2, 3, 4, 5, 6, 7 };

            Console.Write("Enter nuber shifting: ");
            int userInput = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < numberes.Length; i++)
            {
                Console.Write(numberes[i] + " ");
            }

            Console.WriteLine("----------------------------------");

            for (int i = 0; i < (userInput % numberes.Length) ; i++)
            {
                temp = numberes[0];

                for (int j = 0; j < numberes.Length - 1; j++)
                {
                    numberes[j] = numberes[j + 1];
                }

                numberes[numberes.Length - 1] = temp;
            }

            for (int i = 0; i < numberes.Length; i++)
            {
                Console.Write(numberes[i] + " ");
            }
        }
    }
}
