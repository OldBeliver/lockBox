using System;

namespace lockBox
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int lowerRange = 1;
            int upperRange = 9;

            string lockBox = "";
            int size = 4;

            for (int i = 0; i < size; i++)
            {
                string nextNumber = "";

                while (lockBox.Contains(nextNumber))
                {
                    nextNumber = Convert.ToString(random.Next(lowerRange, upperRange + 1));
                }

                lockBox += nextNumber;
            }

            string userInput = "";

            Console.WriteLine($"двух одинаковых цифр нет,");
            Console.WriteLine($"+ цифра на своем месте,");
            Console.WriteLine($"- цифра не на своем месте.");
            Console.WriteLine($"--------------------------");
            Console.WriteLine($"Подберите {size}х значный цифровой код:");
            
            while (lockBox != userInput)
            {
                userInput = "";

                while (userInput.Length != 4)
                {
                    userInput = Console.ReadLine();

                    if (userInput.Length != 4)
                        Console.WriteLine($"введите 4 цифры");
                }

                for (int i = 0; i < size; i++)
                {
                    for (int j = 0; j < size; j++)
                    {
                        if (lockBox[i] == userInput[j] && i == j)
                        {
                            Console.Write($"+");
                        }
                        else if (lockBox[i] == userInput[j])
                        {
                            Console.Write($"-");
                        }
                    }
                }

                Console.WriteLine();
            }

            Console.WriteLine($"Код взломан: {lockBox}");
            Console.ReadKey();
        }
    }
}