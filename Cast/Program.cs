using System;

namespace Cast
{
    class Program
    {
        
        public static void PrintResult(object result)
        {
            Console.WriteLine("Ваш ответ: " + result);
        }

        public static int Sum (int a)
        {

            if (a > 999)
            {
                throw new Exception("Ошибка №" + a + ".  Число не является трехзначным");               
            }

            else if (a < 100)
            {
                throw new Exception("Ошибка №" + a + ".  Число не является трехзначным");               
            }

            else
            {
                int a1 = a % 10;
                int a2 = (a / 10) % 10;
                int a3 = a / 100;
                return (a1 * 100) + (a2 * 10) + a3;                
                
            }
        }

        public static double ShotСalculation (double x, double y)
        {           
            const double R = 8;
            bool hit = true;
            if (true)
            {
               return Math.Pow(x, 2) + Math.Pow(y, 2);

            }
            else
            {
                return 0;

            }

            
        }

        public static int Comparison(int a)
        {
            

            int a1 = a / 100;
            int a2 = (a / 10) % 10;
            int a3 = a % 10;

            if (a > 999)
            {
                throw new Exception("Ошибка №" + a + ".  Число не является трехзначным");
            }

            else if (a < 100)
            {
                throw new Exception("Ошибка №" + a + ".  Число не является трехзначным");
            }


            if (a1 >= a2 && a2 > a3)
            {
                return (a + "(true)");

            }

            else
            {
                return (a + "(false)");
            }
        }
        static void Main(string[] args)
        {
            int a = Sum(123);
            PrintResult(a);

            double b = ShotСalculation(2.3, 3.4);
            PrintResult(b);
        }
    }
}
