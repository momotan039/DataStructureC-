using mahat_21_A.Lists;
using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mahat_21_A
{
    internal class Program2
    {
        static BinNode<int> bin = new BinNode<int>(20);
        static void BuildBinNode()
        {
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
        static void Main2(string[] args)
        {
            BuildBinNode();
            Console.WriteLine();
            Console.WriteLine("Sum nodes eheed:" + BinNode<int>.CountNodesHave2childBigerBrother(bin));
            Console.WriteLine("Sum nodes that left leaves> right leaves:" + BinNode<int>.fun(bin));
            Console.ReadKey();
        }

        static void Ques1()
        {
            Tablet t = new Tablet("t1", "k1", 'W', 1000, 888);
            Tablet t1 = new Tablet("t2", "k2", 'A', 800, 755);
            Tablet t2 = new Tablet("t3", "k3", 'I', 900, 360);
            Tablet t3 = new Tablet("t4", "k4", 'A', 500, 1500);
            Store store = new Store();
            store.AddTablet(t);
            store.AddTablet(t1);
            store.AddTablet(t1);
            store.AddTablet(t2);
            store.AddTablet(t2);
            store.AddTablet(t3);
            store.SortStore();
        }
    }
    
}
