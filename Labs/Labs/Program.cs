using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labs
{
    class Program
    {
        static void Main(string[] args)
        {
          
                bool z, x;
                double x1, x2, y1 = 0, y2 = 0, y3 = 0, y4 = 0;
                Console.Title = "Шевчук Михаил ИУ5-31Б";
                double A, B, C;
                string str1, str2, str3;
                if (args != null && args.Length >= 1)
                {
                    str1 = args[0];
                    while (!(Double.TryParse(str1, out A)))
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Ошибка!!!");
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine("Введите А ещё раз: ");
                        str1 = Console.ReadLine();
                    }
                }
                else
                {
                    Console.WriteLine("Введите А ");
                    str1 = Console.ReadLine();
                    while (!(Double.TryParse(str1, out A)))
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Ошибка!!!");
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine("Введите А ещё раз: ");
                        str1 = Console.ReadLine();
                    }
                }
                if (args != null && args.Length >= 2)
                {
                    str2 = args[1];
                    while (!(Double.TryParse(str2, out B)))
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Ошибка!!!");
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine("Введите B ещё раз: ");
                        str2 = Console.ReadLine();
                    }
                }
                else
                {
                    Console.WriteLine("Введите B ");
                    str2 = Console.ReadLine();
                    while (!(Double.TryParse(str2, out B)))
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Ошибка!!!");
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine("Введите B ещё раз: ");
                        str2 = Console.ReadLine();
                    }
                }
                if (args != null && args.Length >= 3)
                {
                    str3 = args[2];
                    while (!(Double.TryParse(str3, out C)))
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Ошибка!!!");
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine("Введите C ещё раз: ");
                        str3 = Console.ReadLine();
                    }
                }
                else
                {
                    Console.WriteLine("Введите C ");
                    str3 = Console.ReadLine();
                    while (!(Double.TryParse(str3, out C)))
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Ошибка!!!");
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine("Введите C ещё раз: ");
                        str3 = Console.ReadLine();
                    }
                }
                if (A == 0 && B == 0 && C == 0)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Корень любой");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("Конец программы :(");
                    return;
                }
                if (A == 0 && B != 0)
                {
                    double t;
                    t = -1 * C / B;
                    if (t >= 0)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        y1 = Math.Abs(Math.Sqrt(t));
                        y2 = -1 * Math.Abs(Math.Sqrt(t));
                        Console.WriteLine($"Корни уравнения:\n{y1}\n{y2} ");

                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Корней нет :(");


                    }
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("Конец программы :(");
                    return;
                }
                if (A != 0 && B == 0)
                {
                    double t, t1;
                    t = -1 * C / A;
                    if (t >= 0)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        t1 = Math.Abs(Math.Sqrt(t));
                        y1 = Math.Abs(Math.Sqrt(t1));
                        y2 = -1 * Math.Abs(Math.Sqrt(t1));
                        Console.WriteLine($"Корни уравнения:\n{y1}\n{y2} ");

                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Корней нет :(");
                    }
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("Конец программы :(");
                    return;
                }
                if (A == 0 && B == 0 && C != 0)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Решений нет");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("Конец программы :(");
                    return;
                }
                double D;
                D = Math.Pow(B, 2) - 4 * A * C;
                if (D < 0)
                {
                    z = x = false;
                }
                else
                {


                    x1 = (-1 * B + Math.Abs(Math.Sqrt(D))) / (2 * A);
                    if (x1 >= 0)
                    {
                        y1 = Math.Abs(Math.Sqrt(x1));
                        y2 = -1 * Math.Abs(Math.Sqrt(x1));
                        z = true;
                    }
                    else
                        z = false;
                    x2 = (-1 * B - Math.Abs(Math.Sqrt(D))) / (2 * A);
                    if (x2 >= 0)
                    {
                        y3 = Math.Abs(Math.Sqrt(x2));
                        y4 = -1 * Math.Abs(Math.Sqrt(x2));
                        x = true;
                    }
                    else
                        x = false;
                }
                if (z || x)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Корни уравнения: ");
                    if (z)
                        Console.WriteLine($"{y1} \n{y2} ");
                    if (x)
                        Console.WriteLine($"{y3} \n{y4} ");
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Корней нет :(");
                }

                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Конец программы :(");
                Console.ReadKey();
            }
            static bool Proverka(string str)
            {
                int i = 0;
                int a = 0;
                for (i = 0; i < str.Length; ++i)
                {
                    if ((i == 0) && ((str[i] < '0') || (str[i] > '9')) && (str[i] != '-'))
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Ошибка!!!");
                        return false;
                    }
                    if (((str[i] < '0') || (str[i] > '9')) && (int)str[i] != 44 && (str[i] != '-') || ((str[i] == '-') && (i > 0)))
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Ошибка!!!");
                        return false;
                    }
                    if (str[i] == ',')
                    {
                        ++a;
                    }
                }
                if (a > 1)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Ошибка!!!");
                    return false;
                }
                return true;
            }
        }
    }

