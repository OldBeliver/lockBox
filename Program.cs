using System;
using System.Linq;

namespace lockBox
{
    class Program
    {
        static void Main(string[] args)
        {
            const string EasyGameCommand = "1";
            const string HardGameCommand = "2";
            const string RulesOfGameCommand = "3";
            const string ExitCommand = "4";

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
                Console.WriteLine($"{EasyGameCommand}. Простая игра");
                Console.WriteLine($"{HardGameCommand}. Сложная игра");
                Console.WriteLine($"{RulesOfGameCommand}. Правила игры");
                Console.WriteLine($"{ExitCommand}. Выход");

                switch (Console.ReadLine())
                {
                    case EasyGameCommand:
                        Console.Clear();

                        lockBox = "";
                        counter = 0;

                        for (int i = 0; i < size; i++)
                        {
                            string nextNumber = "";

                            while (lockBox.Contains(nextNumber))
                            {
                                nextNumber = Convert.ToString(random.Next(lowerRange, upperRange + 1));
                            }

                            lockBox += nextNumber;
                        }

                        Console.WriteLine($"Простой уровень");
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
                                if (lockBox.Contains(userInput[i]) == false)
                                {                                    
                                    Console.Write($" ");
                                }
                                else
                                {
                                    if (lockBox[i] == userInput[i])
                                    {
                                        Console.Write($"+");
                                    }
                                    else
                                    {
                                        Console.Write($"-");
                                    }
                                }
                            }

                            counter++;
                            Console.WriteLine();
                        }

                        Console.WriteLine($"Код взломан: {lockBox}");
                        Console.WriteLine($"за {counter} попыток");
                        break;

                    case HardGameCommand:
                        Console.Clear();

                        lockBox = "";
                        counter = 0;

                        for (int i = 0; i < size; i++)
                        {
                            string nextNumber = "";

                            while (lockBox.Contains(nextNumber))
                            {
                                nextNumber = Convert.ToString(random.Next(lowerRange, upperRange + 1));
                            }

                            lockBox += nextNumber;
                        }

                        Console.WriteLine($"Сложный уровень");
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