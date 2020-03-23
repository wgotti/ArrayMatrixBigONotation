using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayMatrixBigONotation
{
    class Program
    {

        static void Main(string[] args)
        {
            MaxSum maxSum = new MaxSum();
            int x1 = maxSum.FindSum(new int[4] { 1, 2, 3, 1 }); // 4
            int x2 = maxSum.FindSum(new int[5] { 2, 7, 9, 3, 1 }); // 12
            int x3 = maxSum.FindSum(new int[4] { 5, 1, 2, 5 }); // 10

            DeadPixels deadPixels = new DeadPixels();
            int x4 = deadPixels.CountGroups(new char[][] {  new char[] {'1', '0', '1' },
                                                            new char[] { '0', '1', '0'},
                                                            new char[] { '1', '0', '1'} }); // 5

            int x5= deadPixels.CountGroups(new char[][] {   new char[] {'1', '1', '1' },
                                                            new char[] { '1', '0', '0'},
                                                            new char[] { '1', '0', '1'} }); // 2
        }
    }
}