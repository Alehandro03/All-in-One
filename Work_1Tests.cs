using NUnit.Framework;
using AllinOne.Tests;
using System;
using System.Collections.Generic;

namespace AllinOne.Tests
{
    public class Work_1Tests
    {
        [TestCase(4, 6, 10)]
        [TestCase(10, 0, 10)]
        [TestCase(10, -5, 5)]
        [TestCase(0, 0, 0)]
        [TestCase(-3, -6, -9)]
        public void GetSumTests(int a, int b, int expected)
        {
            int actual = Work_1.GetSum(a, b);
            Assert.AreEqual(expected, actual);

        }


        [TestCase(5, 2, -13.666666666666666)]
        [TestCase(-7, 1, -4.25)]
        [TestCase(0, 3, 27.0)]
        [TestCase(0, -3, -27.0)]
        [TestCase(-2, -4, -123.0)]

        public void GetDivisiNumberTests(int a, int b, double expected)
        {
            double actual = Work_1.GetDivisiNumber(a, b);
            Assert.AreEqual(expected, actual);
        }

        [Test]

        public void GetDivisiNumberNegativTests()
        {
            //try
            //{
            //    double actual = Work_1.GetDivisiNumber(0, 0);
            //}
            //catch(DivideByZeroException ex)
            //{
            //    Assert.Pass();
            //}
            Assert.Throws<DivideByZeroException>(() => Work_1.GetDivisiNumber(0, 0));
        }


