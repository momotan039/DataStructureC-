using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mahat_21_A.Lists
{
    class BinNode<T>
    {
        private T value;
        private BinNode<T> left;
        private BinNode<T> right;
        public BinNode(T value)
        {
            this.value = value;
            this.left = null;
            this.right = null;
        }
        public BinNode(BinNode<T> left, T value, BinNode<T> right)
        {
            this.value = value;
            this.left = left;
            this.right = right;
        }
        public T GetValue()
        {
            return value;
        }
        public BinNode<T> GetLeft()
        {
            return left;
        }
        public BinNode<T> GetRight()
        {
            return right;
        }
        public bool HasLeft()
        {
            return left != null;
        }
        public bool HasRight()
        {
            return right != null;
        }
        public void SetValue(T value)
        {
            this.value = value;
        }
        public void SetLeft(BinNode<T> left)
        {
            this.left = left;
        }
        public void SetRight(BinNode<T> right)
        {
            this.right = right;
        }

        //Extra Functions
        public static void PreOrder(BinNode<int> b)
        {
            if (b != null)
            {
                Console.Write(b.GetValue() + " ");
                PreOrder(b.GetLeft());
                PreOrder(b.GetRight());
            }
        }
        public static void InOrder(BinNode<int> b)
        {
            if (b != null)
            {
                InOrder(b.GetLeft());
                InOrder(b.GetRight());
                Console.Write(b.GetValue() + " ");
            }
        }
        public static void PostOrder(BinNode<int> b)
        {
            if (b != null)
            {
                PostOrder(b.GetLeft());
                Console.Write(b.GetValue() + " ");
                PostOrder(b.GetRight());
            }
        }
        
        public static bool IsLeave(BinNode<int> b)
        {
            if (b != null)
            {
                if (!b.HasRight() && !b.HasLeft())
                    return true;
            }
            return false;
        }
        public static int CountLeaves(BinNode<int> b)
        {
            if (b == null)
                return 0;

            if (IsLeave(b))
                return 1;
            return CountLeaves(b.GetLeft())+CountLeaves(b.GetRight());
        }

        public static int SumLeaves(BinNode<int> b)
        {
            if (b == null)
                return 0;
            if (IsLeave(b))
                return b.GetValue();
            return SumLeaves(b.GetLeft()) + SumLeaves(b.GetRight());
        }

        public static int CountNodes(BinNode<int> b)
        {
            if (b == null)
                return 0;
           // if (b.HasRight() && b.HasLeft())
                return 1+ CountNodes(b.GetLeft())+ CountNodes(b.GetRight()) ;
        }

        public static int SumNodes(BinNode<int> b)
        {
            if (b == null)
                return 0;
            return b.GetValue() + SumNodes(b.GetLeft()) + SumNodes(b.GetRight());
        }
        public static int CountLeftNodes(BinNode<int> b)
        {
            if (b == null || IsLeave(b))
                return 0;
            //if(!b.HasLeft())
            //    return CountLeftNodes(b.GetRight());

            return 1 + CountLeftNodes(b.GetLeft());

        }

        public static int CountRightNodes(BinNode<int> b)
        {
            if (b == null || IsLeave(b))
                return 0;
            return 1 + CountRightNodes(b.GetRight());
        }
        public static int SumLeftNodes(BinNode<int> b)
        {
            if (b == null)
                return 0;
            //if (!b.HasLeft())
            //    return SumLeftNodes(b.GetRight());
            return b.GetValue() + SumLeftNodes(b.GetLeft()) + SumLeftNodes(b.GetRight());

        }
    }
}
