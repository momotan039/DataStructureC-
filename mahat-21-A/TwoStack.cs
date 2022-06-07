using mahat_21_A.Lists;
using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mahat_21_A
{
    class TwoStack
    {
        public Stack<int> numbers = new Stack<int>();
        public Stack<int> sums = new Stack<int>();
        public TwoStack(Stack<int> nums)
        {
            //3 2 1
            //1 2 3
            this.numbers = nums;
            Stack<int> temp = new Stack<int>();
            while (!numbers.IsEmpty())
                temp.Push(numbers.Pop());
            int num = temp.Pop();
            numbers.Push(num);
            sums.Push(num);
            while (!temp.IsEmpty())
            {
                num = temp.Pop();
                numbers.Push(num);
                sums.Push(sums.Top() + num);
            }
        }
        public void EraseNum(int x)
        {
            Stack<int> tempNums = new Stack<int>();
            while (!numbers.IsEmpty())
            {
                int n = numbers.Top();
                if (numbers.Top() != x)
                    tempNums.Push(n);
                numbers.Pop();
            }
            this.numbers = tempNums;
            //empty sums
            Stack<int> temp = new Stack<int>();
            while (!numbers.IsEmpty())
            {
                temp.Push(numbers.Pop());
                sums.Pop();
            }
            int num = temp.Pop();
            numbers.Push(num);
            sums.Push(num);
            while (!temp.IsEmpty())
            {
                num = temp.Pop();
                numbers.Push(num);
                sums.Push(sums.Top() + num);
            }
        }
        public Stack<int> GetNums(int x)
        {
            int pop = sums.Pop();
            //   Stack<int> result = new Stack<int>();
            while (!sums.IsEmpty() && pop != x)
            {
                pop = sums.Pop();
                numbers.Pop();
            }
            return numbers;
        }

    }
}
