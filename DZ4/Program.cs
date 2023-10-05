using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5
{
    internal class Program
    {
        public static int Numbers(int a, int b)
        {
            if (a > b) { return a; }
            else { return b; }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Упр 5.1\nНаписать метод, возвращающий наибольшее из двух чисел.");
            Console.WriteLine("Введите 2 числa через <Enter>");
            int A, B, Final;
            bool i = int.TryParse(Console.ReadLine(), out A);
            bool i0 = int.TryParse(Console.ReadLine(), out B);

            Final = Numbers(A, B);
            Console.WriteLine(Final);




            Console.WriteLine("Упр 5.2\nНаписать метод, который меняет местами значения двух передаваемых параметров.");
            Console.WriteLine("Значение первого числа = 3, значение второго числа = 4");
            Console.WriteLine("Нажмите <Enter> чтобы поменять значения местами");
            int C = 3;
            int D = 4;
            Value(ref C, ref D);



            Console.WriteLine("\nУпр 5.3\nНаписать метод вычисления факториала числа");
            Console.WriteLine("Введите число");
            int num;
            bool j = int.TryParse(Console.ReadLine(), out num);
            if (num >= 0)
            {
                bool flag = Factorial(ref num);
                Console.WriteLine(Convert.ToString(flag) + $"\nФакториал введённого числа равен {num}");
            }
            else { Console.WriteLine("Факториал отрицательного числа не существует"); }




            Console.WriteLine("Упр 5.4\nНаписать рекурсивный метод вычисления факториала числа");
            Console.WriteLine("Введите число");
            int number = int.Parse(Console.ReadLine());
            int fact = Factorial(number);
            Console.WriteLine($"Факториал введённого числа равен {fact}");


            Console.WriteLine("DZ_5.1\nЗаданние с НОДом для 2 чисел");
            Console.WriteLine("Введите два числа через <Enter>");
            int a1 = int.Parse(Console.ReadLine());
            int b1 = int.Parse(Console.ReadLine());
            NOD(ref a1, ref b1);

            Console.WriteLine("Дз 5.1\nЗаданние с НОДом для 3 чисел");
            Console.WriteLine("Введите три числа через <Enter>");
            int a2 = int.Parse(Console.ReadLine());
            int b2 = int.Parse(Console.ReadLine());
            int c2 = int.Parse(Console.ReadLine());
            NOD(ref a2, ref b2, ref c2);



            Console.WriteLine("Дз 5.2\nНаписать рекурсивный метод, вычисляющий значение n-го числа ряда Фибоначчи.");
            int n = int.Parse(Console.ReadLine());
            int fib = Fibonachi(n);
            Console.WriteLine(fib);
        }

        public static void NOD(ref int G, ref int D)
        {
            while (G != 0 && D != 0)
            {
                if (G > D)
                {
                    G = G % D;
                }
                else
                {
                    D = D % G;
                }
            }
            Console.WriteLine(D + G);
        }
        public static void NOD(ref int G, ref int D, ref int Q)
        {
            while (G != 0 && D != 0 && Q != 0)
            {
                if (G > D)
                {
                    G = G % D;
                }
                else
                {
                    D = D % G;
                }
                int R = G + D;
                if (R > Q)
                {
                    R = R % Q;
                }
                else
                {
                    Q = Q % R;
                }
                int nod = R + Q;
                Console.WriteLine(nod);
            }
        }

        public static void Value(ref int a, ref int b)
        {
            int temple = a;
            a = b;
            b = temple;
            Console.WriteLine($"Первое значение = {a}, второе значение = {temple}");
        }
        static bool Factorial(ref int num)
        {
            int result = num;
            num = 1;
            for (int i = 1; i <= result; i++)
                try
                {
                    checked
                    {
                        num *= i;
                    }
                }
                catch { return false; }
            return true;

        }

        static int Factorial(int a)
        {
            if (a == 0) return 1;
            return a * Factorial(a - 1);
        }

        static int Fibonachi(int n, int p1 = 0, int p2 = 1)
        {
            if (n <= 1) return p1;
            int p;
            for (int j = 2; j < n; j++)
            {
                p = p1;
                p1 = p2;
                p2 = p2 + p;
            }
            return p2;
        }
    }
}
