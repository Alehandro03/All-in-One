using System;
using System.Collections.Generic;

namespace AllinOne
{
    
    class Program
    {
        

        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.BackgroundColor = ConsoleColor.DarkBlue;


            int n = 30;

            //Console.WriteLine("Введит длинну массива и толшену массива");
            //int a1 = int.Parse(Console.ReadLine());
            //int b1 = int.Parse(Console.ReadLine());
            //int[,] matr = IOHelper.GenerateDoubleArrayInt(a1,b1,1,100);
            //Work_6.SwapSignsOppositeAlongEdgesArray( matr);
            //HelperArray.PrintDoubleArray(matr);
            //Helper.Line(n);


            //Console.WriteLine("Введит длинну массива и толшену массива");
            //int a2 = int.Parse(Console.ReadLine());
            //int b2 = int.Parse(Console.ReadLine());
            //int[,] matr2 = IOHelper.GenerateDoubleArrayInt(a2, b2, 1, 100);
            //Work_6.FillMultiplicationTable(matr2);
            //HelperArray.PrintDoubleArray(matr2);
            //Helper.Line(n);


            //Console.WriteLine("Введит длинну массива и толшену массива");
            //int a3 = int.Parse(Console.ReadLine());
            //int b3 = int.Parse(Console.ReadLine());
            //int[,] matr3 = IOHelper.GenerateDoubleArrayInt(a3, b3, 0, 1);
            //Work_6.FillMatrixLikeCheckerboard(matr3,a3,b3);
            //HelperArray.PrintDoubleArray(matr3);
            //Helper.Line(n);


            //Console.WriteLine("Введит ряди и место:");
            //int a4 = int.Parse(Console.ReadLine());
            //int b4 = int.Parse(Console.ReadLine());
            //Helper.PrintResult(Work_6.CheckCovidRules(a4,b4));
            //Helper.Line(n);


            Console.WriteLine("Введите колличество месяцев и число магазинов");
            int a5 = int.Parse(Console.ReadLine());
            int b5 = int.Parse(Console.ReadLine());
            int[,] matr5 = IOHelper.GenerateDoubleArrayInt(a5, b5, 0, 10000);            
            Helper.PrintResult(Work_6.CalculateAmountAverageIncome(matr5));
            Helper.Line(n);

            //Console.WriteLine("Введите длинну и ширину массива");
            //int a6 = int.Parse(Console.ReadLine());
            //int b6 = int.Parse(Console.ReadLine());
            //int[,] matr6 = IOHelper.GenerateDoubleArrayInt(a6, b6, 0, 100);
            //Helper.PrintResult(Work_6.FindNumberAllNeighborsSameTime(matr6));
            //Helper.Line(n);



            //int[,] matr7 = IOHelper.GenerateDoubleArrayInt(7, 7, 0, 1);          
            //Work_6.FillCharArrayFromPicture(matr7);
            //HelperArray.PrintDoubleArray(matr7);
            //Helper.Line(n);


            //int[,] mas_a = new int[3, 4]{
            //        { 2, 4, 5, 7 },
            //        { 7, 3, 7, 8 },
            //        { 7, 8, 9, 4 }};
            //int[,] mas_b = new int[4, 2]{
            //        { 2, 4 },
            //        { 3, 4 },
            //        { 5, 6 },
            //        { 3, 6 } };
            //int[,] mas_c = new int[,] { { 1, 2 }, { 2, 3 } };
            //HelperArray.PrintDoubleArray(Work_6.ImplementMatrixMultiplicationIntegers(mas_a, mas_b, mas_c));

            //Helper.Line(n);

            //Helper.PrintResult("Массивы:  ");

            //Helper.PrintResult("Введи длинну массива: ");
            //Helper.PrintResult(Work_5.CountNumberOddAndEvenElementsArray(int.Parse(Console.ReadLine())));
            //Helper.Line(n);

            //Helper.PrintResult("Введи длинну массива: ");
            //Work_5.ReplaceThirdElementSumTwoNumbers(int.Parse(Console.ReadLine()));
            //Helper.Line(n);

