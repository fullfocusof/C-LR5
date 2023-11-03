using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace LR5
{
    internal class Program
    {
        static void GoToXY(int x, int y)
        {
            Console.SetCursorPosition(x,y);
        }

        static void PrintQuit()
        {
            Console.WriteLine("\n\nBackspace - возврат в меню");

            ConsoleKeyInfo answ = Console.ReadKey();
            bool pressed = false;

            while(!pressed)
            {
                if (answ.Key == ConsoleKey.Backspace)
                {
                    pressed = true;
                    break;
                }
                else
                {
                    answ = Console.ReadKey();
                }
            }

            Console.Clear();
        }





        static int DigitPermutation(int num)
        {
            int result = 0;
            string tempStr = num.ToString();
            int[] tempArr = new int[tempStr.Length];

            for (int i = 0; i < tempArr.Length; i++)
            {
                tempArr[i] = int.Parse(tempStr[i].ToString());
            }

            Array.Sort(tempArr, (x,y) => y.CompareTo(x));

            tempStr = string.Join("", tempArr);

            result = int.Parse(tempStr);

            return result;
        }






        struct LongPair
        {
            public long first { get; set; }
            public long second { get; set; }
        }

        static long DivisorSum(long number)
        {
            long sum = 0;

            for (long i = 1; i <= number / 2; i++)
            {
                if (number % i == 0)
                {
                    sum += i;
                }
            }

            return sum;
        }

        static List<LongPair> FriendlyNumbers(long limit)
        {
            List<LongPair> pairs = new List<LongPair>();

            for (long i = 1; i <= limit; i++)
            {
                long secondNum = DivisorSum(i);

                if(secondNum > i && secondNum <= limit)
                {
                    long reverseSecondNum = DivisorSum(secondNum);
                    if(reverseSecondNum == i)
                    {
                        pairs.Add(new LongPair { first = i, second = secondNum });
                    }
                }
            }

            return pairs;
        }






        static List<long> AutomorphicNumbers(long limit)
        {
            List<long> result = new List<long>();

            for (int i = 0; i <= limit; i++)
            {
                if(i % 10 == 1 || i % 10 == 5 || i % 10 == 6)
                {
                    long square = (long)Math.Pow(i, 2);
                    string numString = i.ToString();
                    string squareString = square.ToString();

                    if (squareString.Length >= numString.Length)
                    {
                        int startID = squareString.Length - numString.Length;

                        long endDigits = long.Parse(squareString.Substring(startID));
                       // squareString.EndsWith(numString);
                        if (endDigits == i)
                        {
                            result.Add(i);
                        }
                    }      
                }
            }

            return result;
        }




        static void ConsecutiveNumbers(long target, long numTemp, long sumTemp, string resultText) // ????????????????????
        {
            if (sumTemp < target)
            {
                if (resultText == "")
                {
                    resultText = Convert.ToString(numTemp);
                }
                else
                {
                    resultText += " + " + Convert.ToString(numTemp);
                }

                long next = numTemp + 1;
                ConsecutiveNumbers(target, next, sumTemp + numTemp, resultText);
            }

            if (sumTemp == target)
            {
                Console.WriteLine(resultText);
            }  
        }






        static bool IsPrime(long num)
        {
            if(num < 2)
            {
                return false;
            }

            for (long i = 2; i <= Math.Sqrt(num); i++)
            {
                if(num % i == 0)
                {
                    return false;
                }
            }

            return true;
        }

        static List<LongPair> GeminiNumbers(long limit) 
        {
            List<LongPair> result = new List<LongPair>();

            for(long i = limit; i <= 2*limit; i++)
            {
                if(IsPrime(i))
                {
                    long j = i + 2;
                    if(j <= 2*limit && IsPrime(j))
                    {
                        result.Add(new LongPair { first = i, second = j });
                    }
                }
            }

            return result;
        }





        static void LatinAlphabet(int cntInMid, string alphabet, int startID, bool reverse)
        {
            if (startID * 2 >= alphabet.Length - cntInMid)
            {
                reverse = true;
            }

            if (reverse && startID + 1 == 0)
            {
                return;
            }

            if (startID != 0)
            {
                for (int j = 0; j < startID; j++)
                {
                    Console.Write("  ");
                }
            }

            for (int i = startID; i < alphabet.Length - startID; i++)
            {
                Console.Write(alphabet[i] + " ");
            }

            Console.WriteLine();

            LatinAlphabet(cntInMid, alphabet, reverse ? startID - 1 : startID + 1, reverse);
        }





        static void Main(string[] args)
        {
            Console.CursorVisible = false;

            int active_menu = 0;
            bool exitProg = false;

            while (!exitProg)
            {
                Console.Clear();

                int x = 55, y = 12;
                GoToXY(x, y);

                string[] menu =
                {
                    "Перестановка цифр в числе",
                    "Поиск дружественных чисел",
                    "Поиск автоморфных чисел",
                    "Поиск подряд идущих натуральных чисел",
                    "Поиск чисел-близнецов",
                    "Вывод латинского алфавита",
                    "Выход"
                };

                for (int i = 0; i < menu.Length; i++)
                {
                    if (i == active_menu)
                    {
                        Console.WriteLine("<" + menu[i] + ">");
                    }
                    else
                    {
                        Console.WriteLine(menu[i]);
                    }

                    GoToXY(x, ++y);
                }

                ConsoleKeyInfo keyInfo = Console.ReadKey();
                switch(keyInfo.Key)
                {
                    case ConsoleKey.UpArrow:
                        {
                            if (active_menu > 0)
                            {
                                active_menu--;
                            }
                        }
                    break;

                    case ConsoleKey.DownArrow: 
                        {
                            if (active_menu < menu.Length - 1)
                            {
                                active_menu++;
                            }
                        }
                    break;

                    case ConsoleKey.Enter: 
                        { 
                            switch (active_menu) 
                            {
                                case 0:
                                    {
                                        Console.Clear();
                                        Console.WriteLine("Введите натуральное число");
                                        int num = int.Parse(Console.ReadLine());
                                        while(num < 1)
                                        {
                                            Console.Clear();
                                            Console.WriteLine("Неверные данные");
                                            Console.WriteLine("Введите натуральное число");
                                            num = int.Parse(Console.ReadLine());
                                        }

                                        Console.WriteLine("\nОтвет - " + DigitPermutation(num));

                                        PrintQuit();
                                    }
                                    break;

                                case 1:
                                    {
                                        Console.Clear();
                                        Console.WriteLine("Введите ограничивающее число");
                                        long num = long.Parse(Console.ReadLine());
                                        //while (num < 1)
                                        //{
                                        //    Console.Clear();
                                        //    Console.WriteLine("Неверные данные");
                                        //    Console.WriteLine("Введите ограничивающее число");
                                        //    num = int.Parse(Console.ReadLine());
                                        //}

                                        List<LongPair> result = FriendlyNumbers(num);

                                        Console.WriteLine("\nДружественные числа");
                                        foreach (LongPair el in result)
                                        {
                                            Console.WriteLine(el.first + "\t" + el.second);
                                        }

                                        PrintQuit();
                                    }
                                    break;

                                case 2:
                                    {
                                        Console.Clear();
                                        Console.WriteLine("Введите ограничивающее число");
                                        long num = long.Parse(Console.ReadLine());

                                        List<long> result = AutomorphicNumbers(num);

                                        Console.WriteLine("\nАвтоморфные числа");
                                        foreach (long el in result)
                                        {
                                            Console.WriteLine(el + " ");
                                        }

                                        PrintQuit();
                                    }
                                    break;

                                case 3:
                                    {
                                        Console.Clear();
                                        Console.WriteLine("Введите число");
                                        long num = long.Parse(Console.ReadLine());

                                        Console.WriteLine("\nОтвет:");
                                        for (int i = 1; i < num / 2 + 1; i++)
                                        {
                                            ConsecutiveNumbers(num, i, 0, "");                                    
                                        }

                                        PrintQuit();
                                    }
                                    break;

                                case 4:
                                    {
                                        Console.Clear();
                                        Console.WriteLine("Введите ограничивающее число");
                                        long num = long.Parse(Console.ReadLine());

                                        List<LongPair> result = GeminiNumbers(num);

                                        Console.WriteLine("\nЧисла-близнецы");
                                        foreach (LongPair el in result)
                                        {
                                            Console.WriteLine(el.first + "\t" + el.second);
                                        }

                                        PrintQuit();
                                    }
                                    break;

                                case 5:
                                    {
                                        string alph = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";

                                        Console.Clear();
                                        int cntInMid = new Random().Next(1,27);

                                        LatinAlphabet(cntInMid, alph, 0, false);

                                        PrintQuit();
                                    }
                                    break;

                                case 6:
                                    {
                                        exitProg = true;
                                    }
                                    break;
                            }

                        }
                    break;
                }

            }
        }
    }
}
