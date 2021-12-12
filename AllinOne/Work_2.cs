using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllinOne
{
    public class Work_2
    {
        public static int GetSumThreeNumbers (int a)
        {
            //Посчитать сумму всех трех цифр трехзначного числа, заданного константой(const).
            //Вывести сумму на печать.
            //Например:735 = 15(7 + 3 + 5) 
            int l = Helper.GetLengthNumber(a);
            if (3 > l) throw new ArgumentException($"Ошибка №  {a}  .  Число не является трехзначным!");
            else if (3 < l) throw new ArgumentException($"Ошибка №{a}  . Число не является трехзначным!");
            else if (a == 0) throw new DivideByZeroException($"Ошибка №{a} .Число не является трехзначным!");
            else
            {
                int a1 = a % 10;               
                int a2 = (a / 10) % 10;
                int a3 = a / 100;
                

                return a1 + a2 + a3;
            }
           

        }

        public static bool GetResultShot(int x, int y)
        {
            // Ввести с клавиатуры координаты выстрела x1 и y1.
            // Записать в bool переменную логическое выражение, которое будет истинным(true) тогда и только тогда,
            // когда этот выстрел попадает в круглую мишень(точка лежит внутри круга радиусом R).
            // Вывести bool переменную на экран.
            //Формула круга: x ^ 2 + y ^ 2 = R ^ 2.
            //Следовательно, условие нахождения точки ВНУТРИ круга будет... (подумайте о знаке сравнения). 
            //Запись x^2 означает "икс в квадрате".

            const int R = 16;

            bool hit = Math.Pow(x, 2) + Math.Pow(y, 2) <= Math.Pow(R, 2);

            return hit;

        }

        public static bool ThreeNumberWithGetDigits(int b)
        {
            //Пользователь вводить трехзначное число.
            //Записать логическое условие, которые будет истинным тогда и только тогда,
            //когда его средняя цифра меньше или равна(<=) первой(левой) и
            //одновременно строго больше(>) последней(правой).
            int l = Helper.GetLengthNumber(b);

            int b1 = b / 100;
            int b2 = (b / 10) % 10;
            int b3 = b % 10;

            if(l > 3) throw new ArgumentException("Ошибка №" + b + ".  Число не является трехзначным!");
            if(l < 3) throw new ArgumentException("Ошибка №" + b + ".  Число не является трехзначным!");
            if(b == 0) throw new DivideByZeroException("Ошибка №" + b + ".  Число равно 0 !");
            bool a = b1 >= b2 && b2 > b3;
            return a;
            
          
        }



        public static int ReturnNewThreeNumber(int a)
        {
            //Ввести целое трехзначное число. Поменять местами его первую и последнюю цифры.
            //Собрать новое число в новой переменной!

            int l = Helper.GetLengthNumber(a);

            if (l > 3) throw new ArgumentException("Ошибка №" + a + ".  Число не является трехзначным!");
            if (l < 3) throw new ArgumentException("Ошибка №" + a + ".  Число не является трехзначным!");
            if (a == 0) throw new DivideByZeroException("Ошибка №" + a + ".  Число равно 0 !");
            
            int a1 = a / 100;
            int a2 = (a / 10) % 10;
            int a3 = a % 10;

            int a4 = a1;
            a1 = a3;
            a3 = a4;

            return (a1 * 100) + (a2 * 10) + a3;
           
        }


        public static string CheckFractionalPart(double value)
        {
            //Записать логическое условие, которое проверит, что в double числе нулевая дробная часть.

            int a = (int)value;

            if (value == a) return (value + $" (true)");
            else return (value + " (false)");

        }

                


    }
}
