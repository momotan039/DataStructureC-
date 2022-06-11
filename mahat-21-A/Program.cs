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
<<<<<<< HEAD
            Console.WriteLine("wafalasf");
            int[] arr = { 1, 2, 3 };
            int[] arr2 = { 4, 5 ,6,9};
           Multiply(arr, arr2); 
=======
            bin.SetLeft(new BinNode<int>(100));
            bin.GetLeft().SetRight(new BinNode<int>(15));
            //bin.GetLeft().GetRight().SetLeft(new BinNode<int>(16));
            //bin.GetLeft().GetRight().GetLeft().SetRight(new BinNode<int>(88));
            bin.GetLeft().SetLeft(new BinNode<int>(50));
            bin.GetLeft().GetLeft().SetLeft(new BinNode<int>(222));
            //bin.GetLeft().GetLeft().SetRight(new BinNode<int>(444));
            bin.SetRight(new BinNode<int>(3));
            bin.GetRight().SetRight(new BinNode<int>(35));
            bin.GetRight().SetLeft(new BinNode<int>(200));
            Console.Write("PreOrder=>");
            BinNode<int>.PreOrder(bin);
            Console.WriteLine();
            Console.Write("InOrder=>");
            BinNode<int>.PostOrder(bin);
            Console.WriteLine();
            Console.Write("PostOrder=>");
            BinNode<int>.InOrder(bin);
        }
        static void Main(string[] args)
        {
            BuildBinNode();
            Console.WriteLine();
            var b=new BinNode<int>(45);
            //true false true 
            b.SetLeft(new BinNode<int>(20));
            b.SetRight(new BinNode<int>(25));

            b.GetRight().SetLeft(new BinNode<int>(15));

            Console.WriteLine(BinNode<int>.IsSumChildsEqualParent(b));

>>>>>>> 18f1c9b3426594723c1a9a7938c97314e0d0da87
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
