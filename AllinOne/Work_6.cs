using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllinOne
{
    public class Work_6
    {
        public static int[,] SwapSignsOppositeAlongEdgesArray(int[,] mas_a)
        {
            SwapSignsOppositeAlongEdgesArrayInner(ref mas_a);

            return mas_a;
        }

        public static void SwapSignsOppositeAlongEdgesArrayInner(ref int[,] mas_a)
        {
            //Поменять знак на противоположный у всех элементов, расположенных по краям двумерного массива NxM.
            //Изменяющиеся элементы должны образовать "рамочку" толщиной в 1 элемент.
            //Примечание: здесь "NxM" означает, что массив прямоугольный, произвольного размера.
            //Наиболее наглядно такие задачи показывают себя на массивах, например, 5x8.           



            for (int j = 0; j < mas_a.GetLength(1); j++)
            {
                mas_a[0, j] *= -1;
                mas_a[mas_a.GetLength(0) - 1, j] *= -1;
            }
            for (int i = 1; i < mas_a.GetLength(0) - 1; i++)
            {
                mas_a[i, 0] *= -1;
                mas_a[i, mas_a.GetLength(1) - 1] *= -1;
            }


        }


        public static int[,] FillMultiplicationTable(int[,] mas_a)
        {
            FillMultiplicationTableInner(ref mas_a);
            return mas_a;
        }
        public static void FillMultiplicationTableInner(ref int[,] mas_a)
        {
            //Заполнить матрицу 9x9 таблицей умножения
        
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {

                    mas_a[i, j] = i * j;
                 
                }               

            }
        }

        public static int[,] FillMatrixLikeCheckerboard(int[,] mas_a, int a, int b)
        {
            FillMatrixLikeCheckerboardInner(ref mas_a, a, b);
            return mas_a;
        }

        public static void FillMatrixLikeCheckerboardInner (ref int[,] mas_a, int a, int b)
        {
            //Заполнить квадратную матрицу NxN (произвольного размера) нулями и единицами так,
            //как расположены клетки на шахматной доске, где 0 - "черное", 1 - "белое".
            //Левое нижнее поле на шахматной доске всегда черное.
            //Обратите внимание - нумерация элементов массива идет сверху вниз, и слева направо.
            //То есть, левое нижнее поле - это поле в последней строке и 0-м столбце.


            

            if (a % 2 != 0 && b % 2 != 0)
            {
                for (int i = 0; i < mas_a.GetLength(0); i++)
                {
                    for (int j = 0; j < mas_a.GetLength(1); j++)
                    {
                        if (i % 2 != 0 && j % 2 == 0 || i % 2 == 0 && j % 2 != 0)
                        {
                            mas_a[i, j] = 1;
                        }
                        else
                        {
                            mas_a[i, j] = 0;
                        }
                        
                    }
                    
                }
            }
            else
            {
                for (int i = 0; i < mas_a.GetLength(0); i++)
                {
                    for (int j = 0; j < mas_a.GetLength(1); j++)
                    {
                        if (i % 2 != 0 && j % 2 == 0 || i % 2 == 0 && j % 2 != 0)
                        {
                            mas_a[i, j] = 0;
                        }
                        else
                        {
                            mas_a[i, j] = 1;
                        }
                        
                    }
                    
                }

            }
        }


        
        public static string CheckCovidRules (int x, int y)
        {
            //Зрительный зал театра имеет N рядов по M мест в каждом ряду.
            //Их можно представить в виде двумерного массива NxM.
            //Если место занято - в массиве стоит значение "1". Если свободно - "0".
            //Образец массива задать вручную, инициализацией в момент создания.
            //На готовом массиве проверить соблюдение "антиковидного правила"
            //(нет двух занятых мест в одном ряду, расположенных рядом, но пропусков может быть сколько угодно).
            //Сделать по оптимальному алгоритму (если нашли два занятых кресла рядом в одном ряду - прервать циклы обхода матрицы)

            int[,] mas = new int[5, 5]
            {
               { 0 , 0 , 0 , 1 , 0 },
               { 0 , 0 , 0 , 0 , 1 },
               { 0 , 0 , 1 , 0 , 1 },
               { 0 , 1 , 0 , 0 , 0 },
               { 0 , 1 , 0 , 0 , 0 }
            };

            

            bool is_rule = true;
            for (int i = 0; i < mas.GetLength(0); i++)
            {
                for (int j = 0; j < mas.GetLength(1) - 1; j++)
                {
                    if (mas[i, j] == 1 && (mas[x, y + 1] == 1|| mas[x, y - 1] == 1))
                    {
                        is_rule = false;
                        break;
                    }

                }
                if (!is_rule) break;

            }
            if (is_rule) return("Рассадка не нарушает ковидных мер");
            else return("Рассадка не по правилам");
        }

        public static string CalculateAmountAverageIncome(int[,] mas_a)
        {
            int[] mas_sum = CalculateAmountAverageIncomeTimeSumm(mas_a);
            int[] mas_sr = CalculateAmountAverage(mas_sum);
            string info = CalculateAmountMinAndMax(mas_a);
            return $"Суммы за все месяцы по каждому магазину:{string.Join(", ", mas_sum)}\n" +
                $"Средний доход по каждому месяцу: {string.Join(", ", mas_sr)}\n" +
                $"Мин.и Макс. доход за весь период-{info}";

        }

        public static int[] CalculateAmountAverageIncomeTimeSumm(int[,] mas_a)
        {
            //Фирма имеет 10 магазинов.
            //Доходы каждого магазина за полугодие (6 месяцев с номерами 0-5) хранятся в двумерном вещественном массиве.
            //Заполнить массив случайными вещественными числами. Высчитать:
            //а) суммарный доход по каждому магазину;                     
            
            int[] sum = new int[10];
                              
            for (int i = 0; i < mas_a.GetLength(0); i++)
            {
                for (int j = 0; j < mas_a.GetLength(1); j++)
                {
                    sum[i] += mas_a[i, j];                                      
                }
                           
            }

            return sum;

        }
        public static int[] CalculateAmountAverage(int[] mas)
        {
            //б) средний доход по каждому месяцу;
            int[] sr = new int[10];  
            
            for (int i = 0; i<10;i++) sr[i] = mas[i] / 6;          

            return sr;
        }
        public static string CalculateAmountMinAndMax(int[,] mas_a)
        {
            //в) мин.и макс. доход за весь период.
            int min = mas_a[0, 0];
            int max = mas_a[0, 0];
            for (int i = 0; i < mas_a.GetLength(0); i++)
            {
                for (int j = 0; j < mas_a.GetLength(1); j++)
                {
                    if (mas_a[i, j] < min) min = mas_a[i, j];
                    if (mas_a[i, j] > max) max = mas_a[i, j];
                }                  
                                   
            }
            return $"min-{min}, max-{max}";
        }



        public static int FindNumberAllNeighborsSameTime (int[,]mas)
        {
            //Найти количество элементов массива, которые больше всех своих соседей одновременно. 
            //Примечание: соседями элемента считать только 4 потенциальных соседа:
            //на 1 выше, на 1 ниже, на 1 левее и на 1 правее.
            //Обязательно учесть выход за границы массива!
            //При определении критерия, считать сумму соседей для каждого элемента, даже для элемента [0;0]
            //(у него, кстати, будет всего два соседа - [0; 1] и [1; 0]).
           

            
            int count = 0;
            int sum = 0;
            for (int i = 0; i < mas.GetLength(0); i++)
            {
                for (int j = 0; j < mas.GetLength(1); j++)
                {
                    sum = (i > 0 ? mas[i - 1, j] : 0)
                        + (i < mas.GetLength(0) - 1 ? mas[i + 1, j] : 0)
                        + (j > 0 ? mas[i, j - 1] : 0)
                        + (j < mas.GetLength(1) - 1 ? mas[i, j + 1] : 0);

                    if (mas[i, j] > sum) count++;
                }

            }
            return count;
        }


        public static int[,] FillCharArrayFromPicture(int[,]mas)
        {
            FillCharArrayFromPictureInner(ref mas);
            return mas;
        }

        public static void FillCharArrayFromPictureInner (ref int[,]mas)
        {
            //Заполнить массив из символов(char) указанным образом

            

            for (int i = 0; i < mas.GetLength(0); i++)
            {
                for (int j = 0; j < mas.GetLength(1); j++)
                {
                    mas[i, j] = (i <= j && i <= mas.GetLength(0) - j - 1) || (i >= j && i >= mas.GetLength(0) - j - 1) ? 1 : 0;

                }
                
            }
            
        }


        public static int[,] ImplementMatrixMultiplicationIntegers(int[,] mas_a, int[,] mas_b, int[,]mas_c)
        {
            ImplementMatrixMultiplicationIntegersInner(mas_a, mas_b, ref mas_c);
            return mas_c;
        }


        public static void ImplementMatrixMultiplicationIntegersInner (int[,]mas_a,int[,]mas_b,ref int[,]mas_c)
        {
            //Реализовать перемножение матриц целых чисел.
            //Примеры не сложно найти в сети.
            //Важно их понять и адаптировать для ваших двух произвольных массивов. Проверить входное условие перемножения
            //(число столбцов 1-го массива == числу строк 2-го массива)

            
            int[,] mas_c1 = new int[mas_a.GetLength(0), mas_b.GetLength(1)];

            for (int i = 0; i < mas_a.GetLength(0); i++)
            {
                for (int j = 0; j < mas_b.GetLength(1); j++)
                {
                    mas_c1[i, j] = 0;

                    for (int k = 0; k < mas_a.GetLength(1); k++)
                    {
                        mas_c1[i, j] += mas_a[i, k] * mas_b[k, j];
                    }
                }
            }

            mas_c = mas_c1;
        }


    }
}
