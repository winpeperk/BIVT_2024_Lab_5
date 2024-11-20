using Microsoft.VisualStudio.TestPlatform.TestHost;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using static Program;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Tests
{
    [TestClass()]
    public class ProgramTests
    {
        Program main = new Program();

        int[,] matrix7x4 = new int[,] {
            { 1, 2, 3, 4 },
            { 5, 5, 4, 6 },
            { 5, -5, 5, -5 },
            { 6, 7, 8, 9 },
            { -6, -5, -8, 0 },
            { 11, 12, 13, 14 },
            { 6, 5, 8, 0 }};
        int[,] matrix3x5 = new int[,] {
            { 1, 2, 3, 4, 5 },
            { 6, 7, 8, 9, 10 },
            { 11, 12, 13, 14, 15 } };
        int[,] matrix4x5 = new int[,] {
            { 1, 2, 3, 4, 5 },
            { 6, 7, 8, 9, 10 },
            { -11, 12, 13, 14, -15 },
            { 6, 7, 8, 9, 0 }};
        int[,] matrix5x5 = new int[,] {
            { 1, 2, 3, 4, 5 },
            { 6, 7, 8, 9, 10 },
            { 11, 12, 13, 14, 15 },
            { -1, -2, -3, -4, -5 },
            { 6, 7, 8, 9, 0 }};
        int[,] matrix6x5 = new int[,] {
            { 1, 2, 3, 4, 5 },
            { 6, 7, 8, 9, 10 },
            { 11, 12, 13, 14, 15 },
            { -1, -2, -3, -4, -5 },
            { 0, 1, 0, 2, 0 },
            { 6, 7, 8, 9, 0 }};
        int[,] matrix4x6 = new int[,] {
            { 1, 2, 3, 4, 5, -1 },
            { 6, 7, 8, 9, 10, -2 },
            { -1, -2, -3, -4, -5, -1 },
            { 6, 7, 8, 9, 0, -2 }};
        int[,] matrix5x6 = new int[,] {
            { 1, 2, 3, 4, 5, -1 },
            { 6, 7, 8, 9, 10, -2 },
            { 11, 12, 13, 14, 15, -3 },
            { -1, -2, -3, -4, -5, -1 },
            { 6, 7, 8, 9, 0, -2 }};
        int[,] matrix6x6 = new int[,] {
            { 1,    2,  3,  4,  5,  -1 },
            { 6,    7,  8,  9,  10, -2 },
            { 11,   12, 13, 14, 15, -3 },
            { -1,   -2, -3, -4, -5, -1 },
            { 6,    7,  8,  9,  20, -2 },
            { 1,    3,  3,  1,  5, 5 }};
        int[] arr7 = new int[] { 1, 2, 13, 4, -5, 6, 7 };
        int[] arr8 = new int[] { 1, 8, -3, 5, -5, 1, 0, 4 };
        int[] arr9 = new int[] { 1, 12, 3, 4, 5, -6, 7, 0, 9 };
        int[] arr10 = new int[] { 1, -8, -3, 5, -5, 1, 0, -4, -1, 2 };
        int[] arr11 = new int[] { 1, 12, 13, 0, 9, 1, 5, -6, 7, 12, 14 };
        double[] array7 = new double[] { 1, 2, 13, 4, -5, 6, 7 };
        double[] array8 = new double[] { 1, 8, -3, 5, -5, 1, 0, 4 };
        double[] array9 = new double[] { 1, 12, 3, 4, 5, -6, 7, 0, 9 };

        [TestMethod()]
        public void Task_4Test()
        {
            double[,] matrix = {
            {2, 1, -1},
            {1, -1, 1},
            {-1, 1, 2}};
            double[,] matrix2 = {
            {5, 1, 2, 1},
            {1, 6, 2, 3},
            {2, 2, 7, 2},
            {1, 3, 2, 8}};
            double[,] matrix3 = {
            {1, 2, 3, 4, 5},
            {6, 7, 8, 9, 10},
            {11, 12, 13, 14, 15},
            {16, 17, 18, 19, 20},
            {21, 22, 23, 24, 25}};

            main.Task_4(matrix, new int[] { 12, 13, 14 });
        }

        [TestMethod()]
        public void Task_1_1Test()
        {
            // Arrange
            const int len = 10;
            int[] n = new int[len] { 1, 2, 3, 4, 4, 4, 4, 4, 0, -1 };
            int[] k = new int[len] { 0, 1, 1, 2, 3, 4, 5, -1, 0, 1 };
            long[] actual = new long[len];
            long[] expected = new long[len] { 1, 2, 3, 6, 4, 1, 0, 0, 0, 0 };
            // Act
            for (int i = 0; i < len; i++)
                actual[i] = main.Task_1_1(n[i], k[i]);
            // Assert
            for (int i = 0; i < len; i++)
                Assert.AreEqual(expected[i], actual[i]);
        }

        [TestMethod()]
        public void Task_1_2Test()
        {
            // Arrange
            const int len = 3;
            double[] a = new double[len] { 1, 1.5, 1 };
            double[] b = new double[len] { 1, 1.75, 1 };
            double[] c = new double[len] { 1.25, 1.25, 2.5 };
            double[] actual = new double[len * len * len];
            double[] expected = new double[len * len * len] {
                0, 2, -1, 2, 2, 1, 0, 2, -1,
                1, 1, -1, 1, 0, 1, 1, 1, -1,
                -1, 2, -1, -1, 2, -1, -1, 2, -1 };
            // Act
            int count = 0;
            for (int i = 0; i < len; i++)
                for (int j = 0; j < len; j++)
                    for (int k = 0; k < len; k++, count++)
                        actual[count] = main.Task_1_2(new double[] { a[i], b[j], c[k] }, new double[] { c[i], a[j], b[k] });
            // Assert
            for (int i = 0; i < len * len * len; i++)
                Assert.AreEqual(expected[i], actual[i], 0.00005);
        }

        [TestMethod()]
        public void Task_1_3aTest()
        {
            // Arrange
            const int len = 3;
            double[] v = new double[len] { 10, 9.5, 9 };
            double[] a = new double[len] { 1, 1.5, 1.6 };
            int[] t = new int[len] { 1, 4, 6 };
            double[] actual = new double[len * len * len];
            double[] expected = new double[len * len * len] {
                0, 0, 0, 1, 2, 2, 1, 2, 2,
                2, 1, 1, 0, 0, 0, 1, 1, 1,
                2, 1, 1, 2, 2, 2, 0, 0, 0 };
            // Act
            int count = 0;
            for (int i = 0; i < len; i++)
                for (int j = 0; j < len; j++)
                    for (int k = 0; k < len; k++, count++)
                        actual[count] = main.Task_1_3a(v[i], a[i], v[j], a[j], t[k]);
            // Assert
            for (int i = 0; i < len * len * len; i++)
                Assert.AreEqual(expected[i], actual[i], 0.00005);
        }

        [TestMethod()]
        public void Task_1_3bTest()
        {
            // Arrange
            const int len = 3;
            double[] v = new double[len] { 10, 9.5, 9 };
            double[] a = new double[len] { 1, 1.5, 1.6 };
            int[] actual = new int[len * len];
            int[] expected = new int[len * len] {
                1, 2, 4, 1, 1, 10, 1, 1, 1};
            // Act
            int count = 0;
            for (int i = 0; i < len; i++)
                for (int j = 0; j < len; j++, count++)
                    actual[count] = main.Task_1_3b(v[i], a[i], v[j], a[j]);
            // Assert
            for (int i = 0; i < len * len; i++)
                Assert.AreEqual(expected[i], actual[i], 0.00005);
        }

        [TestMethod()]
        public void Task_2_1Test()
        {
            // Arrange
            int[,] A = new int[5, 6], B = new int[3, 5];
            int[,] answerA = new int[5, 6], answerB = new int[3, 5];
            Array.Copy(matrix5x6, A, A.LongLength);
            Array.Copy(matrix3x5, B, B.LongLength);
            Array.Copy(matrix5x6, answerA, answerA.LongLength);
            Array.Copy(matrix3x5, answerB, answerB.LongLength);
            int temp = answerB[2, 4];
            answerB[2, 4] = answerA[2, 4];
            answerA[2, 4] = temp;
            // Act
            main.Task_2_1(A, B);
            // Assert
            Assert.AreEqual(answerA.GetLength(0), A.GetLength(0));
            Assert.AreEqual(answerA.GetLength(1), A.GetLength(1));
            Assert.AreEqual(answerB.GetLength(0), B.GetLength(0));
            Assert.AreEqual(answerB.GetLength(1), B.GetLength(1));
            for (int i = 0; i < A.GetLength(0); i++)
                for (int j = 0; j < A.GetLength(1); j++)
                    Assert.AreEqual(answerA[i, j], A[i, j]);
            for (int i = 0; i < B.GetLength(0); i++)
                for (int j = 0; j < B.GetLength(1); j++)
                    Assert.AreEqual(answerB[i, j], B[i, j]);
        }

        [TestMethod()]
        public void Task_2_2Test()
        {
            // Arrange
            double[] A = new double[7], B = new double[9];
            double[] C = new double[7], D = new double[9];
            double[] answerA = new double[7] { 1, 2, 13, 4, -5, 6, 7 };
            double[] answerB = new double[9] { 1, 3.142857142857143, 3, 4, 5, -6, 7, 0, 9 };
            double[] answerC = new double[7] { 7, 6, -5, 4, 1.5, 2, 1 };
            double[] answerD = new double[9] { 9, 0, 7, -6, 5, 4, 3, 12, 1 };
            Array.Copy(array7, A, A.Length);
            Array.Copy(array9, B, B.Length);
            Array.Copy(array7, C, C.Length);
            Array.Copy(array9, D, D.Length);
            Array.Reverse(C);
            Array.Reverse(D);
            // Act
            main.Task_2_2(A, B);
            main.Task_2_2(C, D);
            // Assert
            Assert.AreEqual(answerA.Length, A.Length);
            Assert.AreEqual(answerB.Length, B.Length);
            Assert.AreEqual(answerC.Length, C.Length);
            Assert.AreEqual(answerD.Length, D.Length);
            for (int i = 0; i < A.Length; i++)
                Assert.AreEqual(A[i], answerA[i]);
            for (int i = 0; i < B.Length; i++)
                Assert.AreEqual(B[i], answerB[i]);
            for (int i = 0; i < C.Length; i++)
                Assert.AreEqual(C[i], answerC[i]);
            for (int i = 0; i < D.Length; i++)
                Assert.AreEqual(D[i], answerD[i]);
        }

        [TestMethod()]
        public void Task_2_3Test()
        {
            // Arrange
            int[,] B = new int[5, 5], C = new int[6, 6];
            int[,] answerB = new int[4, 5] {
            { 1, 2, 3, 4, 5 },
            { 6, 7, 8, 9, 10 },
            { -1, -2, -3, -4, -5 },
            { 6, 7, 8, 9, 0 }};
            int[,] answerC = new int[5, 6] {
            { 1, 2, 3, 4, 5, -1 },
            { 6, 7, 8, 9, 10, -2 },
            { 11, 12, 13, 14, 15, -3 },
            { -1, -2, -3, -4, -5, -1 },
            { 1, 3, 3, 1, 5, 5 }};
            Array.Copy(matrix5x5, B, B.LongLength);
            Array.Copy(matrix6x6, C, C.LongLength);
            // Act
            main.Task_2_3(ref B, ref C);
            // Assert
            Assert.AreEqual(answerB.GetLength(0), B.GetLength(0));
            Assert.AreEqual(answerB.GetLength(1), B.GetLength(1));
            Assert.AreEqual(answerC.GetLength(0), C.GetLength(0));
            Assert.AreEqual(answerC.GetLength(1), C.GetLength(1));
            for (int i = 0; i < B.GetLength(0); i++)
                for (int j = 0; j < B.GetLength(1); j++)
                    Assert.AreEqual(answerB[i, j], B[i, j]);
            for (int i = 0; i < C.GetLength(0); i++)
                for (int j = 0; j < C.GetLength(1); j++)
                    Assert.AreEqual(C[i, j], answerC[i, j]);
        }

        [TestMethod()]
        public void Task_2_4Test()
        {
            // Arrange
            int[,] A = new int[5, 5], B = new int[5, 5];
            int[,] answerA = new int[,] {
            { 1, 2, 3, 4, 5 },
            { 6, 7, 8, 9, 10 },
            { 3, 8, 13, -3, 8 },
            { -1, -2, -3, -4, -5 },
            { 6, 7, 8, 9, 0 }};
            int[,] answerB = new int[5, 5] {
            { 1, 2, 11, 4, 5 },
            { 6, 7, 12, 9, 10 },
            { 11, 12, 13, 14, 15 },
            { -1, -2, 14, -4, -5 },
            { 6, 7, 15, 9, 0 }};
            Array.Copy(matrix5x5, A, A.LongLength);
            Array.Copy(matrix5x5, B, B.LongLength);
            // Act
            main.Task_2_4(A, B);
            // Assert
            Assert.AreEqual(answerA.GetLength(0), A.GetLength(0));
            Assert.AreEqual(answerA.GetLength(1), A.GetLength(1));
            Assert.AreEqual(answerB.GetLength(0), B.GetLength(0));
            Assert.AreEqual(answerB.GetLength(1), B.GetLength(1));
            for (int i = 0; i < A.GetLength(0); i++)
                for (int j = 0; j < A.GetLength(1); j++)
                    Assert.AreEqual(answerA[i, j], A[i, j]);
            for (int i = 0; i < B.GetLength(0); i++)
                for (int j = 0; j < B.GetLength(1); j++)
                    Assert.AreEqual(answerB[i, j], B[i, j]);
        }

        [TestMethod()]
        public void Task_2_5Test()
        {
            // Arrange
            int[,] A = new int[4, 6], B = new int[6, 6];
            int[,] answerA = new int[4, 6] {
            { 1, 2, 3, 4, 5, -1 },
            { 11, 12, 13, 14, 15, -3 },
            { -1, -2, -3, -4, -5, -1 },
            { 6, 7, 8, 9, 0, -2 }};
            int[,] answerB = new int[6, 6] {
            { 1, 2, 3, 4, 5, -1 },
            { 6, 7, 8, 9, 10, -2 },
            { 6, 7, 8, 9, 10, -2 },
            { -1, -2, -3, -4, -5, -1 },
            { 6, 7, 8, 9, 20, -2 },
            { 1, 3, 3, 1, 5, 5 }};
            Array.Copy(matrix4x6, A, A.LongLength);
            Array.Copy(matrix6x6, B, B.LongLength);
            // Act
            main.Task_2_5(A, B);
            // Assert
            Assert.AreEqual(answerA.GetLength(0), A.GetLength(0));
            Assert.AreEqual(answerA.GetLength(1), A.GetLength(1));
            Assert.AreEqual(answerB.GetLength(0), B.GetLength(0));
            Assert.AreEqual(answerB.GetLength(1), B.GetLength(1));
            for (int i = 0; i < A.GetLength(0); i++)
                for (int j = 0; j < A.GetLength(1); j++)
                    Assert.AreEqual(answerA[i, j], A[i, j]);
            for (int i = 0; i < B.GetLength(0); i++)
                for (int j = 0; j < B.GetLength(1); j++)
                    Assert.AreEqual(answerB[i, j], B[i, j]);
        }

        [TestMethod()]
        public void Task_2_6Test()
        {
            // Arrange
            int[] A = new int[7], B = new int[8];
            int[] C = new int[7], D = new int[8];
            int[] answerAB = new int[13] { 1, 2, 4, -5, 6, 7, 1, -3, 5, -5, 1, 0, 4 }, answerCD = new int[13];
            Array.Copy(arr7, A, A.Length);
            Array.Copy(arr8, B, B.Length);
            var rand = new Random();
            for (int i = 0; i < C.Length; i++)
            {
                C[i] = rand.Next(100);
            }
            for (int i = 0; i < D.Length; i++)
            {
                D[i] = rand.Next(100);
            }
            int i1 = Array.IndexOf(C, C.Max());
            int i2 = Array.IndexOf(D, D.Max());
            int k = 0;
            for (int i = 0; i < C.Length - 1; i++, k++)
            {
                if (i < i1) answerCD[k] = C[i];
                else answerCD[k] = C[i + 1];
            }
            for (int i = 0; i < D.Length - 1; i++, k++)
            {
                if (i < i2) answerCD[k] = D[i];
                else answerCD[k] = D[i + 1];
            }
            // Act
            main.Task_2_6(ref A, B);
            main.Task_2_6(ref C, D);
            // Assert
            Assert.AreEqual(A.Length, answerAB.Length);
            Assert.AreEqual(C.Length, answerCD.Length);
            for (int i = 0; i < A.Length; i++)
                Assert.AreEqual(A[i], answerAB[i]);
            for (int i = 0; i < C.Length; i++)
                Assert.AreEqual(C[i], answerCD[i]);
        }

        [TestMethod()]
        public void Task_2_7Test()
        {
            // Arrange
            int[,] B = new int[4, 5], C = new int[5, 6];
            int[,] answerB = new int[5, 5] {
            { 1, 2, 3, 4, 5 },
            { 1, 6, 11, -1, 6 },
            { 6, 7, 8, 9, 10 },
            { -11, 12, 13, 14, -15 },
            { 6, 7, 8, 9, 0 }};
            int[,] answerC = new int[5, 6] {
            { 1, 2, 3, 4, 5, -1 },
            { 6, 7, 8, 9, 10, -2 },
            { 11, 12, 13, 14, 15, -3 },
            { -1, -2, -3, -4, -5, -1 },
            { 6, 7, 8, 9, 0, -2 }};
            Array.Copy(matrix4x5, B, B.LongLength);
            Array.Copy(matrix5x6, C, C.LongLength);
            // Act
            main.Task_2_7(ref B, C);
            // Assert
            Assert.AreEqual(answerB.GetLength(0), B.GetLength(0));
            Assert.AreEqual(answerB.GetLength(1), B.GetLength(1));
            Assert.AreEqual(answerC.GetLength(0), C.GetLength(0));
            Assert.AreEqual(answerC.GetLength(1), C.GetLength(1));
            for (int i = 0; i < B.GetLength(0); i++)
                for (int j = 0; j < B.GetLength(1); j++)
                    Assert.AreEqual(answerB[i, j], B[i, j]);
            for (int i = 0; i < C.GetLength(0); i++)
                for (int j = 0; j < C.GetLength(1); j++)
                    Assert.AreEqual(C[i, j], answerC[i, j]);
        }

        [TestMethod()]
        public void Task_2_8Test()
        {
            // Arrange
            int[] A = new int[9], B = new int[11];
            int[] C = new int[9], D = new int[11];
            int[] answerA = new int[] { 1, 12, -6, 0, 3, 4, 5, 7, 9 };
            int[] answerB = new int[] { 1, 12, 13, 0, 9, 1, 5, -6, 7, 12, 14 };
            int[] answerC = new int[9], answerD = new int[11];
            Array.Copy(arr9, A, A.Length);
            Array.Copy(arr11, B, B.Length);
            var rand = new Random();
            for (int i = 0; i < C.Length; i++)
            {
                C[i] = rand.Next(100);
            }
            for (int i = 0; i < D.Length; i++)
            {
                D[i] = rand.Next(100);
            }
            int i1 = Array.IndexOf(C, C.Max());
            int i2 = Array.IndexOf(D, D.Max());

            Array.Copy(C, answerC, C.Length);
            Array.Copy(D, answerD, D.Length);
            Array.Sort(answerC, i1 + 1, C.Length - i1 - 1);
            Array.Sort(answerD, i2 + 1, D.Length - i2 - 1);
            // Act
            main.Task_2_8(A, B);
            main.Task_2_8(C, D);
            // Assert
            Assert.AreEqual(answerA.Length, A.Length);
            Assert.AreEqual(answerB.Length, B.Length);
            Assert.AreEqual(answerC.Length, C.Length);
            Assert.AreEqual(answerD.Length, D.Length);
            for (int i = 0; i < A.Length; i++)
                Assert.AreEqual(A[i], answerA[i]);
            for (int i = 0; i < B.Length; i++)
                Assert.AreEqual(B[i], answerB[i]);
            for (int i = 0; i < C.Length; i++)
                Assert.AreEqual(C[i], answerC[i]);
            for (int i = 0; i < D.Length; i++)
                Assert.AreEqual(D[i], answerD[i]);
        }

        [TestMethod()]
        public void Task_2_9Test()
        {
            // Arrange
            int[,] A = new int[7, 4], C = new int[6, 5];
            Array.Copy(matrix7x4, A, A.LongLength);
            Array.Copy(matrix6x5, C, C.LongLength);
            int[] answer = new int[9] { 34, 31, 41, 33, 24, 29, 32, 38, 30 }, result;
            // Act
            result = main.Task_2_9(A, C);
            // Assert
            Assert.AreEqual(answer.Length, result.Length);
            for (int i = 0; i < answer.Length; i++)
                Assert.AreEqual(answer[i], result[i]);
        }

        [TestMethod()]
        public void Task_2_10Test()
        {
            // Arrange
            int[,] A = new int[5, 5], B = new int[6, 6];
            int[,] answerA = new int[5, 3] {
            { 1, 2, 4 },
            { 6, 7, 9 },
            { 11, 12, 14 },
            { -1, -2,  -4 },
            { 6, 7, 9 }};
            int[,] answerB = new int[6, 5]  {
            { 1, 2, 3, 4, -1 },
            { 6, 7, 8, 9, -2 },
            { 11, 12, 13, 14, -3 },
            { -1, -2, -3, -4, -1 },
            { 6, 7, 8, 9, -2 },
            { 1, 3, 3, 1,5 }};
            Array.Copy(matrix5x5, A, A.LongLength);
            Array.Copy(matrix6x6, B, B.LongLength);
            // Act
            main.Task_2_10(ref A);
            main.Task_2_10(ref B);
            // Assert
            Assert.AreEqual(answerA.GetLength(0), A.GetLength(0));
            Assert.AreEqual(answerA.GetLength(1), A.GetLength(1));
            Assert.AreEqual(answerB.GetLength(0), B.GetLength(0));
            Assert.AreEqual(answerB.GetLength(1), B.GetLength(1));
            for (int i = 0; i < A.GetLength(0); i++)
                for (int j = 0; j < A.GetLength(1); j++)
                    Assert.AreEqual(answerA[i, j], A[i, j]);
            for (int i = 0; i < B.GetLength(0); i++)
                for (int j = 0; j < B.GetLength(1); j++)
                    Assert.AreEqual(answerB[i, j], B[i, j]);
        }

        [TestMethod()]
        public void Task_2_11Test()
        {
            // Arrange
            int[,] A = new int[5, 5], B = new int[6, 6], C = new int[7, 4];
            int[,] answerAB = new int[5, 5] {
            { 1, 2, 3, 4, 5 },
            { 6, 7, 8, 9, 10 },
            { 11, 12, 13, 14, 20 },
            { -1, -2, -3, -4, -5 },
            { 6, 7, 8, 9, 0 }};
            int[,] answerBA = new int[6, 6]  {
            { 1,    2,  3,  4,  5,  -1 },
            { 6,    7,  8,  9,  10, -2 },
            { 11,   12, 13, 14, 15, -3 },
            { -1,   -2, -3, -4, -5, -1 },
            { 6,    7,  8,  9,  15, -2 },
            { 1,    3,  3,  1,  5, 5 }};
            int[,] answerCA = new int[7, 4] {
            { 1, 2, 3, 4 },
            { 5, 5, 4, 6 },
            { 5, -5, 5, -5 },
            { 6, 7, 8, 9 },
            { -6, -5, -8, 0 },
            { 11, 12, 13, 15 },
            { 6, 5, 8, 0 } };
            int[,] answerAC = new int[5, 5] {
            { 1, 2, 3, 4, 5 },
            { 6, 7, 8, 9, 10 },
            { 11, 12, 13, 14, 14 },
            { -1, -2, -3, -4, -5 },
            { 6, 7, 8, 9, 0 }};
            int[,] answerCB = new int[7, 4] {
            { 1, 2, 3, 4 },
            { 5, 5, 4, 6 },
            { 5, -5, 5, -5 },
            { 6, 7, 8, 9 },
            { -6, -5, -8, 0 },
            { 11, 12, 13, 20 },
            { 6, 5, 8, 0 } };
            int[,] answerBC = new int[6, 6]  {
            { 1,    2,  3,  4,  5,  -1 },
            { 6,    7,  8,  9,  10, -2 },
            { 11,   12, 13, 14, 15, -3 },
            { -1,   -2, -3, -4, -5, -1 },
            { 6,    7,  8,  9,  14, -2 },
            { 1,    3,  3,  1,  5, 5 }};
            Array.Copy(matrix5x5, A, A.LongLength);
            Array.Copy(matrix6x6, B, B.LongLength);
            Array.Copy(matrix7x4, C, C.LongLength);
            int rand = new Random().Next(3);
            // Act
            switch (rand)
            {
                case 0: main.Task_2_11(A, B); break;
                case 1: main.Task_2_11(A, C); break;
                case 2: main.Task_2_11(C, B); break;
            }
            // Assert
            Assert.AreEqual(A.GetLength(0), answerAB.GetLength(0));
            Assert.AreEqual(B.GetLength(0), answerBA.GetLength(0));
            Assert.AreEqual(A.GetLength(1), answerAB.GetLength(1));
            Assert.AreEqual(B.GetLength(1), answerBA.GetLength(1));
            Assert.AreEqual(A.GetLength(0), answerAC.GetLength(0));
            Assert.AreEqual(C.GetLength(0), answerCA.GetLength(0));
            Assert.AreEqual(A.GetLength(1), answerAC.GetLength(1));
            Assert.AreEqual(C.GetLength(1), answerCA.GetLength(1));
            Assert.AreEqual(C.GetLength(0), answerCB.GetLength(0));
            Assert.AreEqual(B.GetLength(0), answerBC.GetLength(0));
            Assert.AreEqual(C.GetLength(1), answerCB.GetLength(1));
            Assert.AreEqual(B.GetLength(1), answerBC.GetLength(1));
            switch (rand)
            {
                case 0:
                    for (int i = 0; i < A.GetLength(0); i++)
                        for (int j = 0; j < A.GetLength(1); j++)
                            Assert.AreEqual(answerAB[i, j], A[i, j]);
                    for (int i = 0; i < B.GetLength(0); i++)
                        for (int j = 0; j < B.GetLength(1); j++)
                            Assert.AreEqual(answerBA[i, j], B[i, j]);
                    break;
                case 1:
                    for (int i = 0; i < A.GetLength(0); i++)
                        for (int j = 0; j < A.GetLength(1); j++)
                            Assert.AreEqual(A[i, j], answerAC[i, j]);
                    for (int i = 0; i < C.GetLength(0); i++)
                        for (int j = 0; j < C.GetLength(1); j++)
                            Assert.AreEqual(answerCA[i, j], C[i, j]);
                    break;
                case 2:
                    for (int i = 0; i < B.GetLength(0); i++)
                        for (int j = 0; j < B.GetLength(1); j++)
                            Assert.AreEqual(answerBC[i, j], B[i, j]);
                    for (int i = 0; i < C.GetLength(0); i++)
                        for (int j = 0; j < C.GetLength(1); j++)
                            Assert.AreEqual(answerCB[i, j], C[i, j]);
                    break;
            }
        }

        [TestMethod()]
        public void Task_2_12Test()
        {
            // Arrange
            int[,] A = new int[5, 5], B = new int[5, 5], C = new int[5, 5];
            Array.Copy(matrix5x5, A, A.LongLength);
            Array.Copy(matrix5x5, B, B.LongLength);
            Array.Copy(matrix5x5, C, C.LongLength);
            A[0, 0] = 100;
            C[2, 3] = 50;
            int[,] answerAB = new int[,] {
            { 5, 2, 3, 4, 5 },
            { 10, 7, 8, 9, 10 },
            { 15, 12, 13, 14, 15 },
            { -5, -2, -3, -4, -5 },
            { 0, 7, 8, 9, 0 }};
            int[,] answerBA = new int[,] {
            { 1, 2, 3, 4, 100 },
            { 6, 7, 8, 9, 6 },
            { 11, 12, 13, 14, 11 },
            { -1, -2, -3, -4, -1 },
            { 6, 7, 8, 9, 6 }};
            int[,] answerBC = new int[,] {
            { 1, 2, 3, 4, 4 },
            { 6, 7, 8, 9, 9 },
            { 11, 12, 13, 14, 50 },
            { -1, -2, -3, -4, -4 },
            { 6, 7, 8, 9, 9 }};
            int[,] answerCB = new int[,] {
            { 1, 2, 3, 5, 5 },
            { 6, 7, 8, 10, 10 },
            { 11, 12, 13, 15, 15 },
            { -1, -2, -3, -5, -5 },
            { 6, 7, 8, 0, 0 }};
            int[,] answerAC = new int[,] {
            { 4, 2, 3, 4, 5 },
            { 9, 7, 8, 9, 10 },
            { 50, 12, 13, 14, 15 },
            { -4, -2, -3, -4, -5 },
            { 9, 7, 8, 9, 0 }};
            int[,] answerCA = new int[,] {
            { 1, 2, 3, 100, 5 },
            { 6, 7, 8, 6, 10 },
            { 11, 12, 13, 11, 15 },
            { -1, -2, -3, -1, -5 },
            { 6, 7, 8, 6, 0 }};
            int rand = new Random().Next(3);
            // Act
            switch (rand)
            {
                case 0: main.Task_2_12(A, B); break;
                case 1: main.Task_2_12(A, C); break;
                case 2: main.Task_2_12(C, B); break;
            }
            // Assert
            Assert.AreEqual(A.GetLength(0), answerAB.GetLength(0));
            Assert.AreEqual(B.GetLength(0), answerBA.GetLength(0));
            Assert.AreEqual(A.GetLength(1), answerAB.GetLength(1));
            Assert.AreEqual(B.GetLength(1), answerBA.GetLength(1));
            Assert.AreEqual(A.GetLength(0), answerAC.GetLength(0));
            Assert.AreEqual(C.GetLength(0), answerCA.GetLength(0));
            Assert.AreEqual(A.GetLength(1), answerAC.GetLength(1));
            Assert.AreEqual(C.GetLength(1), answerCA.GetLength(1));
            Assert.AreEqual(C.GetLength(0), answerCB.GetLength(0));
            Assert.AreEqual(B.GetLength(0), answerBC.GetLength(0));
            Assert.AreEqual(C.GetLength(1), answerCB.GetLength(1));
            Assert.AreEqual(B.GetLength(1), answerBC.GetLength(1));
            switch (rand)
            {
                case 0:
                    for (int i = 0; i < A.GetLength(0); i++)
                        for (int j = 0; j < A.GetLength(1); j++)
                            Assert.AreEqual(answerAB[i, j], A[i, j]);
                    for (int i = 0; i < B.GetLength(0); i++)
                        for (int j = 0; j < B.GetLength(1); j++)
                            Assert.AreEqual(answerBA[i, j], B[i, j]);
                    break;
                case 1:
                    for (int i = 0; i < A.GetLength(0); i++)
                        for (int j = 0; j < A.GetLength(1); j++)
                            Assert.AreEqual(A[i, j], answerAC[i, j]);
                    for (int i = 0; i < C.GetLength(0); i++)
                        for (int j = 0; j < C.GetLength(1); j++)
                            Assert.AreEqual(answerCA[i, j], C[i, j]);
                    break;
                case 2:
                    for (int i = 0; i < B.GetLength(0); i++)
                        for (int j = 0; j < B.GetLength(1); j++)
                            Assert.AreEqual(answerBC[i, j], B[i, j]);
                    for (int i = 0; i < C.GetLength(0); i++)
                        for (int j = 0; j < C.GetLength(1); j++)
                            Assert.AreEqual(answerCB[i, j], C[i, j]);
                    break;
            }
        }

        [TestMethod()]
        public void Task_2_13Test()
        {
            // Arrange
            int[,] A = new int[5, 5], B = new int[4, 5];
            int[,] answerA = new int[3, 5] {
            { 1, 2, 3, 4, 5 },
            { 6, 7, 8, 9, 10 },
            { 6, 7, 8, 9, 0 }};
            int[,] answerB = new int[3, 5]  {
            { 1, 2, 3, 4, 5 },
            { 6, 7, 8, 9, 10 },
            { 6, 7, 8, 9, 0 }};
            Array.Copy(matrix5x5, A, A.LongLength);
            Array.Copy(matrix4x5, B, B.LongLength);
            // Act
            main.Task_2_13(ref A);
            main.Task_2_13(ref B);
            // Assert
            Assert.AreEqual(answerA.GetLength(0), A.GetLength(0));
            Assert.AreEqual(answerA.GetLength(1), A.GetLength(1));
            Assert.AreEqual(answerB.GetLength(0), B.GetLength(0));
            Assert.AreEqual(answerB.GetLength(1), B.GetLength(1));
            for (int i = 0; i < A.GetLength(0); i++)
                for (int j = 0; j < A.GetLength(1); j++)
                    Assert.AreEqual(answerA[i, j], A[i, j]);
            for (int i = 0; i < B.GetLength(0); i++)
                for (int j = 0; j < B.GetLength(1); j++)
                    Assert.AreEqual(answerB[i, j], B[i, j]);
        }

        [TestMethod()]
        public void Task_2_14Test()
        {
            // Arrange
            int[,] A = new int[7, 4], B = new int[8, 15];
            int[,] answerA = new int[7, 4] {
            { 1, 2, 3, 4 },
            { 4, 5, 5, 6 },
            { -5, -5, 5, 5 },
            { 6, 7, 8, 9 },
            { -8, -6, -5, 0 },
            { 11, 12, 13, 14 },
            { 0, 5, 6, 8 } };
            int[,] answerB = new int[8, 15];
            Array.Copy(matrix7x4, A, A.LongLength);
            var rand = new Random();
            for (int i = 0; i < B.GetLength(0); i++)
            {
                int[] temp = new int[B.GetLength(1)];
                for (int j = 0; j < B.GetLength(1); j++)
                {
                    var num = rand.Next(-50, 50);
                    temp[j] = num;
                    B[i, j] = temp[j];
                }
                Array.Sort(temp);

                for (int j = 0; j < answerB.GetLength(1); j++)
                {
                    answerB[i, j] = temp[j];
                }
            }
            // Act
            main.Task_2_14(A);
            main.Task_2_14(B);
            // Assert
            Assert.AreEqual(answerA.GetLength(0), A.GetLength(0));
            Assert.AreEqual(answerA.GetLength(1), A.GetLength(1));
            Assert.AreEqual(answerB.GetLength(0), B.GetLength(0));
            Assert.AreEqual(answerB.GetLength(1), B.GetLength(1));
            for (int i = 0; i < A.GetLength(0); i++)
                for (int j = 0; j < A.GetLength(1); j++)
                    Assert.AreEqual(answerA[i, j], A[i, j]);
            for (int i = 0; i < B.GetLength(0); i++)
                for (int j = 0; j < B.GetLength(1); j++)
                    Assert.AreEqual(answerB[i, j], B[i, j]);
        }

        [TestMethod()]
        public void Task_2_15Test()
        {
            // Arrange
            int[,] A = new int[6, 6], B = new int[5, 5], C = new int[3, 5];
            Array.Copy(matrix6x6, A, A.LongLength);
            Array.Copy(matrix5x5, B, B.LongLength);
            Array.Copy(matrix3x5, C, C.LongLength);
            int sequence1, sequence2, sequence3;
            int answer1 = 1, answer2 = 0, answer3 = -1;
            // Act
            sequence1 = main.Task_2_15(A, B, C);
            sequence2 = main.Task_2_15(A, C, B);
            sequence3 = main.Task_2_15(C, B, A);
            // Assert
            Assert.AreEqual(answer1, sequence1);
            Assert.AreEqual(answer2, sequence2);
            Assert.AreEqual(answer3, sequence3);
        }

        [TestMethod()]
        public void Task_2_16Test()
        {
            // Arrange
            int[] A = new int[8], B = new int[10];
            int[] C = new int[8], D = new int[10];
            int[] answerA = new int[] { 1, 8, -3, 5, -5, 1, 0, 4 };
            int[] answerB = new int[] { 1, -1, -3, 5, -4, 1, 0, -5, -8, 2 };
            int[] answerC = new int[8], answerD = new int[10];
            Array.Copy(arr8, A, A.Length);
            Array.Copy(arr10, B, B.Length);
            var rand = new Random();
            for (int i = 0; i < C.Length; i++)
            {
                C[i] = rand.Next(100);
            }
            for (int i = 0; i < D.Length; i++)
            {
                D[i] = rand.Next(100);
            }
            Array.Copy(C, answerC, C.Length);
            Array.Copy(D, answerD, D.Length);
            Array.Sort(answerC, (a, b) =>
            {
                return a < 0 && b < 0 ? a.CompareTo(b) : 0;
            });
            Array.Sort(answerD, (a, b) =>
            {
                return a < 0 && b < 0 ? a.CompareTo(b) : 0;
            });
            // Act
            main.Task_2_16(A, B);
            main.Task_2_16(C, D);
            // Assert
            Assert.AreEqual(answerA.Length, A.Length);
            Assert.AreEqual(answerB.Length, B.Length);
            Assert.AreEqual(answerC.Length, C.Length);
            Assert.AreEqual(answerD.Length, D.Length);
            for (int i = 0; i < A.Length; i++)
                Assert.AreEqual(A[i], answerA[i]);
            for (int i = 0; i < B.Length; i++)
                Assert.AreEqual(B[i], answerB[i]);
            for (int i = 0; i < C.Length; i++)
                Assert.AreEqual(C[i], answerC[i]);
            for (int i = 0; i < D.Length; i++)
                Assert.AreEqual(D[i], answerD[i]);
        }

        [TestMethod()]
        public void Task_2_17Test()
        {
            // Arrange
            int[,] A = new int[4, 6], B = new int[6, 6];
            int[,] answerA = new int[4, 6] {
            { 6, 7, 8, 9, 10, -2 },
            { 6, 7, 8, 9, 0, -2 },
            { 1, 2, 3, 4, 5, -1 },
            { -1, -2, -3, -4, -5, -1 }};
            int[,] answerB = new int[6, 6] {
            { 6,    7,  8,  9,  20, -2 },
            { 11,   12, 13, 14, 15, -3 },
            { 6,    7,  8,  9,  10, -2 },
            { 1,    2,  3,  4,  5,  -1 },
            { 1,    3,  3,  1,  5,  5 },
            { -1,   -2, -3, -4, -5, -1 }};
            Array.Copy(matrix4x6, A, A.LongLength);
            Array.Copy(matrix6x6, B, B.LongLength);
            // Act
            main.Task_2_17(A, B);
            // Assert
            Assert.AreEqual(answerA.GetLength(0), A.GetLength(0));
            Assert.AreEqual(answerA.GetLength(1), A.GetLength(1));
            Assert.AreEqual(answerB.GetLength(0), B.GetLength(0));
            Assert.AreEqual(answerB.GetLength(1), B.GetLength(1));
            for (int i = 0; i < A.GetLength(0); i++)
                for (int j = 0; j < A.GetLength(1); j++)
                    Assert.AreEqual(answerA[i, j], A[i, j]);
            for (int i = 0; i < B.GetLength(0); i++)
                for (int j = 0; j < B.GetLength(1); j++)
                    Assert.AreEqual(answerB[i, j], B[i, j]);
        }

        [TestMethod()]
        public void Task_2_18Test()
        {
            // Arrange
            int[,] A = new int[5, 5], B = new int[6, 6];
            int[,] answerA = new int[5, 5] {
            { -4, 2, 3, 4, 5 },
            { 6, 0, 8, 9, 10 },
            { 11, 12, 1, 14, 15 },
            { -1, -2, -3, 7, -5 },
            { 6, 7, 8, 9, 13 }};
            int[,] answerB = new int[6, 6] {
            { -4,    2,  3,  4,  5,  -1 },
            { 6,    1,  8,  9,  10, -2 },
            { 11,   12, 5, 14, 15, -3 },
            { -1,   -2, -3, 7, -5, -1 },
            { 6,    7,  8,  9,  13, -2 },
            { 1,    3,  3,  1,  5, 20 }};
            Array.Copy(matrix5x5, A, A.LongLength);
            Array.Copy(matrix6x6, B, B.LongLength);
            // Act
            main.Task_2_18(A, B);
            // Assert
            Assert.AreEqual(answerA.GetLength(0), A.GetLength(0));
            Assert.AreEqual(answerA.GetLength(1), A.GetLength(1));
            Assert.AreEqual(answerB.GetLength(0), B.GetLength(0));
            Assert.AreEqual(answerB.GetLength(1), B.GetLength(1));
            for (int i = 0; i < A.GetLength(0); i++)
                for (int j = 0; j < A.GetLength(1); j++)
                    Assert.AreEqual(answerA[i, j], A[i, j]);
            for (int i = 0; i < B.GetLength(0); i++)
                for (int j = 0; j < B.GetLength(1); j++)
                    Assert.AreEqual(answerB[i, j], B[i, j]);
        }

        [TestMethod()]
        public void Task_2_19Test()
        {
            // Arrange
            int[,] A = new int[7, 4], B = new int[6, 5];
            int[,] answerA = new int[5, 4] {
            { 1, 2, 3, 4 },
            { 5, 5, 4, 6 },
            { 5, -5, 5, -5 },
            { 6, 7, 8, 9 },
            { 11, 12, 13, 14 }};
            int[,] answerB = new int[,] {
            { 1, 2, 3, 4, 5 },
            { 6, 7, 8, 9, 10 },
            { 11, 12, 13, 14, 15 },
            { -1, -2, -3, -4, -5 }};
            Array.Copy(matrix7x4, A, A.LongLength);
            Array.Copy(matrix6x5, B, B.LongLength);
            // Act
            main.Task_2_19(ref A);
            main.Task_2_19(ref B);
            // Assert
            Assert.AreEqual(answerA.GetLength(0), A.GetLength(0));
            Assert.AreEqual(answerA.GetLength(1), A.GetLength(1));
            Assert.AreEqual(answerB.GetLength(0), B.GetLength(0));
            Assert.AreEqual(answerB.GetLength(1), B.GetLength(1));
            for (int i = 0; i < A.GetLength(0); i++)
                for (int j = 0; j < A.GetLength(1); j++)
                    Assert.AreEqual(answerA[i, j], A[i, j]);
            for (int i = 0; i < B.GetLength(0); i++)
                for (int j = 0; j < B.GetLength(1); j++)
                    Assert.AreEqual(answerB[i, j], B[i, j]);
        }

        [TestMethod()]
        public void Task_2_20Test()
        {
            // Arrange
            int[,] A = new int[7, 4], B = new int[6, 5];
            int[,] answerA = new int[,] {
            { 4 },
            { 6 },
            { -5 },
            { 9 },
            { 0 },
            { 14 },
            { 0 }};
            int[,] answerB = new int[,] {
            { 1, 3, 5 },
            { 6, 8, 10 },
            { 11, 13, 15 },
            { -1, -3, -5 },
            { 0, 0, 0 },
            { 6, 8, 0 }};
            Array.Copy(matrix7x4, A, A.LongLength);
            Array.Copy(matrix6x5, B, B.LongLength);
            // Act
            main.Task_2_20(ref A, ref B);
            // Assert
            Assert.AreEqual(answerA.GetLength(0), A.GetLength(0));
            Assert.AreEqual(answerA.GetLength(1), A.GetLength(1));
            Assert.AreEqual(answerB.GetLength(0), B.GetLength(0));
            Assert.AreEqual(answerB.GetLength(1), B.GetLength(1));
            for (int i = 0; i < A.GetLength(0); i++)
                for (int j = 0; j < A.GetLength(1); j++)
                    Assert.AreEqual(answerA[i, j], A[i, j]);
            for (int i = 0; i < B.GetLength(0); i++)
                for (int j = 0; j < B.GetLength(1); j++)
                    Assert.AreEqual(answerB[i, j], B[i, j]);
        }
    }
}