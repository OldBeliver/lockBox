using System;

namespace lockBox
{
    class Program
    {
        static void Main(string[] args)
        {
            const string NewGameCommand = "1";
            const string RulesOfGameCommand = "2";
            const string ExitCommand = "3";

            Random random = new Random();
            int lowerRange = 1;
            int upperRange = 9;

            string lockBox = "";
            string userInput = "";
            int size = 4;
            int counter = 0;
            bool isPlaying = true;

            while (isPlaying)
            {
                Console.Clear();
                Console.WriteLine($"игра Взлом пароля");
                Console.WriteLine($"------++++-------");
                Console.WriteLine($"{NewGameCommand}. Новая игра");
                Console.WriteLine($"{RulesOfGameCommand}. Правила игры");
                Console.WriteLine($"{ExitCommand}. Выход");

                switch (Console.ReadLine())
                {
                    case NewGameCommand:
                        Console.Clear();

                        for (int i = 0; i < size; i++)
                        {
                            string nextNumber = "";

                            while (lockBox.Contains(nextNumber))
                            {
                                nextNumber = Convert.ToString(random.Next(lowerRange, upperRange + 1));
                            }

                            lockBox += nextNumber;
                        }

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
                        break;

                    case RulesOfGameCommand:
                        Console.Clear();
                        Console.WriteLine($"двух одинаковых цифр нет,");
                        Console.WriteLine($"+ цифра на своем месте,");
                        Console.WriteLine($"- цифра не на своем месте.");
                        Console.WriteLine($"если цифры нет ничего не ставится");
                        Console.WriteLine($"--------------------------");                        
                        break;

                    case ExitCommand:
                        isPlaying = false;
                        break;

                    default:
                        Console.WriteLine($"Ошибка ввода команды");
                        break;
                }

                Console.ReadKey();
            }
        }
    }
}