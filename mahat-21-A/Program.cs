using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mahat_21_A
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("wafalasf");
            int[] arr = { 1, 2, 3 };
            int[] arr2 = { 4, 5 ,6,9};
           Multiply(arr, arr2); 
            Console.ReadKey();
        }
        static bool IsPerfect(int[] arr)
        {//0 1 2 index
         //1 2 0 value
         //t f f
         //all values retruns
         //end loop=>value 0 retrun
          bool [] bArr=new bool[arr.Length];
          bool gotAllvalues=false;
            int value, index=0;
            value = arr[index];
            while (!gotAllvalues)
            {
                bArr[index] = true;
                bool found = true;
                for (int i = 0; i < bArr.Length; i++)
                {
                    if (bArr[i] == false)
                        found = false;
                }
                if(found)
                    gotAllvalues = true;
            }
           
        }
        static int[] Multiply(int[]arr1,int[]arr2)
        {//1 2 3    4 5
            int[] max = arr1.Length > arr2.Length ? arr1 : arr2;
            int[] min= arr1.Length < arr2.Length ?arr1 : arr2;
            int []res=new int[max.Length];
            int i = 0;
            for ( ; i < min.Length; i++)
            {
                res[i] = max[i] * min[i];
            }
            for (; i < max.Length; i++)
            {
                res[i] = max[i];
            }
            return res;
           
        }
    }
}
