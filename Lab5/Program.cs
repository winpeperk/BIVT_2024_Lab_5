using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Numerics;
using System.Reflection;
using System.Reflection.Metadata;
using static System.Runtime.InteropServices.JavaScript.JSType;

public class Program
{
    public static void Main()
    {
        Program program = new Program();
    }
    #region Level 1
    public long Task_1_1(int n, int k)
    {
        long answer = 0;

        // code here

        // create and use Factorial(n);

        // end

        return answer;
    }
    public double Task_1_2(double[] first, double[] second)
    {
        double answer = 0;

        // code here

        // create and use GeronArea(a, b, c);

        // end

        return answer;
    }
    public int Task_1_3a(double v1, double a1, double v2, double a2, int time)
    {
        int answer = 0;

        // code here

        // create and use GetDistance(v, a, t); t - hours

        // end

        return answer;
    }
    public int Task_1_3b(double v1, double a1, double v2, double a2)
    {
        int answer = 0;

        // code here

        // create and use GetDistance(v, a, t); t - hours

        // end

        return answer;
    }
    #endregion

    #region Level 2
    public void Task_2_1(int[,] A, int[,] B)
    {
        // code here

        // create and use FindMax(matrix);

        // end
    }
    public void Task_2_2(double[] A, double[] B)
    {
        // code here

        // create and use FindMax(array);

        // end
    }
    public void Task_2_3(int[,] B, int[,] C)
    {
        // code here

        // create and use FindDiagonalMax(matrix);

        // end
    }
    public void Task_2_4(int[,] A, int[,] B)
    {
        // code here

        // use method FindDiagonalMax(matrix); from Task_2_3
        // use method FindDiagonalMaxIndex(matrix); from Task_2_3

        // end
    }
    public void Task_2_5(int[,] A, int[,] B)
    {
        // code here

        // create and use FindColumnMax(matrix, columnIndex);

        // end
    }
    public void Task_2_6(int[] A, int[] B)
    {
        // code here

        // create and use DeleteElement(array, index);

        // end
    }
    public void Task_2_7(int[,] B, int[,] C)
    {
        // code here

        // create and use CountRowPositive(matrix, rowIndex);
        // create and use CountColumnPositive(matrix, colIndex);

        // end
    }
    public void Task_2_8(int[] A, int[] B)
    {
        // code here

        // create and use SortArrayPart(array, startIndex);

        // end
    }
    public int[] Task_2_9(int[,] A, int[,] C)
    {
        int[] answer = default(int[]);

        // code here

        // create and use SumPositiveElementsInColumns(matrix);

        // end

        return answer;
    }
    public void Task_2_10(int[,] matrix)
    {
        // code here

        // create and use RemoveColumn(matrix, columnIndex);

        // end
    }
    public void Task_2_11(int[,] A, int[,] B)
    {
        // code here

        // use FindMax(matrix); from Task_2_1

        // end
    }
    public void Task_2_12(int[,] A, int[,] B)
    {
        // code here

        // create and use FindMaxColumnIndex(matrix);

        // end
    }
    public void Task_2_13(int[,] matrix)
    {
        // code here

        // create and use RemoveRow(matrix, rowIndex);

        // end
    }
    public void Task_2_14(int[,] matrix)
    {
        // code here

        // create and use SortRow(matrix, rowIndex);

        // end
    }
    public int Task_2_15(int[,] A, int[,] B, int[,] C)
    {
        int answer = 0; // 1 - increasing   0 - no sequence   -1 - decreasing

        // code here

        // create and use GetAverageWithoutMinMax(matrix);

        // end

        return answer;
    }
    public void Task_2_16(int[] A, int[] B)
    {
        // code here

        // create and use SortNegative(array);

        // end
    }
    public void Task_2_17(int[,] A, int[,] B)
    {
        // code here

        // create and use SortRowsByMaxElement(matrix);

        // end
    }
    public void Task_2_18(int[,] A, int[,] B)
    {
        // code here

        // create and use SortDiagonal(matrix);

        // end
    }