        [TestCase("������", "����", "����, ������")]
        [TestCase("Hello", "By", "By, Hello")]
        [TestCase("123", "321", "321, 123")]
        [TestCase("2d", "1a", "1a, 2d")]
        [TestCase("� � � � � � ", "� � � � ", "� � � � , � � � � � � ")]
        public static void SwapPlacesTests(string s1, string s2, string expected)
        {
            string actual = Work_1.SwapPlaces(s1, s2);
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void SwapPlacesNegativTests()
        {

            Assert.Throws<ArgumentException>(() => Work_1.SwapPlaces("0", "0"));
        }

        [TestCase(2, 10, 2, 4.0)]
        [TestCase(10, 0, 10, -1.0)]
        [TestCase(10, -5, 5, -1.0)]
        [TestCase(1, -2, -3, 1.0)]
        [TestCase(-3, -6, -9, -1.0)]
        public static void DivideDifferenceTests(int a, int b, int c, double expected)
        {
            double actual = Work_1.DivideDifference(a, b, c);
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void DivideDifferenceNegativTests()
        {

            Assert.Throws<DivideByZeroException>(() => Work_1.DivideDifference(0, 0, 0));
        }

        [TestCase(2, 8, 1, "��� �����: -0,5166852264521173, -15,483314773547882")]
        [TestCase(-7, 11, 1, "��� �����: -4,222944655067957, 81,22294465506796")]
        [TestCase(-2, -8, -1, "��� �����: -15,483314773547882, -0,5166852264521173")]
        [TestCase(3, 5, 8, "������ ���")]
        [TestCase(1, 1, 1, "������ ���")]

        public static void GetRootsDiscriminantTests(int a, int b, int c, string expected)
        {
            string actual = Work_1.GetRootsDiscriminant(a, b, c);
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void GetRootsDiscriminanNegativTests()
        {
            Assert.Throws<DivideByZeroException>(() => Work_1.GetRootsDiscriminant(0, 0, 0));
        }

        [TestCase(789, 24)]
        [TestCase(123, 6)]
        [TestCase(222, 6)]
        [TestCase(-123, -6)]
        [TestCase(100, 1)]
        public static void GetSumThreeNumbersTests(int a, int expected)
        {
            int actual = Work_2.GetSumThreeNumbers(a);
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void GetSumThreeNumbersNegativTests2()
        {
            Assert.Throws<ArgumentException>(() => Work_2.GetSumThreeNumbers(1234));
        }

        [TestCase(2, 2, true)]
        [TestCase(0, 0, true)]
        [TestCase(-1, -2, true)]
        [TestCase(132, 2, false)]
        [TestCase(-55, 2, false)]
        public static void GetResultShotTests(int x, int y, bool expected)
        {
            bool actual = Work_2.GetResultShot(x, y);
            Assert.AreEqual(expected, actual);
        }


        [TestCase(123, false)]
        [TestCase(-123, true)]
        [TestCase(321, true)]
        [TestCase(-321, false)]
        [TestCase(555, false)]
        public static void ThreeNumberWithGetDigitsTests(int b, bool expected)
        {
            bool actual = Work_2.ThreeNumberWithGetDigits(b);
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public static void ThreeNumberWithGetDigitsNegativTests()
        {
            Assert.Throws<ArgumentException>(() => Work_2.ThreeNumberWithGetDigits(1234));
        }

        [TestCase(123, 321)]
        [TestCase(-123, -321)]
        [TestCase(555, 555)]
        [TestCase(205, 502)]
        [TestCase(313, 313)]
        public static void ReturnNewThreeNumberTests(int a, int expected)
        {
            int actual = Work_2.ReturnNewThreeNumber(a);
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public static void ReturnNewThreeNumberNegativTests()
        {
            Assert.Throws<ArgumentException>(() => Work_2.ThreeNumberWithGetDigits(1234));
        }

        [TestCase(2.0, "2 (true)")]
        [TestCase(2.5, "2,5 (false)")]
        [TestCase(2.05, "2,05 (false)")]
        [TestCase(25.0, "25 (true)")]
        [TestCase(2.001, "2,001 (false)")]
        public static void CheckFractionalPartTests(double value, string expected)
        {
            string actual = Work_2.CheckFractionalPart(value);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(5, 5, 25)]
        [TestCase(1, 3, -2)]
        [TestCase(0, 0, 0)]
        [TestCase(0, 2, -2)]
        [TestCase(10, 0, 10)]
        public static void CheckConditionsRavenstAndReturnAnswerTests(int a, int b, int expected)
        {
            int actual = Work_3.CheckConditionsRavenstAndReturnAnswer(a, b);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(-5, -5, "����� ����������� ������ ��������")]
        [TestCase(1, 3, "����� ����������� ������ ��������")]
        [TestCase(-2, 0, "����� ����������� ������ ��������")]
        [TestCase(0, 2, "����� ����������� ������ ��������")]
        [TestCase(10, 0, "����� ����������� ������ ��������")]

        public static void DefineQuarterTests(int x, int y, string expected)
        {
            string actual = Work_3.DefineQuarter(x, y);
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public static void DefineQuarterNegativTests()
        {
            Assert.Throws<DivideByZeroException>(() => Work_3.DefineQuarter(0, 0));
        }



        [TestCase(-5, -6, 5, "����� -6 < -5 < 5")]
        [TestCase(1, 3, 12, "����� 1 < 3 < 12")]
        [TestCase(0, 10, 1, "����� 0 < 1 < 10")]
        [TestCase(10, -10, -1, "����� -10 < -1 < 10")]
        [TestCase(-10, -11, -112, "����� -112 < -11 < -10")]
        public static void GetOutAscendingOrderTests(int a, int b, int c, string expected)
        {
            string actual = Work_3.GetOutAscendingOrder(a, b, c);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(1, 1, 2)]
        [TestCase(0, 0, 0)]
        public static void GetOutAscendingOrderNegativTests(int a, int b, int c)
        {
            Assert.Throws<ArgumentException>(() => Work_3.GetOutAscendingOrder(a, b, c));

        }


        [TestCase(-5, -6, 5, "��� �����: -44,1547594742265, 14,154759474226504")]
        [TestCase(1, 3, 12, "������ ���")]
        [TestCase(0, 10, 1, "��� �����: 0, -0")]
        [TestCase(10, -10, -1, "��� �����: 109,16079783099616, -9,160797830996161")]
        [TestCase(-10, -11, -112, "������ ���")]
        public static void GetAllRootsEquationTests(int a, int b, int c, string expected)
        {
            string actual = Work_3.GetAllRootsEquation(a, b, c);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(0, 0, 0)]
        public static void GetAllRootsEquationNegativTests(int a, int b, int c)
        {
            Assert.Throws<DivideByZeroException>(() => Work_3.GetAllRootsEquation(a, b, c));
        }

        [TestCase(10, "������")]
        [TestCase(25, "�������� ����")]
        [TestCase(99, "��������� ������")]
        [TestCase(17, "����������")]
        [TestCase(33, "�������� ���")]
        public static void GetNumberLettersTests(int a, string expected)
        {
            string actual = Work_3.GetNumberLetters(a);
            Assert.AreEqual(expected, actual);
        }


        [TestCase(1)]
        public static void GetNumberLettersNegativTests(int a)
        {
            Assert.Throws<ArgumentException>(() => Work_3.GetNumberLetters(a));
        }


        [TestCase(3, 2, 1, "����������� �� ����������")]
        [TestCase(1, 3, 12, "����������� �� ����������")]
        [TestCase(12, 10, 11, "����������� ����������")]
        [TestCase(100, 200, 300, "����������� �� ����������")]
        [TestCase(5, 7, 6, "����������� ����������")]
        public static void DetermineExistenceTriangleTests(int a, int b, int c, string expected)
        {
            string actual = Work_3.DetermineExistenceTriangle(a, b, c);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(0, 0, 0)]
        [TestCase(-1, 2, -3)]
        public static void DetermineExistenceTriangleNegativTests(int a, int b, int c)
        {
            Assert.Throws<ArgumentException>(() => Work_3.DetermineExistenceTriangle(a, b, c));

        }


        [TestCase(12, 1, 1, " ����� [1; 1]  �� ����������� �������������� ������")]
        [TestCase(1, 1, 1, " ����� [1; 1] ����������� �������������� ������")]
        [TestCase(0, 0, 0, " ����� [0; 0] ����������� �������������� ������")]
        [TestCase(100, 20, 30, " ����� [20; 30]  �� ����������� �������������� ������")]
        [TestCase(5, 7, 6, " ����� [7; 6] ����������� �������������� ������")]
        public static void DeterminePositionPointTests(int Radius, int x, int y, string expected)
        {
            string actual = Work_3.DeterminePositionPoint(Radius, x, y);
            Assert.AreEqual(expected, actual);
        }


        //[TestCase(100, new int[] {100,200,300,400, 500,600,700,800,900,1000})]

        //public static void GetNumbersDividedGivenNumberTests(int a, int[] expected)
        //{
        //   int[] actual = Work_4.GetNumbersDividedGivenNumber(a);
        //    Assert.AreEqual(expected, actual);
        //}


        [TestCase(1000, 31)]
        [TestCase(2, 1)]
        [TestCase(10, 3)]
        [TestCase(50, 7)]
        [TestCase(125, 11)]
        public static void ReturnsNumberPositiveIntegersTests(int a, int expected)
        {
            int actual = Work_4.ReturnsNumberPositiveIntegers(a);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(0)]
        public static void ReturnsNumberPositiveIntegersNegativTests(int a)
        {
            Assert.Throws<ArgumentException>(() => Work_4.ReturnsNumberPositiveIntegers(a));

        }


        [TestCase(1000, 500)]
        [TestCase(4, 2)]
        [TestCase(10, 5)]
        [TestCase(50, 25)]
        [TestCase(2, 0)]
        public static void GetMaxDivisorTests(int a, int expected)
        {
            int actual = Work_4.GetMaxDivisor(a);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(0)]
        public static void GetMaxDivisorNegativTests(int a)
        {
            Assert.Throws<ArgumentException>(() => Work_4.GetMaxDivisor(a));

        }


        [TestCase(1000, 500, 53179)]
        [TestCase(1, 1, 0)]
        [TestCase(10, 10, 0)]
        [TestCase(50, 0, 196)]
        [TestCase(0, 7, 7)]

        public static void GetSumNumberRangeTests(int a, int b, int expected)
        {
            int actual = Work_4.GetSumNumberRange(a, b);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(0, 0)]
        public static void GetSumNumberRangeNegativTests(int a, int b)
        {
            Assert.Throws<ArgumentException>(() => Work_4.GetSumNumberRange(a, b));

        }


        [TestCase(12, 1, "���������� ����� �������� - 1")]
        [TestCase(1, 1, "���������� ����� �������� - 1")]
        [TestCase(31, 11, "���������� ����� �������� - 1")]
        [TestCase(100, 20, "���������� ����� �������� - 20")]
        [TestCase(5, 7, "���������� ����� �������� - 1")]
        public static void FindCommonMaxFactorUseEuclidTests(int a, int b, string expected)
        {
            string actual = Work_4.FindCommonMaxFactorUseEuclid(a, b);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(0, 0)]
        public static void FindCommonMaxFactorUseEuclidNegativTests(int a, int b)
        {
            Assert.Throws<ArgumentException>(() => Work_4.FindCommonMaxFactorUseEuclid(a, b));

        }


        [TestCase(1000, 9)]
        [TestCase(16, 2)]
        [TestCase(125, 5)]
        [TestCase(27, 3)]
        [TestCase(88, 3)]
        public static void GetNumberDisectionMethodTests(int a, int expected)
        {
            int actual = Work_4.GetNumberDisectionMethod(a);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(0)]
        public static void GetNumberDisectionMethodNegativTests(int a)
        {
            Assert.Throws<ArgumentException>(() => Work_4.GetNumberDisectionMethod(a));

        }

        [TestCase(122313, "���������� �� ������ ���� � ����� 122313 ����� 4 ")]
        [TestCase(888888, "���������� �� ������ ���� � ����� 888888 ����� 0 ")]
        [TestCase(11111111, "���������� �� ������ ���� � ����� 11111111 ����� 8 ")]
        [TestCase(9999999, "���������� �� ������ ���� � ����� 9999999 ����� 7 ")]
        [TestCase(2468, "���������� �� ������ ���� � ����� 2468 ����� 0 ")]
        public static void FindNumberOddDigitsNumberTest(int value, string expected)
        {
            string actual = Work_4.FindNumberOddDigitsNumber(value);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(0)]
        public static void FindNumberOddDigitsNumberNegativTests(int a)
        {
            Assert.Throws<ArgumentException>(() => Work_4.FindNumberOddDigitsNumber(a));

        }


        [TestCase(123, 321)]
        [TestCase(666, 666)]
        [TestCase(112, 211)]
        [TestCase(132, 231)]
        [TestCase(1234, 4321)]
        public static void ReturnNumberReverseTests(int value, int expected)
        {
            int actual = Work_4.ReturnNumberReverse(value);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(0)]
        public static void ReturnNumberReverseNegativTests(int a)
        {
            Assert.Throws<ArgumentException>(() => Work_4.ReturnNumberReverse(a));
        }

        //[TestCase(12, new Lust<int> { 2, 4, 6, 8, 12, 14 })]

        //public static void GetSumEvenDigitsGreaterSumOddDigitsTests(int value, List<int> expected)
        //{
        //    List<int> actual = Work_4.GetSumEvenDigitsGreaterSumOddDigits(value);
        //    Assert.AreEqual(expected, actual);
        //}


        [TestCase(132, 456, false)]
        [TestCase(1234, 45678, true)]
        public static void GetSameNumberTests(int a, int b, bool expected)
        {
            bool actual = Work_4.GetSameNumber(a, b);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(0, 0)]
        public static void GetSameNumberNegativNegativTests(int a, int b)
        {
            Assert.Throws<ArgumentException>(() => Work_4.GetSameNumber(a, b));
        }

        [TestCase(132, "����������� ������ ��������� �������: 6. ����������� ��������: 4 ")]
        [TestCase(12, "����������� ������ ��������� �������: 6. ����������� ��������: 4 ")]
        public static void CountNumberOddAndEvenElementsArrayTests(int value, string expected)
        {
            string actual = Work_5.CountNumberOddAndEvenElementsArray(value);
            Assert.AreEqual(expected, actual);
        }
        [TestCase()]
        public static void CountNumberOddAndEvenElementsArrayNegativTests()
        {
            Assert.Throws<NotImplementedException>(() => Work_5.CountNumberOddAndEvenElementsArray(null));
        }


        [TestCase(5, new int[] { 5, 20, 25, 14, 5, 19, 8, 2, 10, 7 })]
        [TestCase(0, new int[] { 0, 20, 20, 14, 5, 19, 8, 2, 10, 7 })]
        [TestCase(10, new int[] { 10, 20, 30, 14, 5, 19, 8, 2, 10, 7 })]
        [TestCase(-5, new int[] { -5, 20, 15, 14, 5, 19, 8, 2, 10, 7 })]
        [TestCase(-20, new int[] { -20, 20, 0, 14, 5, 19, 8, 2, 10, 7 })]

        public static void ReplaceThirdElementSumTwoNumbersTests(int value, int[] expected)
        {
            int[] actual = Work_5.ReplaceThirdElementSumTwoNumbers(value);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(5, 10, "5 20 13 14 5 6 8 2 45 7 10 28 14 114 6")]
        [TestCase(1, 2, "1 20 13 14 5 6 8 2 45 7 2 28 14 114 6")]
        [TestCase(10, 15, "10 20 13 14 5 6 8 2 45 7 15 28 14 114 6")]
        [TestCase(-5, -20, "-5 20 13 14 5 6 8 2 45 7 -20 28 14 114 6")]

        public static void ConnectTwoArrayTests(int a, int b, string expected)
        {
            string actual = Work_5.ConnectTwoArray(a, b);
            Assert.AreEqual(expected, actual);
        }

        [TestCase()]
        public static void ConnectTwoArrayNegativTests()
        {
            Assert.Throws<DivideByZeroException>(() => Work_5.ConnectTwoArray(0, 0));
        }


        [TestCase(5, "8 2 45 7 5 6 5 20 13 14 5")]
        [TestCase(1, "8 2 45 7 5 6 1 20 13 14 5")]
        [TestCase(10, "8 2 45 7 5 6 10 20 13 14 5")]
        [TestCase(-5, "8 2 45 7 5 6 -5 20 13 14 5")]
        public static void SwapHalvesArrayTests(int value, string expected)
        {
            string actual = Work_5.SwapHalvesArray(value);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(5, 1, "5 5 20 13 14 6 8 2 45 7 5")]
        [TestCase(1, 3, "1 20 13 14 5 6 8 2 45 7 5")]
        [TestCase(10, 5, "6 8 2 45 7 10 20 13 14 5 5")]
        public static void CycleArrayRightOneElementTests(int a, int k, string expected)
        {
            string actual = Work_5.CycleArrayRightOneElement(a, k);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(5, "20 5 14 13 6 5 2 8 7 45 5")]
        [TestCase(1, "20 1 14 13 6 5 2 8 7 45 5")]
        [TestCase(10, "20 10 14 13 6 5 2 8 7 45 5")]
        public static void SwapOddAndEvenNumbersIntoArrayTests(int a, string expected)
        {
            string actual = Work_5.SwapOddAndEvenNumbersIntoArray(a);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(5, "����������� �� ������ ������� 0\t " +
                "C���� ���������, ������������� ����� ������� �������� �������� 54")]
        [TestCase(1, "����������� �� ������ ������� 0\t " +
                "C���� ���������, ������������� ����� ������� �������� �������� 50")]
        [TestCase(10, "����������� �� ������ ������� 0\t " +
                "C���� ���������, ������������� ����� ������� �������� �������� 59")]
        public static void CalculateModulusAndSumElementsAfterZeroTests(int a, string expected)
        {
            string actual = Work_5.CalculateModulusAndSumElementsAfterZero(a);
            Assert.AreEqual(expected, actual);
        }


        [TestCase(5, "-45 -20 -5 0 2 5 5 7 8 13 14")]
        [TestCase(1, "-45 -20 -5 0 1 2 5 7 8 13 14")]
        [TestCase(10, "-45 -20 -5 0 2 5 7 8 10 13 14")]
        public static void SortArrayUpInsertTests(int a, string expected)
        {
            string actual = Work_5.SortArrayUpInsert(a);
            Assert.AreEqual(expected, actual);
        }


        [TestCase(5, "14 13 8 7 5 5 2 0 -5 -20 -45")]
        [TestCase(1, "14 13 8 7 5 2 1 0 -5 -20 -45")]
        [TestCase(10, "14 13 10 8 7 5 2 0 -5 -20 -45")]
        public static void SortArrayDownSelectTests(int a, string expected)
        {
            string actual = Work_5.SortArrayDownSelect(a);
            Assert.AreEqual(expected, actual);
        }


        public int[,] FirstReverseSignMock()
        {
            return new int[5, 5]
            {
                { -1,-1,-1,-1,-1 },
                { -1,1,1,1,-1 },
                { -1,1,1,1,-1 },
                { -1,1,1,1,-1 },
                { -1,-1,-1,-1,-1 }
            };
        }

        [Test]
        public void FirstReverseSignTest()
        {
            int[,] expected = FirstReverseSignMock();
            int[,] actual = Work_6.SwapSignsOppositeAlongEdgesArray(new int[,] { { 1,1,1,1,1 },
                { 1,1,1,1,1 },
                { 1,1,1,1,1 },
                { 1,1,1,1,1 },
                { 1,1,1,1,1 } });
            Assert.AreEqual(expected, actual);
        }

        public int[,] SecondMultiTableMock()
        {
            return new int[10, 10]
            {
                {0,0,0,0,0,0,0,0,0,0 },
                {0,1,2,3,4,5,6,7,8,9 },
                {0,2,4,6,8,10,12,14,16,18 },
                {0,3,6,9,12,15,18,21,24,27 },
                {0,4,8,12,16,20,24,28,32,36 },
                {0,5,10,15,20,25,30,35,40,45 },
                {0,6,12,18,24,30,36,42,48,54 },
                {0,7,14,21,28,35,42,49,56,63 },
                {0,8,16,24,32,40,48,56,64,72 },
                {0,9,18,27,36,45,54,63,72,81 }
            };
        }

        [Test]
        public void SecondMultiTableTest()
        {
            int[,] expected = SecondMultiTableMock();
            int[,] actual = Work_6.FillMultiplicationTable(new int[10, 10]);
            Assert.AreEqual(expected, actual);
        }


        public int[,] ThirdChessBoardMock1()
        {
            return new int[,]
            {
                {1,0,1,0,1,0,1,0 },
                {0,1,0,1,0,1,0,1 },
                {1,0,1,0,1,0,1,0 },
                {0,1,0,1,0,1,0,1 },
                {1,0,1,0,1,0,1,0 },
                {0,1,0,1,0,1,0,1 },
                {1,0,1,0,1,0,1,0 },
                {0,1,0,1,0,1,0,1 },
            };
        }

        [Test]
        public void ThirdChessBoardTest()
        {
            int[,] expected = ThirdChessBoardMock1();
            int[,] actual = Work_6.FillMatrixLikeCheckerboard(new int[8, 8],8,8);
            Assert.AreEqual(expected, actual);
        }

        public int[,] ThirdChessBoardMock2()
        {
            return new int[,]
            {
                {0,1,0,1,0,1,0,1,0 },
                {1,0,1,0,1,0,1,0,1 },
                {0,1,0,1,0,1,0,1,0 },
                {1,0,1,0,1,0,1,0,1 },
                {0,1,0,1,0,1,0,1,0 },
                {1,0,1,0,1,0,1,0,1 },
                {0,1,0,1,0,1,0,1,0 },
                {1,0,1,0,1,0,1,0,1 },
                {0,1,0,1,0,1,0,1,0 },
            };
        }

        [Test]
        public void ThirdChessBoardTest2()
        {
            int[,] expected = ThirdChessBoardMock2();
            int[,] actual = Work_6.FillMatrixLikeCheckerboard(new int[9, 9], 9, 9);
            Assert.AreEqual(expected, actual);
        }


        [TestCase("����� �� ��� ������ �� ������� ��������:32511, 41267, 25385, 30700, 20029, 33741, 28769, 35470, 21365, 28624"+
            "\n������� ����� �� ������� ������: 5418, 6877, 4230, 5116, 3338, 5623, 4794, 5911, 3560, 4770" +
            "\n���.� ����. ����� �� ���� ������-min-77, max-9568")]
        public static void CalculateAmountAverageIncome(string expected)
        {
            string actual = Work_6.CalculateAmountAverageIncome(new int[,]{{5658,8463,6833,1827,5902,3828},{5627,6169,7162,6191,9376,6742 },
                { 840,283,9445,4027,3398,7392 },{6778,4527,2240,1097,7416,8642},{4681,77,4231,1376 ,2533,7131},{3424 ,9568,5699,1754,4221,9075},
                {4428 ,3997 ,295,7121 ,7702,5226 },{5071,2768,7427, 8784,8589,2831},{1506,5161,4554,820,189 , 9135},{1856,4560,1046,8191,7146,5825}});

            Assert.AreEqual(expected, actual);

        }



        [TestCase(0,1, "�������� �� �������� �������� ���")]
        [TestCase(4,3, "�������� �� �������� �������� ���")]
        [TestCase(3, 1, "�������� �� �������� �������� ���")]
        public static void CheckCovidRulesTests(int a,int b, string expected)
        {
            string actual = Work_6.CheckCovidRules(a,b);
            Assert.AreEqual(expected, actual);
        }



        [TestCase(0)]
        public void FindNumberAllNeighborsSameTimeTests(int expected)
        {
            int actual = Work_6.FindNumberAllNeighborsSameTime(new int[,]{ { 1, 2, 3, 4, 5 },{ 3, 4, 1, 4, 2 }, { 3, 5, 7, 4, 2 }, { 1, 3, 6, 4, 2 },{ 4, 5, 2, 5, 2} });
            Assert.AreEqual(expected, actual);
        }

        [TestCase(3)]
        public void FindNumberAllNeighborsSameTimeTests2(int expected)
        {
            int actual = Work_6.FindNumberAllNeighborsSameTime(new int[,]{ { 1, 2, 45, 4, 5 },{ 3,4,100,4,2 }, { 3,98,7,4,2 }, { 1,3,6,74,2 },
            { 4,5,2,5,2} });
            Assert.AreEqual(expected, actual);
        }

        public int[,] FillCharArrayFromPictureMock()
        {
            return new int[7, 7]
            {
                {1,1,1,1,1,1,1 },
                {0,1,1,1,1,1,0 },
                {0,0,1,1,1,0,0 },
                {0,0,0,1,0,0,0 },
                {0,0,1,1,1,0,0 },
                {0,1,1,1,1,1,0 },
                {1,1,1,1,1,1,1 }
            };
        }

        [Test]
        public void FillCharArrayFromPictureTest()
        {
            int[,] expected = FillCharArrayFromPictureMock();
            int[,] actual = Work_6.FillCharArrayFromPicture(new int[7, 7]);
            Assert.AreEqual(expected, actual);
        }


        public int[,] EighthMatrixMultiplicationMock1()
        {
            return new int[,]
            {
                { 62,  96 },{82, 130 },{95, 138 }
            };
        }
      

        [Test]
        public void ImplementMatrixMultiplicationIntegersTests()
        {
            int[,] expected = EighthMatrixMultiplicationMock1();
            int[,] actual = Work_6.ImplementMatrixMultiplicationIntegers(new int[3, 4]{
                    { 2, 4, 5, 7 },
                    { 7, 3, 7, 8 },
                    { 7, 8, 9, 4 }},
            new int[4, 2]{
                    { 2, 4 },
                    { 3, 4 },
                    { 5, 6 },
                    { 3, 6 } },
            new int[,] { { 1, 2 }, { 2, 3 } });
            Assert.AreEqual(expected, actual);
        }











    }
}