            //Helper.PrintResult("Задайте длины двум массива: ");
            //Helper.PrintResult(Work_5.ConnectTwoArray(int.Parse(Console.ReadLine()), int.Parse(Console.ReadLine())));           
            //Helper.Line(n);

            //Helper.PrintResult("Введи длинну массива: ");
            //Helper.PrintResult(Work_5.SwapHalvesArray(int.Parse(Console.ReadLine())));
            //Helper.Line(n);

            //Helper.PrintResult("Введи длинну массива и циклический сдвиг вправо на N элементов: ");
            //Helper.PrintResult(Work_5.CycleArrayRightOneElement(int.Parse(Console.ReadLine()), int.Parse(Console.ReadLine())));
            //Helper.Line(n);

            //Helper.PrintResult("Введи длинну массива: ");
            //Helper.PrintResult(Work_5.SwapOddAndEvenNumbersIntoArray(int.Parse(Console.ReadLine())));
            //Helper.Line(n);

            //Helper.PrintResult("Введи длинну массива: ");
            //Helper.PrintResult(Work_5.CalculateModulusAndSumElementsAfterZero(int.Parse(Console.ReadLine())));
            //Helper.Line(n);

            //Helper.PrintResult("Введи длинну массива: ");
            //Work_5.SortArrayUpInsert(int.Parse(Console.ReadLine()));
            //Helper.Line(n);

            //Helper.PrintResult("Введи длинну массива: ");
            //Work_5.SortArrayDownSelect(int.Parse(Console.ReadLine()));
            //Helper.Line(n);


            //Helper.PrintResult("Переменные:  ");

            //Helper.PrintResult("Введи два целых числа");
            //int a = int.Parse(Console.ReadLine());
            //int b = int.Parse(Console.ReadLine());
            //int c = Work_1.GetSum(a, b);
            //Helper.PrintResult($"привет, {a} !\n {a} + {b} = {c}\n пока, {b}...");
            //Helper.Line(n);

            //Helper.PrintResult("Введи два целых числа");
            //Helper.PrintResult(Work_1.GetDivisiNumber(Convert.ToInt32(Console.ReadLine()), Convert.ToInt32(Console.ReadLine())));
            //Helper.Line(n);

            //Helper.PrintResult("Введи два слова");
            //Helper.PrintResult(Work_1.SwapPlaces(Convert.ToString(Console.ReadLine()), Convert.ToString(Console.ReadLine())));           
            //Helper.Line(n);

            //Helper.PrintResult("Введи три целых числа: ");
            //Helper.PrintResult(Work_1.DivideDifference(int.Parse(Console.ReadLine()), int.Parse(Console.ReadLine()), int.Parse(Console.ReadLine())));
            //Helper.Line(n);

            //Helper.PrintResult("Введи три целых числа: ");
            //Helper.PrintResult(Work_1.GetRootsDiscriminant(int.Parse(Console.ReadLine()), int.Parse(Console.ReadLine()), int.Parse(Console.ReadLine())));
            //Helper.Line(n);

            //Helper.PrintResult("Приведение типов:  ");

            //Helper.PrintResult("Введи трехзначное целое число");
            //Helper.PrintResult(Work_2.GetSumThreeNumbers(int.Parse(Console.ReadLine())));
            //Helper.Line(n);

            //Helper.PrintResult("Введи два целых числа: ");
            //Helper.PrintResult(Work_2.GetResultShot(int.Parse(Console.ReadLine()), int.Parse(Console.ReadLine())));
            //Helper.Line(n);

            //Helper.PrintResult("Введи трехзначное целое число: ");
            //Helper.PrintResult(Work_2.ThreeNumberWithGetDigits(int.Parse(Console.ReadLine())));
            //Helper.Line(n);

            //Helper.PrintResult("Введи трехзначное целое число: ");
            //Helper.PrintResult(Work_2.ReturnNewThreeNumber(int.Parse(Console.ReadLine())));
            //Helper.Line(n);

            //Helper.PrintResult("Введи дробное число: ");
            //Helper.PrintResult(Work_2.CheckFractionalPart(double.Parse(Console.ReadLine())));
            //Helper.Line(n);

            //Helper.PrintResult("Ветвления:  ");