    public void Task_2_19(int[,] matrix)
    {
        // code here

        // use RemoveRow(matrix, rowIndex); from 2_13

        // end
    }
    public void Task_2_20(int[,] A, int[,] B)
    {
        // code here

        // use RemoveColumn(matrix, columnIndex); from 2_10

        // end
    }
    public (int[], int[]) Task_2_21(int[,] A, int[,] B)
    {
        int[] answerA = default(int[]);
        int[] answerB = default(int[]);

        // code here

        // create and use CreateArrayFromMins(matrix);

        // end

        return (answerA, answerB);
    }
    public (int[], int[]) Task_2_22(int[,] matrix)
    {
        int[] rows = default(int[]);
        int[] cols = default(int[]);

        // code here

        // create and use GetNegativeCountPerRow(matrix);
        // create and use GetMaxNegativePerColumn(matrix);

        // end

        return (rows, cols);
    }
    public void Task_2_23(double[,] A, double[,] B)
    {
        // code here

        // create and use MatrixValuesChange(matrix);

        // end
    }
    public void Task_2_24(int[,] A, int[,] B)
    {
        // code here

        // use FindMax(matrix); from 2_1

        // end
    }
    public void Task_2_25(int[,] A, int[,] B)
    {
        // code here

        // create and use FindMaxNegativeRow(int);
        // use GetNegativeCountPerRow(matrix); from 2_22

        // end
    }
    public void Task_2_26(int[,] A, int[,] B)
    {
        // code here

        // use GetNegativeCountPerRow(matrix); from 2_22
        // use FindMax(array); from 2_2

        // end
    }
    public void Task_2_27(int[,] A, int[,] B)
    {
        // code here

        // create and use ReplaceMaxElementOdd(matrix);
        // create and use ReplaceMaxElementEven(matrix);

        // end
    }
    public (int, int) Task_2_28a(int[,] first, int[,] second, int A, int B)
    {
        int answerFirst = 0, answerSecond = 0;

        // code here

        // create and use FindSequence(array);

        // end

        return (answerFirst, answerSecond);
    }
    public int[,] Task_2_28b(int[,] first, int[,] second)
    {
        int[,] answer = default(int[,]);

        // code here

        // create and use FindSequence(array);

        // end

        return answer;
    }
    public int[,] Task_2_28c(int[,] first, int[,] second, int A, int B)
    {
        int[,] answer = default(int[,]);

        // code here

        // create and use FindSequence(array);

        // end

        return answer;
    }
    #endregion
    #region Level 3
    public (double[,], double[,]) Task_3_1(double a, double b, double h)
    {
        double[,] firstSumAndY = default(double[,]);
        double[,] secondSumAndY = default(double[,]);

        // code here

        // create and use public delegate SumFunction(x) and public delegate YFunction(x)
        // create and use method GetSumAndY(sFunction, yFunction, a, b, h);
        // create and use 2 methods for both functions

        // end

        return (firstSumAndY, secondSumAndY);
    }
    public void Task_3_2(int[,] matrix)
    {
        // Uncomment this:
        // SortRowStyle sortStyle = default(SortRowStyle);

        // code here

        // create and use public delegate SortRowStyle(matrix, rowIndex);
        // create and use methods SortAscending(matrix, rowIndex) and SortDescending(matrix, rowIndex)
        // change method in variable sortStyle in the loop here and use it for row sorting

        // end
    }
    public double Task_3_3(double[] array)
    {
        double answer = 0;
        // Uncomment this:
        // SwapDirection swapper = default(SwapDirection);

        // code here

        // create and use public delegate SwapDirection(array);
        // create and use methods SwapRight(array) and SwapLeft(array) and GetSum(array)
        // change method in variable swapper in the loop here and use it for array swapping

        // end

        return answer;
    }
    public double Task_3_4(double[,] matrix, bool isUpperTriangle)
    {
        double answer = 0;

        // code here

        // create and use public delegate GetTriangle(matrix);
        // create and use methods GetUpperTriange(array) and GetLowerTriange(array)
        // and GetSum(GetTriangle, matrix)
        // use method GetSum(array) from Task_3_3

        // end

        return answer;
    }
    public int Task_3_5(int functionNumber, double a, double b, double h)
    {
        int answer = 0;

        // code here

        // use public delegate YFunction(x) from Task_3_1
        // create and use method CountSignFlips(YFunction, a, b, h);
        // create and use 2 methods for both functions

        // end

        return answer;
    }
    public void Task_3_6(int[,] matrix)
    {
        // code here

        // create and use public delegate FindElementDelegate(matrix);
        // use method FindDiagonalMaxIndex(matrix) from Task_2_3;
        // create and use method FindFirstRowMaxIndex(matrix);
        // create and use method SwapColumns(matrix, FindDiagonalMaxIndex, FindFirstRowMaxIndex);

        // end
    }
    public int[,] Task_3_7(int[,] B, int[,] C, int n)
    {
        int[,] answer = default(int[,]);

        // code here

        // create and use public delegate CountPositive(matrix, index);
        // use CountRowPositive(matrix, rowIndex) from Task_2_7
        // use CountColumnPositive(matrix, colIndex) from Task_2_7

        // end

        return answer;
    }
    public void Task_3_10(int[,] matrix)
    {
        // Uncomment this:
        // FindIndex searchArea = default(FindIndex);

        // code here

        // create and use public delegate FindIndex(matrix);
        // create and use method FindMaxBelowDiagonalIndex(matrix);
        // create and use method FindMinAboveDiagonalIndex(matrix);
        // use RemoveColumn(matrix, columnIndex) from Task_2_10
        // create and use method RemoveColumns(matrix, findMaxBelowDiagonalIndex, findMinAboveDiagonalIndex)

        // end
    }
    public void Task_3_13(int[,] matrix)
    {
        // code here

        // use public delegate FindElementDelegate(matrix) from Task_3_6
        // create and use method RemoveRows(matrix, findMax, findMin)

        // end
    }

