using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2DArray
{
    class Program
    {

        static int MatrixSum(int[][] array3x6, int startVal)
        {
            int HourglassSum = 0;
            int Jstop = startVal;
            for (int i = 0; i < 3; i++)
            {
                for (int j = startVal; j < startVal+3; j++)
                {
                    //arr3x3[i][j] = array6x6[i][j];
                    if (i != 1 || (i==1 && j== Jstop + 1))
                    {
                        HourglassSum = HourglassSum + array3x6[i][j];
                    }
                }
            }
            //HourglassSum = HourglassSum - array3x6[startVal + 1][startVal] - array3x6[startVal + 1][startVal];
            return HourglassSum;
        }
        static int MaximumSum(int[][] array6x6)
        {
            int sum = -63;


            // 3X6 matrix formation
            for (int StartIndex = 0; StartIndex < 4; StartIndex++)
            {
                int[][] Array3x6 = new int[][]
                {
                 array6x6[StartIndex],
                 array6x6[StartIndex+1],
                 array6x6[StartIndex+2]
                };

                for (int startVal = 0; startVal < 4; startVal++)
                {
                    int HSum = MatrixSum(Array3x6, startVal);
                    if (HSum > sum)
                    {
                        sum = HSum;
                    }
                }
            }

            return sum;
        }
        static void Main(string[] args)
        {
            //int[][] arr = new int[6][];
            //arr = new int[6][]
            //{
            //    new int[] {0,-4,-6,0,-7,-6 },
            //    new int[] {-1,-2,-6,-8,-3,-1 },
            //    new int[] {-8,-4,-2,-8,-8,-6 },
            //    new int[] {-3,-1,2,-5,-7,-4 },
            //    new int[] {-3,-5,-3,-6,-6,-6 },
            //    new int[] {-3,-6,0,-8,-6,-7 },
            //};


            int[][] arr = new int[6][];
            for (int arr_i = 0; arr_i < 6; arr_i++)
            {
                string[] arr_temp = Console.ReadLine().Split(' ');
                arr[arr_i] = Array.ConvertAll(arr_temp, Int32.Parse);
            }

            int result = MaximumSum(arr);
            Console.WriteLine(result);

            Console.Read();
        }
    }
}
