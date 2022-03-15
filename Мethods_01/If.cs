using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Мethods
{
    static class If
    {
        // Task 1
        // Пользователь вводит 2 числа (A и B). Если A>B, подсчитать A+B, если A=B, подсчитать A*B, если A<B, подсчитать A-B.
        public static int GetResault(int a, int b)
        {
            int result;
            if (a > b)
            {
                result = a + b;
            }
            else if (a == b)
            {
                result = a * b;
            }
            else
            {
                result = a - b;
            }
            return result;
        }
        // Task 2
        // Пользователь вводит 2 числа (X и Y). Определить какой четверти принадлежит точка с координатами (X,Y).
        public static int GetQuarterCoordinates(int x, int y)
        {
            if (x == 0 || y == 0)
            {
                throw new Exception("On line coordinate");
            }
            if (x > 0 && y > 0)
            {
                return 1;
            }
            else if (x < 0 && y > 0)
            {
                return 2;
            }
            else if (x < 0 && y < 0)
            {
                return 3;
            }
            else
            {
                return 4;
            }
        }
        // Task 3
        // Пользователь вводит 3 числа (A, B и С). Выведите их в консоль в порядке возрастания.
        public static int[] GetSort(int a, int b, int c)
        {
            if (a >= b && a >= c)
            {
                if (b >= c)
                {
                    int[] res = { c, b, a };
                    return (res);
                }
                else
                {
                    int[] res = { b, c, a };
                    return (res);
                }
            }
            else if (b >= a && b >= c)
            {
                if (a >= c)
                {
                    int[] res = { c, a, b };
                    return (res);
                }
                else
                {
                    int[] res = { a, c, b };
                    return (res);
                }
            }
            else
            {
                if (b >= a)
                {
                    int[] res = { a, b, c };
                    return (res);
                }
                else
                {
                    int[] res = { b, a, c };
                    return (res);
                }
            }
            
        }
        // Task 4
        // Пользователь вводит 3 числа (A, B и С). Выведите в консоль решение квадратного уравнения стандартного вида.
        public static (double,double) GetQuadraticEquation(int a, int b, int c)
        {
            if (a == 0 || b == 0)
            {
                throw new Exception("a! = 0, b! = 0");
            }
            double D = b * b - 4 * a * c;
            double x1, x2;
            x1 = -b + Math.Sqrt(D) / (2 * a);
            x2 = -b - Math.Sqrt(D) / (2 * a);
            return (x1, x2);
        }
        // Task 5
        // Пользователь вводит двузначное число. Выведите в консоль прописную запись этого числа.
        public static string GetConvertNumber(int a)
        {
            string str="";
            int fn;
            int sn;

            if (a >= 10 && a <= 19)
            {
                switch (a)
                {
                    case 10:
                        str = "Десять";
                        break;
                    case 11:
                        str = "Одинадцать";
                        break;
                    case 12:
                        str = "Двенадцать";
                        break;
                    case 13:
                        str = "Тринадцать";
                        break;
                    case 14:
                        str = "Четырнадцать";
                        break;
                    case 15:
                        str = "Пятнадцать";
                        break;
                    case 16:
                        str = "Шестнадцать";
                        break;
                    case 17:
                        str = "Семнадцать";
                        break;
                    case 18:
                        str = "Восемнадцать";
                        break;
                    case 19:
                        str = "Девятнадцать";
                        break;
                }
            }
            else
            {
                fn = a / 10;
                sn = a % 10;
                switch (fn)
                {
                    case 2:
                        str = "Двадцать";
                        break;
                    case 3:
                        str = "Тридцать";
                        break;
                    case 4:
                        str = "Сорок";
                        break;
                    case 5:
                        str = "Пятьдесят";
                        break;
                    case 6:
                        str = "Шестьдесят";
                        break;
                    case 7:
                        str = "Семьдесят";
                        break;
                    case 8:
                        str = "Восемьдесят";
                        break;
                    case 9:
                        str = "Девяносто";
                        break;
                }
                switch (sn)
                {
                    case 1:
                        str += " один";
                        break;
                    case 2:
                        str += " два";
                        break;
                    case 3:
                        str += " три";
                        break;
                    case 4:
                        str += " четыре";
                        break;
                    case 5:
                        str += " пять";
                        break;
                    case 6:
                        str += " шесть";
                        break;
                    case 7:
                        str += " семь";
                        break;
                    case 8:
                        str += " восемь";
                        break;
                    case 9:
                        str += " девять";
                        break;
                }

            }
            return (str);
        }
    }
}
