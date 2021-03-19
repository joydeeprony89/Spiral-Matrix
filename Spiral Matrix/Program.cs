using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spiral_Matrix
{
    class Program
    {
        static void Main(string[] args)
        {
            var matrix = new int[3][] { new int[] { 1, 2, 3, 4 }, new int[] { 5, 6 , 7 , 8 }, new int[] { 9 , 10, 11, 12  } };
            var result = SpiralOrder(matrix);
            foreach (var no in result)
                Console.WriteLine(no);
        }

        static IList<int> SpiralOrder(int[][] matrix)
        {
            List<int> result = new List<int>();
            if (matrix == null || matrix.Length == 0) return result;
            int rows = matrix.Length;
            int cols = matrix[0].Length;
            int top = 0, down = rows - 1, left = 0, right = cols - 1;
            int direction = 0;
            while (top <= down && left <= right)
            {
                if (direction == 0)
                {
                    for (int i = left; i <= right; i++)
                        result.Add(matrix[top][i]);
                    top++;
                }
                else if (direction == 1)
                {
                    for (int i = top; i <= down; i++)
                        result.Add(matrix[i][right]);
                    right--;
                }
                else if (direction == 2)
                {
                    for (int i = right; i >= left; i--)
                        result.Add(matrix[down][i]);
                    down--;
                }
                else if (direction == 3)
                {
                    for (int i = down; i >= top; i--)
                        result.Add(matrix[i][left]);
                    left++;
                }

                direction += 1;
                direction = direction % 4;
            }
            return result;
        }
    }
}
