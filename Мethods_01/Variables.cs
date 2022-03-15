using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Мethods
{
    static class Variables
    {
        // Task 1
        // Пользователь вводит 2 числа (A и B). Выведите в консоль результат деления A на B и остаток от деления.

        public static void GetResultOfDevision(double a, double b, out double res1, out double res2)
        {
            if (b == 0)
            {
                throw new Exception("b!=0");
            }
            res1 = a / b;
            res2 = a % b;
        }

        // Task 2
        // Пользователь вводит 2 числа (A и B). Выведите в консоль решение
        public static double WriteAnswExpression(double a, double b)
        {
            if (a == b)
            {
                throw new Exception("Devision by null");
            }
            double result = ((5 * a) + (b * b)) / (b - a);
            return(result);
        }


        // Task 3
        // Пользователь вводит 2 строковых(string) значения(A и B). Поменяйте содержимое переменных A и B местами.
        public static void GetReverse(ref string a, ref string b)
        {
            string tmp = a;
            a = b;
            b = tmp;
        }

        // Task 4
        // Пользователь вводит 3 не равных 0 числа (A, B и С). Выведите в консоль решение(значение X) линейного уравнения стандартного вида, где A*X+B=C
        public static double GetValueSolution(double a, double b, double c)
        {
            double x = 0;
            if (a == 0)
            {
                throw new Exception("Devision by null");
            }
            x = (c - b) / a;
            
            return x;
        }

        //Task 5
        // Выведите уравнение прямой в формате Y=AX+B, проходящей через эти точки
        public static string GetEquationLine(int x1, int y1, int x2, int y2)
        {
            if (x2 == x1)
            {
                throw new Exception("Devision by null");
            }

            double a = (y2 - y1) / (x2 - x1);
            double b = y1 - (a * x1);
            return("Y = " + a + " X + " + b);
        }
    }
}