    // Uncomment this:
    /*public (int[], int[]) Task_3_22(int[,] matrix)
    {
        GetNegativeArray searcherRows = default(GetNegativeArray);
        GetNegativeArray searcherCols = default(GetNegativeArray);

        // code here

        // create and use public delegate GetNegativeArray(matrix);
        // use GetNegativeCountPerRow(matrix) from Task_2_22
        // use GetMaxNegativePerColumn(matrix) from Task_2_22

        // end

        return (searcherRows(matrix), searcherCols(matrix));
    }*/
    public void Task_3_27(int[,] A, int[,] B)
    {
        // code here

        // create and use public delegate ReplaceMaxElement(matrix, rowIndex, max);
        // use ReplaceMaxElementOdd(matrix) from Task_2_27
        // use ReplaceMaxElementEven(matrix) from Task_2_27
        // create and use method EvenOddRowsTransform(matrix, replaceMaxElementOdd, replaceMaxElementEven);

        // end
    }
    public int[,] Task_3_28c(int[,] first, int[,] second, int A, int B)
    {
        int[,] answer = default(int[,]);
        // increasingFirstLeft, increasingFirstRight
        // decreasingFirstLeft, decreasingFirstRight
        // increasingSecondLeft, increasingSecondRight
        // decreasingSecondLeft, decreasingSecondRight

        // code here

        // create public delegate IsSequence(array);
        // create and use method FindIncreasingSequence(array); similar to FindSequence(array) in Task_2_28
        // create and use method FindDecreasingSequence(array); similar to FindSequence(array) in Task_2_28
        // create and use method FindMaxSequenceBounds(matrix, isSequence);

        // end

        return answer;
    }
    #endregion
    #region bonus part
    public void Task_4(double[,] matrix, int[] number)
    {
        // code here

        // create public delegate MatrixConverter(matrix);
        // create and use method ToUpperTriangular(matrix);
        // create and use method ToLowerTriangular(matrix);
        // create and use method ToDiagonal(matrix,);

        // end
    }
    #endregion
}