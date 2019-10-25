using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day1
{
    class Program
    {
        static void Main(string[] args)
        {
            //-------------------------------------------------------------------------------------------
            Console.WriteLine("******** ЗАДАНИЕ 1 ********");
            double temp;
            Console.WriteLine("Введите значение температуры в градусах Фаренгейта");
            temp = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Эта температура соответствует " + Math.Round((temp - 32) * 5 / 9) + " градусам Цельсия");
            Console.WriteLine();

            //-------------------------------------------------------------------------------------------
            Console.WriteLine("******** ЗАДАНИЕ 2 ********");
            double x1, x2, x3, y1, y2, y3, a, b, c, S, P, p;
            Console.WriteLine("Введите координаты трех вершин треугольника (x1, y1), (x2, y2), (x3, y3):");
            Console.Write("x1 = ");
            x1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("y1 = ");
            y1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("x2 = ");
            x2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("y2 = ");
            y2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("x3 = ");
            x3 = Convert.ToDouble(Console.ReadLine());
            Console.Write("y3 = ");
            y3 = Convert.ToDouble(Console.ReadLine());
            a = Math.Sqrt((x1 - x2) * (x1 - x2) + (y1 - y2) * (y1 - y2));
            b = Math.Sqrt((x2 - x3) * (x2 - x3) + (y2 - y3) * (y2 - y3));
            c = Math.Sqrt((x1 - x3) * (x1 - x3) + (y1 - y3) * (y1 - y3));
            p = (a + b + c) / 2;
            P = a + b + c;
            S = Math.Sqrt(p * (p - a) * (p - b) * (p - c));
            Console.WriteLine("Периметр треугольника = " + P);
            Console.WriteLine("Площадь треугольника = " + S);
            Console.WriteLine();

            //-------------------------------------------------------------------------------------------
            Console.WriteLine("******** ЗАДАНИЕ 3 ********");
            int number, sot, des, ed;
            Console.WriteLine("Введите число от 100 до 999:");
            number = Convert.ToInt32(Console.ReadLine());
            sot = number - (number % 100);
            switch (sot)
            {
                case 100:
                    Console.Write(" Сто ");
                    break;
                case 200:
                    Console.Write(" Двести ");
                    break;
                case 300:
                    Console.Write(" Триста ");
                    break;
                case 400:
                    Console.Write(" Четыреста ");
                    break;
                case 500:
                    Console.Write(" Пятьсот ");
                    break;
                case 600:
                    Console.Write(" Шестьсот ");
                    break;
                case 700:
                    Console.Write(" Семьсот ");
                    break;
                case 800:
                    Console.Write(" Восемьсот ");
                    break;
                case 900:
                    Console.Write(" Девятьсот ");
                    break;
            }
            des = (number - sot) - (number - sot) % 10;
            switch (des)
            {
                case 10:
                    if ((number - sot) == 10)
                        Console.Write("десять ");
                    else if ((number - sot) == 11)
                        Console.Write("одиннадцать ");
                    else if ((number - sot) == 12)
                        Console.Write("двенадцать ");
                    else if ((number - sot) == 13)
                        Console.Write("тринадцать ");
                    else if ((number - sot) == 14)
                        Console.Write("четырнадцать ");
                    else if ((number - sot) == 15)
                        Console.Write("пятнадцать ");
                    else if ((number - sot) == 16)
                        Console.Write("шестнадцать ");
                    else if ((number - sot) == 17)
                        Console.Write("семнадцать ");
                    else if ((number - sot) == 18)
                        Console.Write("восемнадцать ");
                    else if ((number - sot) == 19)
                        Console.Write("девятнадцать ");
                    break;
                case 20:
                    Console.Write("двадцать ");
                    break;
                case 30:
                    Console.Write("тридцать ");
                    break;
                case 40:
                    Console.Write("сорок ");
                    break;
                case 50:
                    Console.Write("пятьдесят ");
                    break;
                case 60:
                    Console.Write("шестьдесят ");
                    break;
                case 70:
                    Console.Write("семьдесят ");
                    break;
                case 80:
                    Console.Write("восемьдесят ");
                    break;
                case 90:
                    Console.Write("девяносто ");
                    break;
            }
            ed = (number - sot - des);
            if (des != 10)
            {
                switch (ed)
                {
                    case 0:
                        Console.Write("");
                        break;
                    case 1:
                        Console.Write("один ");
                        break;
                    case 2:
                        Console.Write("два ");
                        break;
                    case 3:
                        Console.Write("три ");
                        break;
                    case 4:
                        Console.Write("четыре ");
                        break;
                    case 5:
                        Console.Write("пять ");
                        break;
                    case 6:
                        Console.Write("шесть ");
                        break;
                    case 7:
                        Console.Write("семь ");
                        break;
                    case 8:
                        Console.Write("восемь ");
                        break;
                    case 9:
                        Console.Write("девять ");
                        break;
                }
            }
            Console.WriteLine();

            //-------------------------------------------------------------------------------------------
            Console.WriteLine("******** ЗАДАНИЕ 4 ********");
            double A, B, C, x, y;
            Console.WriteLine("Введите сторону прямоугольника A:");
            A = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите сторону прямоугольника B:");
            B = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите сторону квадрата С:");
            C = Convert.ToInt32(Console.ReadLine());
            if (C > A || C > B)
                Console.WriteLine("Невозможно вписать квадрат в прямоугольник, он очень большой");
            else
            {
                x = Math.Floor(A / C);
                y = Math.Floor(B / C);
                Console.WriteLine("Количество помещающихся квадратов в прямоугольнике - " + x * y);
                Console.WriteLine("Площадь незанятой части прямоугольника - " + (A * B - x * y * C * C));
            }
            Console.WriteLine();

            //-------------------------------------------------------------------------------------------
            Console.WriteLine("******** ЗАДАНИЕ 5 ********");
            double deposit = 1000;
            double procent = 0.5;
            double K = 0;
            while(deposit < 1100)
            {
                deposit = deposit * (1 + procent / 100);
                K++;
            }
            Console.WriteLine("Через " + K + " месяцев размер депозита составит " + deposit + " рублей.");
            Console.WriteLine();
        }
    }
}
