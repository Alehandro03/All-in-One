using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllinOne
{
    class Point
    {
        public static int A;
        public static int B;
        public static int C;
        public Point() { }
        
        public Point (int a)
        {
            A = a; 
        }
        public Point(int a, int b)    
            :this (a)
        {          
            B = b;
        }
        public Point(int a,int b, int c)
            : this(a , b)
        {                      
            C = c;
        }

    }

    public class Work_1
    {
        
        public static int GetSum(int a, int b)
        {
            
            return a + b;
        }

        public static double GetDivisiNumber(int a , int b)
        {           
            if(5 * a + Math.Pow(b, 4) == 0 )
            {
                throw new DivideByZeroException("Числитель равен нулю!");
            }
            return  (5 * a + Math.Pow(b, 4)) / (b - a);          
        }

        public static string SwapPlaces(string s1, string s2)
        {
            if (s1 != s2)
            {
                string s3 = s2;
                s2 = s1;
                s1 = s3;
                return ($"{s1}, {s2}");
            }
            else throw new ArgumentException("Одинаковые значения!");
                     
        }

        public static double DivideDifference(int a, int b, int c)
        { 
            if(b - c == 0)
            {
                throw new DivideByZeroException("Числитель равен нулю!");
            }
            return (b - c) / a;           
        }

        public static string GetRootsDiscriminant(int a, int b, int c)
        {
           double x1 = 0;
           double x2 = 0;
            if(a==0 && b==0 && c==0 )
            {
                throw new DivideByZeroException("Показатели равны нулю!");
            }
           int resolve = Helper.Resolve(a, b, c,  ref x1, ref x2);

           if (resolve == 0) return ($"Один корень: { x1}");
           if (resolve < 0) return ("Корней нет");
           else return ($"Два корня: {x1}, {x2}");          

        }

        



    }
}
