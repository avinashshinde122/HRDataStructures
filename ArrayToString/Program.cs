using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayToString
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            string[] arr_temp = Console.ReadLine().Split(' ');
            int[] arr = Array.ConvertAll(arr_temp, Int32.Parse);
            Array.Reverse(arr);
            string arrSt = string.Join(" ", arr.Select(p => p.ToString()).ToArray());
            Console.WriteLine(arrSt);
            Console.Read();
        }
    }
}