            //Helper.PrintResult("Введи два целых числа: ");
            //Helper.PrintResult(Work_3.CheckConditionsRavenstAndReturnAnswer(int.Parse(Console.ReadLine()), int.Parse(Console.ReadLine())));
            //Helper.Line(n);

            //Helper.PrintResult("Введи два целых числа");
            //Helper.PrintResult(Work_3.DefineQuarter(int.Parse(Console.ReadLine()), int.Parse(Console.ReadLine())));
            //Helper.Line(n);

            //Helper.PrintResult("Введи три целых числа");
            //Helper.PrintResult(Work_3.GetOutAscendingOrder(int.Parse(Console.ReadLine()), int.Parse(Console.ReadLine()), int.Parse(Console.ReadLine())));
            //Helper.Line(n);

            //Helper.PrintResult("Введи три целых числа");
            //Helper.PrintResult(Work_3.GetAllRootsEquation(int.Parse(Console.ReadLine()), int.Parse(Console.ReadLine()), int.Parse(Console.ReadLine())));
            //Helper.Line(n);

            //Helper.PrintResult("Введи целое двузначное число");
            //Helper.PrintResult(Work_3.GetNumberLetters(int.Parse(Console.ReadLine())));
            //Helper.Line(n);

            //Helper.PrintResult("Введи три целых числа: ");
            //Helper.PrintResult(Work_3.DetermineExistenceTriangle(int.Parse(Console.ReadLine()), int.Parse(Console.ReadLine()), int.Parse(Console.ReadLine())));
            //Helper.Line(n);

            //Helper.PrintResult("Введи три целых числа: ");
            //Helper.PrintResult(Work_3.DeterminePositionPoint(int.Parse(Console.ReadLine()), int.Parse(Console.ReadLine()), int.Parse(Console.ReadLine())));
            //Helper.Line(n);

            //Helper.PrintResult("Циклы:  ");

            //Helper.PrintResult("Введи  целое число: ");                    
            //Console.WriteLine(string.Join(',', Work_4.GetNumbersDividedGivenNumber(Convert.ToInt32(Console.ReadLine()))));
            //Helper.Line(n);


            //Helper.PrintResult("Введи целое число : ");
            //Helper.PrintResult(Work_4.ReturnsNumberPositiveIntegers(int.Parse(Console.ReadLine())));
            //Helper.Line(n);

            //Helper.PrintResult("Введи целое число : ");
            //Helper.PrintResult(Work_4.GetMaxDivisor(int.Parse(Console.ReadLine())));
            //Helper.Line(n);

            //Helper.PrintResult("Введи два целых числа : ");
            //Helper.PrintResult(Work_4.GetSumNumberRange(int.Parse(Console.ReadLine()), int.Parse(Console.ReadLine())));
            //Helper.Line(n);

            //Helper.PrintResult("Введи два целых числа : ");
            //Helper.PrintResult(Work_4.FindCommonMaxFactorUseEuclid(int.Parse(Console.ReadLine()), int.Parse(Console.ReadLine())));
            //Helper.Line(n);

            //Helper.PrintResult("Введи целое число, которое является кубом целого числа N.: ");
            //Helper.PrintResult(Work_4.GetNumberDisectionMethod(int.Parse(Console.ReadLine())));
            //Helper.Line(n);

            //Helper.PrintResult("Введи целое число не меньше восьми знаков : ");
            //Helper.PrintResult(Work_4.FindNumberOddDigitsNumber(int.Parse(Console.ReadLine())));
            //Helper.Line(n);

            //Helper.PrintResult("Введи целое число,не меньше трех знаков : ");
            //Helper.PrintResult(Work_4.ReturnNumberReverse(int.Parse(Console.ReadLine())));
            //Helper.Line(n);

            //Helper.PrintResult("Введи целое число : ");
            //Console.WriteLine(Work_4.GetSumEvenDigitsGreaterSumOddDigits(a));
            //Helper.Line(n);


            //Helper.PrintResult("Введи два целых числа, разных по значению : ");
            //Helper.PrintResult(Work_4.GetSameNumber(int.Parse(Console.ReadLine()), int.Parse(Console.ReadLine())));
            //Helper.Line(n);







        }


    }
}
