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
            string userInput = "";
            int size = 4;
            int counter = 0;

            for (int i = 0; i < size; i++)
            {
                string nextNumber = "";

                while (lockBox.Contains(nextNumber))
                {
                    nextNumber = Convert.ToString(random.Next(lowerRange, upperRange + 1));
                }

                lockBox += nextNumber;
            }          

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
                        if (lockBox[i] == userInput[j])
                        {
                            if (i == j)
                            {
                                Console.Write($"+");
                            }
                            else
                            {
                                Console.Write($"-");
                            }
                        }
                    }
                }

                counter++;
                Console.WriteLine();
            }

            Console.WriteLine($"Код взломан: {lockBox}");
            Console.WriteLine($"за {counter} попыток");
            Console.ReadKey();
        }
    }
}