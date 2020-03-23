using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayMatrixBigONotation
{
    public class DeadPixels
    {
		// Time Complexity (in Big O notation)  
		//	- non square monitors = O(monitorRows x monitorColumns) --> quadratic
		//  - square monitors = O(n²) --> quadratic
		// Space Complexity (in Big O notation)  = O(1) --> constant
		public int CountGroups(char[][] monitor)
		{
			//int[][] pixelGroups = new int[monitor.Length][];
			int lastGroup = 0;

			for (int row = 0; row < monitor.Length; row++)
			{
				//pixelGroups[row] = new int[monitor[row].Length];

				for (int col = 0; col < monitor[row].Length; col++)
				{
					if (monitor[row][col].Equals('1'))
					{
							// Previous cell is NOT a dead pixel
						if (!(col > 0 && monitor[row][col-1].Equals('1')) &&
							// Upper Cell (row above) is NOT a dead pixel
							 !(row > 0 && monitor[row-1][col].Equals('1'))) 
						{
							lastGroup++;
						}
					}
				}
			}

			return lastGroup;
		}
	}
}
