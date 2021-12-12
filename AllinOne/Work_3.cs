using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllinOne
{
    public class Work_3
    {

        public static int CheckConditionsRavenstAndReturnAnswer(int a ,int b)
        {
            //Пользователь вводит два числа(A и B).
            //Если A > B, подсчитать A+B, если A == B, подсчитать A*B, если A<B, подсчитать A-B.
            //Сделать лесенкой из двух if'ов.

            if (a > b) return a + b;
            if (a == b) return a * b;
            return a - b;
            
        }
        
        public static string DefineQuarter(int x, int y)
        {
            //Пользователь вводит два числа(X и Y).
            //Определить какой четверти координатной плоскости принадлежит точка с координатами(X, Y).
            if(x == 0 && y == 0) throw new DivideByZeroException("Координаты точек равны нулю");
            if (x >= 0 && y >= 0) return ("Точка принадлежит первой четверти");
            if (x > 0 && y < 0) return("Точка принадлежит второй четверти");
            if (x <= 0 && y <= 0) return ("Точка принадлежит третей четверти");
            if (x < 0 && y > 0) return ("Точка принадлежит четвертой четверти");
            return "0";
            
        }


        public static string GetOutAscendingOrder(int a, int b, int c)
        {
            //Пользователь вводит три числа (A, B и С).
            //Выведите их в консоль в порядке возрастания.
            //Можно использовать сложное условное выражение, но можно и if'ами.

            if (a > b && b > c) return ($"Ответ {c} < {b} < {a}");
            if (a > c && b < c) return ($"Ответ {b} < {c} < {a}");
            if (a < c && b > c) return ($"Ответ {a} < {c} < {b}");           
            if (c > b && b > a) return ($"Ответ {a} < {b} < {c}");
            if (b > a && a > c) return ($"Ответ {c} < {a} < {b}");          
            if (c > a && a > b) return ($"Ответ {b} < {a} < {c}");  
            
            else throw new ArgumentException("Введено не верное значение!");
           
        }

        public static string GetAllRootsEquation (int a, int b, int c)
        {
            // Пользователь вводит три числа (A, B и С).
            // Выведите в консоль решение (значения X) квадратного уравнения стандартного вида, где AX^2+BX+C=0.
            //На этот раз обработать все три случая: корней нет, один корень(и его значение), два корня(и два значения).
            //Для переменных корней использовать
            //переменные с локальной областью видимости в ветке самого if (чтобы не плодить лишние переменные заранее).
            //То есть, если корней нет -
            //вообще переменная не нужна, если один корень - одна переменная, если два -две.


            double x1 = 0;
            double x2 = 0;
            if (a == 0 && b == 0 && c == 0)
            {
                throw new DivideByZeroException("Числа равны нулю!");
            }
            int resolve = Helper.Resolve(a, b, c, ref x1, ref x2);

            if (resolve == 0) return ($"Один корень: {x1}");
            if (resolve < 0) return ("Корней нет");
            return ($"Два корня: {x1}, {x2}");

        }

        public static string GetNumberLetters(int a)
        {
            //Пользователь вводит двузначное число.
            //Выведите в консоль прописную запись этого числа.
            //Например при вводе “25” в консоль будет выведено “двадцать пять”.
            //Примечание.Здесь, пожалуй, удобно использовать switch-case,
            //но можно и if-ами.Да, потребуется много веткой с соответствующими словами ))
            //Но их будет не 89(10 - 99) :)
            //Подумайте, как можно сделать поменьше. Анализируйте соответствующие цифры и выводите соответствующий текст.
            string s = "0";
            string s2 = "0";
            if (a >= 10 && a < 20)
            {
                
                switch (a)
                {
                    case 10: return "Десять"; 
                    case 11: return "Одиннадцать"; 
                    case 12: return "Двенадцать"; 
                    case 13: return "Тринадцать"; 
                    case 14: return "Четырнадцать"; 
                    case 15: return "Пятнадцать"; 
                    case 16: return "Шестнадцать"; 
                    case 17: return "Семнадцать"; 
                    case 18: return "Восемнадцать"; 
                    case 19: return "Девятьнадцать"; 
                }
            }
            else if (a >= 20 && a < 100)
            {
                int b = (a / 10) * 10;
                int c = a % 10;

                
                switch (b)
                {
                    case 20: s =  "Двадцать "; break;
                    case 30: s = "Тридцать "; break;
                    case 40: s = "Сорок "; break;
                    case 50: s = "Пятьдесят "; break;
                    case 60: s = "Шестьдесят "; break;
                    case 70: s = "Семьдесят "; break;
                    case 80: s = "Вщсемьдесят "; break;
                    case 90: s = "Девяносто "; break;
                }
                               

                switch (c)
                {
                    case 1: s2 =  "один"; break;
                    case 2: s2 = "два"; break;
                    case 3: s2 = "три"; break;
                    case 4: s2 = "четыре"; break;
                    case 5: s2 = "пять"; break;
                    case 6: s2 = "шесть"; break;
                    case 7: s2 = "семь"; break;
                    case 8: s2 = "восемь"; break;
                    case 9: s2 = "девять"; break;
                    
                }
                return $"{s}{s2}";

            }
            else throw new ArgumentException("Число не двузначное");

            return "0";

        }

        public static string DetermineExistenceTriangle (int a, int b, int c)
        {
            //Даны вещественные положительные числа a, b, c.
            //Выяснить, существует ли треугольник со сторонами a, b, c.

            if (a <= 0 || b <= 0 || c <= 0) throw new ArgumentException ("Заданы не верные параметры");
            if (b == a || a == c || c == b) throw new ArgumentException("Заданы не верные параметры");
            if (b < a + c && a < b + c && c < a + b) return ("Треугольник существует");
            return ("Треугольник не существует");


        }

        public static string DeterminePositionPoint(int Radius, int x, int y)
        {
            //Ввести с клавиатуры вещественное число R и две точки (координаты) x и y.
            //Определить, принадлежит ли точка с координатами [x; y] заштрихованной фигуре.

            if (x >= Radius && x <= Radius * 2) return ($" Точка [{x}; {y}] принадлежит заштрихованной фигуре");
            if (y >= Radius && y <= Radius * 2) return ($" Точка [{x}; {y}] принадлежит заштрихованной фигуре");
            if (x >= -2 * Radius && x <= 0) return ($" Точка [{x}; {y}] принадлежит заштрихованной фигуре");
            if (y >= -2 * Radius && y <= 0) return ($" Точка [{x}; {y}] принадлежит заштрихованной фигуре");
            return ($" Точка [{x}; {y}]  не принадлежит заштрихованной фигуре");
            
        }








        
        


    }
}
