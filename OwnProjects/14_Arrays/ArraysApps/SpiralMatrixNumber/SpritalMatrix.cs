using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpiralMatrixNumber
{
    internal class SpritalMatrix
    {
        public static int[,] GetMatrix(int size)
        {
            if (size == 0)
            {
                return new int[size,size];
            };

            var matrix = new int[size, size];
            int column = 0;
            int row = 0;
            for (int i = 1; i <= size*2; i++)
            {
                if (row == size)
                {
                    return matrix;
                }
                matrix[row, column] = i;
                column++;
                if (column == size)
                {
                    column = 0;
                    row += 1;
                }
                
            }

            return matrix;
        }
    }
}
