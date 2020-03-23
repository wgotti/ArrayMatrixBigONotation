using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayMatrixBigONotation
{
	public class MaxSum
	{
        // Time Complexity (in Big O notation) = O(n) -> linear
        // Space Complexity(in Big O notation) = O(1) -> constant
        public int FindSum(int[] arr)
		{
            int pastInc = 0;
            int inc = 0;
            int exc = 0;

            foreach (int item in arr)
            {
                pastInc = inc;
                inc = Math.Max(item + exc, pastInc);
                exc = pastInc;
            }
            return inc;
        }
	}
}
