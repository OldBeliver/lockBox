using System;

namespace lockBox
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] numbersKit = CreateNumberKit();
            string[] lockCode = CreateLockCode(numbersKit);

            for (int i = 0; i < lockCode.Length; i++)
            {
                Console.Write($"{lockCode[i]}");
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

        static string[] CreateLockCode(string[] kit)
        {
            int size = 4;

            Random random = new Random();

            string[] lockCode = new string[size];
            string code = "";

            for (int i = 0; i < lockCode.Length; i++)
            {
                bool isTwin = true;

                while (isTwin)
                {
                    int index = random.Next(kit.Length);

                    if (code.Contains(kit[index]) == false)
                    {
                        code += kit[index];
                        isTwin = false;
                    }
                }

                lockCode[i] = code[i].ToString();
            }

            return lockCode;
        }

        static ConsoleColor[] CreateColorSet()
        {
            const int size = 6;

            ConsoleColor[] colors = new ConsoleColor[size]
            {
                ConsoleColor.DarkYellow,
                ConsoleColor.DarkGreen,
                ConsoleColor.DarkRed,
                ConsoleColor.DarkBlue,
                ConsoleColor.DarkMagenta,
                ConsoleColor.White
            };

            return colors;
        }
    }
}