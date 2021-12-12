using System;

namespace Variables
{
    class Helper
    {
        

    }
    class Program
    {
        public static void PrintResult(object result)
        {
            Console.WriteLine("Ваш ответ: " + result);
        }

        public static int Sum (int a, int b)
        {                    

            return a + b;
        }

       public static double EquationSolution (double a, double b)
        {
            return  (5 * a + Math.Pow(b, 4)) / (b - a);
        }

        public static string SwapStrings (string s1, string s2)
        {
            string s3 = s2;
            s2 = s1;
            s1 = s3;

            return ($"{s1}, {s2}");
        }

        public static double LinearEquationSolution (int a, int b, int c)
        {
            return  (b - c) / a;
        }

        public static double SquareSolution (int a, int b, int c)
        {
            double d = Math.Pow(b, 2) - 4 * a * c;

            
            
            if (d > 0)
            {
               double x1 = (-b + Math.Sqrt(d)) / (2 * a);
                double x2 = (-b - Math.Sqrt(d)) / (2 * a);


                
                return x1; 
            }


            else if (d < 0)
            {
                return 0 ;
            }

            else 
            {
                return  -b / (2 * a);
                
            }

        }


        static void Main(string[] args)
        {
            Helper h = new Helper();
            int c = Sum(5, 4);
            PrintResult(c); 

            int b = (int)EquationSolution(7.0, 8.0);
            PrintResult(b);

            int d = (int)LinearEquationSolution(3, 4, 5);
            PrintResult(d);

            string str = SwapStrings("Привет", "Пока");
            Console.WriteLine("Ваш ответ  " + str);

            int doub =(int)SquareSolution(3, 7, 4);
            PrintResult(doub);
            
            
        }
    }
}
