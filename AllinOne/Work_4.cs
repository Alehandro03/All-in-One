using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllinOne
{
    
    public class Work_4
    {
        

        public static int[] GetNumbersDividedGivenNumber(int a)
        {
            // Пользователь вводит одно число (A).
            // Вывести все числа от 1 до 1000, которые делятся на A.
            int[] mas = IOHelper.GenerateArrayInt(a, 1, 100);
            int b = 0; 
            if (a == 0) throw new ArgumentException("Число равно нулю!");
            for (int i = a; i <= 1000; i++)
            {
                if (i % a == 0)
                {
                    mas[b] = i;
                    b++;
                }
                    
            }
            return  mas;
            
        }     

        public static int ReturnsNumberPositiveIntegers (int a)
        {
            //Задание 2 
            //Пользователь вводит одно число (A).
            //Найдите количество положительных целых чисел, квадрат которых меньше A.
            if (a == 0) throw new ArgumentException("Число равно нулю!");
            int sum = 0;
            int num = 0;
            for (int i = 1; Math.Pow(i, 2) < a; i++)
            {
                num++;
                sum = num;
            }
            return(sum);
        }

       public static int GetMaxDivisor (int a)
       {
            //Пользователь вводит одно число (A).
            //Вывести наибольший делитель (кроме самого A) числа A.
            if (a == 0) throw new ArgumentException("Число равно нулю!");
            for (int i = 2; i < a; i++)
            {
                if (a % i == 0)
                {
                    int b = a / i;
                    if (b != a) return b;
              
                }
                
                
            }
            return 0;

        }


        public static int GetSumNumberRange (int a, int b)
        {
            //Пользователь вводит два числа (A и B).
            //Вывести сумму всех чисел из диапазона от A до B, которые делятся без остатка на 7.
            //(Учтите, что при вводе B может оказаться меньше A).
            if (a == 0 && b == 0) throw new ArgumentException("Числа равны нулю!");
            if (a > b)
            {
                int tmp = a;
                a = b;
                b = tmp;
            }

            int c = 0;
            for (int i = a; i <= b; i++)
            {
                if (i % 7 == 0) c = i + c;
            }
            return c;
        }

        public static string FindCommonMaxFactorUseEuclid( int a, int b )
        {
            //Пользователь вводит два числа.
            //Найти их наибольший общий делитель используя алгоритм Евклида.
            if(a==0 && b==0 ) throw new ArgumentException("Числа равны нулю!");
            while (a != 0 && b != 0)
            {
                if (a > b) a = a % b;
                else b = b % a;
            }
            return $"Наибольший общий делитель - {a + b}";
        }

        public static int GetNumberDisectionMethod (int a)
        {
            //Пользователь вводит целое положительное число, которое является кубом целого числа N.
            //Найдите число N методом половинного деления.
            if (a == 0 ) throw new ArgumentException("Заданное число равно 0!");
            int left = 0;
            int right = a;
            int middle = -2;

            while (left+1 != right-1)
            {
                middle = (left + right) / 2;
                if (Math.Pow(middle, 3) == a) return middle;
                else if (Math.Pow(middle, 3) > a) right = middle;
                else if (Math.Pow(middle, 3) < a) left = middle;

            }
            return middle;
        }




        public static string FindNumberOddDigitsNumber (int value)
        {
            // Пользователь вводит одно число произвольной длины (5-8 цифр).
            // Найти количество нечетных цифр этого числа.
            if (value == 0) throw new ArgumentException("Заданное число равно 0!");
            int numProverka, kolNeChetnih = 0, value1;
            value1 = value;
            while (true)
            {
                numProverka = value % 10;
                value /= 10;
                if (numProverka % 2 != 0) kolNeChetnih++;
                else if (value == 0) break; 
            }
            return ($"Количество не четных цифр в числе {value1} равно { kolNeChetnih} ");
        }


        public static int ReturnNumberReverse (int value)
        {
            //Пользователь вводит одно число.
            //Найти число, которое является зеркальным отображением последовательности цифр заданного числа,
            //например, задано число 123, вывести 321. Просьба массивами и строками не пользоваться.
            if (value == 0) throw new ArgumentException("Заданное число равно 0!");
            int L = value.ToString().Length;
            int i = 0;
            int a = 0;
            while (value > 0)
            {
                a += (value % 10) * (int)Math.Pow(10, L - i - 1);
                i++;
                value /= 10;
            }
            return a;
        }


        public static List<int> GetSumEvenDigitsGreaterSumOddDigits(int value)
        {       

            List<int> res = new List<int>();

            for (int i = 1; i <= value; i++)
            {
                int even_sum = 0;
                int odd_sum = 0;

                int copy = i;
                while (copy > 0)
                {
                    int d = copy % 10;
                    if (d % 2 == 0) even_sum += d;
                    else odd_sum += d;
                    copy /= 10;
                }

                if (even_sum > odd_sum)
                    res.Add(i);
            }
            return res;
        }


        public static bool GetSameNumber(int a, int b)
        {
            //Пользователь вводит два числа.
            //Сообщите, есть ли в написании двух чисел одинаковые цифры.
            //Например, для пары 123 и 3456789, ответом будет являться “ДА”, а, для пары 500 и 99 - “НЕТ”.

            if (a == 0 && b == 0 ) throw new ArgumentException("Заданное число равно 0!");

            if (a < 0) a *= -1;
            if (b < 0) b *= -1;

            bool om = false;

            for (int i = a; i > 0; i /= 10)
            {
                int c = i % 10;
                for (int j = b; j > 0; j /= 10)
                {
                    int d = j % 10;
                    if (d == c)
                    {
                        om = true;
                        return om;
                    }
                }
            }
            return om;




        }


       
        


    }
}
