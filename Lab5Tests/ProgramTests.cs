using Microsoft.VisualStudio.TestPlatform.TestHost;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using static Program;

namespace Tests
{
    [TestClass()]
    public class ProgramTests
    {
        Program main = new Program();
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

            main.Task_4(matrix, new int[] { 12, 13, 14});
        }
    }
}