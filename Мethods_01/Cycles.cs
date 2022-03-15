using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Мethods
{
    static class Cycles
    {
        // Task 1
        // Пользователь вводит 2 числа (A и B). Возвести число A в степень B.

        public static int RaiseToAPower(int a, int b)
        {
            int tmp = 1;

            for (int i = 0; i < b; i++)
            {
                tmp *= a;

            }
            return tmp;
        }

        // Task 2
        // Пользователь вводит 1 число (A). Вывести все числа от 1 до 1000, которые делятся на A.

        public static int[] GetNumbersDevivisible(int a)
        {
            int count = 0;

            for (int i = a; i <= 1000; i += a)
            {
                count++;
            }
            int[] res = new int[count];
            int j = 0;

            for (int i = a; i <= 1000; i += a)
            {
                res[j] = i;
                j++;
            }
            return res;
        }

        // Task 3
        // Пользователь вводит 1 число (A). Найдите количество положительных целых чисел, квадрат которых меньше A.

        public static int CountPositivePov(int a)
        {
            int i;

            for (i = 1; i * i < a; i++) ;
            return (i - 1);
        }
        // Task 4
        // Пользователь вводит 1 число (A). Вывести наибольший делитель (кроме самого A) числа A.

        public static int GetGCDOfOneNumbers(int a)
        {
            int maxDivider = a - 1;
            while (a % maxDivider != 0)
            {
                maxDivider -= 1;
            }
            return maxDivider;
        }

        // Task 5
        // Пользователь вводит 2 числа(A и B). Вывести сумму всех чисел из диапазона от A до B,
        // которые делятся без остатка на 7. (Учтите, что при вводе B может оказаться меньше A).

        public static int GetSumOfModSeven(int a, int b)
        {
            int tmp;
            int sum = 0;

            if (b < a)
            {
                tmp = b;
                b = a;
                a = tmp;
            }
            for (int i = a; i <= b; i++)
            {
                if (i % 7 == 0)
                {
                    sum += i;
                }
            }
            return sum;
        }

        // Task 6
        // Пользователь вводит 1 положительное число (N). Выведите N-ое число ряда фибоначчи.
        // В ряду фибоначчи каждое следующее число является суммой двух предыдущих. Первое и второе считаются равными 1.

        public static int GetFibNumber(int n)
        {
            int fn = 1;
            int sn = 1;
            int tmp;

            for (int i = 0; i < n - 2; i++)
            {
                tmp = fn + sn;
                fn = sn;
                sn = tmp;
            }
            return sn;
        }

        // Task 7
        // Пользователь вводит 2 числа. Найти их наибольший общий делитель используя алгоритм Евклида.

        public static int GetGCD(int a, int b)
        {
            if (a == 0 || b == 0)
            {
                throw new Exception("a or b = 0");
            }
            while (a != b)
            {
                if (a > b)
                {
                    a -= b;
                }
                else
                {
                    b -= a;
                }
            }
            return a;  
        }

        // Task 8
        // Пользователь вводит целое положительное число, которое является кубом целого числа N.
        // Найдите число N методом половинного деления.

        public static int FindNumberByHalfDivision(int n)
        {
            int l = 0;
            int r = n;
            int tmp = 0;

            while (l * l * l != n && r * r * r != n)
            {
                tmp = (l + r) / 2;
                if (tmp * tmp * tmp > n)
                {
                    r = tmp;
                }
                else
                {
                    l = tmp;
                }
            }
            return tmp;
        }

        // Task 9
        // Пользователь вводит 1 число. Найти количество нечетных цифр этого числа.

        public static int FindNumberOfOddNumbers(int a)
        {
            int tmp = 0;
            int count = 0;

            while (a != 0)
            {
                tmp = a % 10;
                if (tmp % 2 > 0)
                {
                    count++;
                }
                a /= 10;

            }
            return count;
        }

        // Task 10
        // Пользователь вводит 1 число. Найти число, которое является зеркальным отображением
        // последовательности цифр заданного числа, например, задано число 123, вывести 321.

        public static int FindMirrorSeqOfNember(int a)
        {
            int tmp = 0;
            int b = 0;

            while (a != 0)
            {
                tmp = a % 10;
                b = b * 10 + tmp;
                a /= 10;
            }
            return b;
        }

        // Task 11
        // Пользователь вводит целое положительное  число (N).
        // Выведите числа в диапазоне от 1 до N, сумма четных цифр которых больше суммы нечетных. 

        public static int GetCountEvenForArray(int n)
        {
            int count = 0;
            for (int i = 1; i <= n; i++)
            {
                int tmp = i;
                int sumeven = 0;
                int sumodd = 0;
                while (tmp != 0)
                {
                    int a = tmp % 10;
                    if (a % 2 == 0)
                    {
                        sumeven += a;
                    }
                    else
                    {
                        sumodd += a;
                    }
                    tmp /= 10;
                }
                if (sumeven > sumodd)
                {
                    count++;
                }
            }
            return count;
        }
        public static int[] GetEvenSumNumbers(int n)
        {
            int[] arr = new int[GetCountEvenForArray(n)];
            int j = 0;
            for (int i = 1; i <= n; i++)
            {
                int tmp = i;
                int sumeven = 0;
                int sumodd = 0;
                while (tmp != 0)
                {
                    int a = tmp % 10;
                    if (a % 2 == 0)
                    {
                        sumeven += a;
                    }
                    else
                    {
                        sumodd += a;
                    }
                    tmp /= 10;
                }
                if (sumeven > sumodd)
                {
                    arr[j] = i;
                    j++;
                }
            }
            return arr;
        }

        // Task 12
        // Пользователь вводит 2 числа. Сообщите, есть ли в написании двух чисел одинаковые цифры.
        // Например, для пары 123 и 3456789, ответом будет являться “ДА”, а, для пары 500 и 99 - “НЕТ”.

        public static bool IsEquallyFigure(int a, int b)
        {
            bool res = false;
            while (a != 0)
            {
                int figureA = a % 10;
                int tmpB = b;
                while (tmpB != 0)
                {
                    int figureB = tmpB % 10;
                    if (figureA == figureB)
                    {
                        res = true;
                        break;
                    }
                    tmpB /= 10;
                }
                a /= 10;
            }
            return res;
        }
    }
}
