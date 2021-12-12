using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllinOne
{
    class PointArray
    {
        public int A;
        public int B;
        public int C;

        public PointArray() { }

    }
    public class Work_5
    {

        public static string CountNumberOddAndEvenElementsArray (int value)
        {
            // Посчитать количества нечетных и четных элементов массива.
            // Не путать с нечетными и четными индексами.
            
                  
            int[] a = new int[10] { value,20,13,14,5,6,8,2,45,7};

            if ( a == null) 
            {
                throw new NotImplementedException("Пустой массив!");
            }


            int sum_a = 0;
            int sum_b = 0;          


            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] % 2 == 0) sum_a += 1;              
                else sum_b += 1;
               
            }
           return ($"Колличество четных элементов массива: {sum_a}. Колличество нечетных: {sum_b} ");


        }


        public static int[] ReplaceThirdElementSumTwoNumbers (int value)
        {
            

            // Каждый третий элемент массива заменить суммой двух предыдущих элементов.          

            int[] a = new int[10] { value, 20, 13, 14, 5, 6, 8, 2, 45, 7 };
            if (a == null)
            {
                throw new NotImplementedException("Пустой массив!");
            }

            for (int i = 2; i < a.Length; i += 3)
            {
                a[i] = a[i - 1] + a[i - 2];
                
            }
            return a;
                              

        }

        public static string ConnectTwoArray (int a, int b)
        {
            // Слить два целочисленных массива в один (должен получиться третий массив).
            if (a == 0 || b ==0)
            {
                throw new DivideByZeroException("Пустое значение!");
            }
            int[] mas_a = new int[10] { a, 20, 13, 14, 5, 6, 8, 2, 45, 7 };           
            int[] mas_b = new int[5] { b, 28, 14, 114, 6 };
            int[] mas_c = new int[15];
            for (int i = 0; i < mas_c.Length; i++)
            {
                int j = i;
                while (j == i)
                {
                    if (i < mas_a.Length) mas_c[i] = mas_a[i];

                    else mas_c[i] = mas_b[i - mas_a.Length];
                    
                    j++;

                }              

            }
            
            return string.Join(" ", mas_c); 
             


        }
       

        public static string SwapHalvesArray (int value)
        {

            //Поменять местами первую и вторую половину массива.
            //например, для массива 1 2 3 4, результат 3 4 1 2,  или для 1 2 3 4 5 - 4 5 3 1 2.

            int[] mas_a = new int[11] { value, 20, 13, 14, 5, 6, 8, 2, 45, 7, 5 };


            for (int i = 0; i < (mas_a.Length) / 2; i++)
            {
                int tmp = mas_a[i];
                mas_a[i] = mas_a[mas_a.Length / 2 + (1 + i)];
                mas_a[mas_a.Length / 2 + (1 + i)] = tmp;
            }
            return string.Join(' ', mas_a);
        }

        public static string CycleArrayRightOneElement (int a, int k)
        {
            //Циклически двинуть массив вправо на 1 элемент.
            //Например: 1 2 3 4 5 -> 2 3 4 5 1. А после этого сделать циклический сдвиг вправо на N элементов.            


            int[] mas_a = new int[11] { a, 20, 13, 14, 5, 6, 8, 2, 45, 7, 5 };
                                        
            for (int i = 0; i < k; ++i)
            {
                int aLast = mas_a[a - 1];
                for (int j = a - 1; j > 0; j--)
                    mas_a[j] = mas_a[j - 1];
                mas_a[0] = aLast;
            }
                        
            return string.Join(' ', mas_a); ;


        }

        public static string SwapOddAndEvenNumbersIntoArray (int a)
        {
            //Преобразовать массив так, чтобы на четных позициях стояли элементы с нечетных позиций, и наоборот.


            int[] mas_a = new int[11] { a, 20, 13, 14, 5, 6, 8, 2, 45, 7, 5 };

            for (int i = 1; i < mas_a.Length; i += 2)
            {
                int[] mas_b = new int[11];
                mas_b[i] = mas_a[i];
                mas_a[i] = mas_a[i - 1];
                mas_a[i - 1] = mas_b[i];

                
            }
            return string.Join(' ', mas_a);
        }

        public static string CalculateModulusAndSumElementsAfterZero (int a)
        {
            //В массиве из целочисленных элементов (включая отрицательные) вычислить:
            //а) минимальный по модулю элемент массива;
            //б) сумму элементов, расположенных после первого нулевого элемента (элемента, равного нулю).
            //Сделать одним проходом цикла


            int[] mas_a = new int[11] {  -20, 13, 14, -5, 0, 8, a, 2, -45, 7, 5 };

            int num = mas_a[1];
            int sum = 0;

            for (int i = 0; i < mas_a.Length; i++)
            {
                if (Math.Abs(mas_a[i]) < Math.Abs(num)) num = mas_a[i];

                else if (mas_a[i] > 0) sum += mas_a[i];
                
                    
                
            }
            return ($"Минимальный по модулю элемент {num}\t " +
                $"Cумма элементов, расположенных после первого нулевого элемента {sum}");


        }

        public static string SortArrayUpInsert (int a)
        {
            //Отсортировать массив по возрастанию алгоритмом вставок (insert).
            //Определить для себя вариацию алгоритма для сортировки по убыванию (реализовывать не обязательно).



            int[] mas_a = new int[11] { -20, 13, 14, -5, 0, 8, a, 2, -45, 7, 5 };

            int i = 0;
            

            for (i = 0; i < mas_a.Length; i++)
            {

                for (int j = i + 1; j < mas_a.Length; j++)
                {
                    if (mas_a[i] > mas_a[j])
                    {
                        int tmp = mas_a[i];
                        mas_a[i] = mas_a[j];
                        mas_a[j] = tmp;
                    }

                }

                
            }
            return string.Join(' ', mas_a);
        }

        public static string SortArrayDownSelect (int a)
        {
            // В данном примере отсортировал по убыванию.
            // Отсортировать массив по возрастанию алгоритмом выборки (select).
            // Определить для себя вариацию алгоритма для сортировки по убыванию (реализовывать не обязательно).


            int[] mas_a = new int[11] { -20, 13, 14, -5, 0, 8, a, 2, -45, 7, 5 };


            for (int i = 0; i < mas_a.Length; i++)
            {
                int indx = i;
                for (int j = i; j < mas_a.Length; j++)
                {
                    if (mas_a[j] > mas_a[indx]) indx = j;                                            
                }
                if (mas_a[indx] > mas_a[i])
                {
                    int temp = mas_a[i];
                    mas_a[i] = mas_a[indx];
                    mas_a[indx] = temp;
                }
                
            }
            return string.Join(' ', mas_a);
        }

        public static void CountNumberOddAndEvenElementsArray(object p)
        {
            throw new NotImplementedException();
        }
    }
}
