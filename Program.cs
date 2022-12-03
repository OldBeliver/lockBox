using System;

namespace lockBox
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] numbersKit = CreateNumberKit();

            for (int i = 0; i < numbersKit.Length; i++)
            {
                Console.Write($"{numbersKit[i]} ");
            }
        }

        static string[] CreateNumberKit()
        {
            int size = 9;
            string[] numbers = new string[size];

            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = $"{i + 1}";
            }

            return numbers;
        }

        static void CreateColorSet()
        {

        }
    }
}