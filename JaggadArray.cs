using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JaggedArray.Matrix
{
    class JaggedArray
    {
       public static void AddMatrix()
        {
            int[][] Matrix = new int[][]
            {
                new int[] { 0, 2, 3, 2 },
                new int[] { 0, 6, 0, 1 },
                new int[] { 4, 0, 3, 0 }
            };
            int x = 0;
            for (int i = 0; i < Matrix[0].Length; i++)
            {
                for (int j = 0; j < Matrix.Length && Matrix[j][i] > 0; j++)
                {
                    x += Matrix[j][i];
                }
            }
            Console.WriteLine(x);

        }
    }
}
