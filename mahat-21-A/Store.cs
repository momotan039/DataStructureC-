using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mahat_21_A
{
    public class Store
    {
        Tablet[] tablets = new Tablet[1000];
        int[] systems = new int[3];
        public bool AddTablet(Tablet tab)
        {
            int index = (systems[0] + systems[1] + systems[2]);
            if (index == 1000)
                return false;
            for (int i = 0; tablets[i] != null && i < tablets.Length; i++)
            {
                if (tablets[i].IsSame(tab))
                {
                    tablets[i].price = Math.Max(tablets[i].price, tab.price);
                    break;
                }
            }
            tablets[index] = tab;
            if (tab.system == 'W')
                systems[0]++;
            else if (tab.system == 'A')
                systems[1]++;
            else
                systems[2]++;
            return true;
        }
        public int SortStore()
        {
            for (int i = 0; tablets[i] != null && i < tablets.Length - 1; i++)
            {
                for (int j = i + 1; tablets[j] != null && j < tablets.Length; j++)
                {
                    if (tablets[i].system == 'W')
                        break;
                    if (tablets[j].system == 'W' && (tablets[i].system == 'A' || tablets[i].system == 'I'))
                    {
                        Tablet t = tablets[i];
                        tablets[i] = tablets[j];
                        tablets[j] = t;
                    }
                    if (tablets[j].system == 'A' && tablets[i].system == 'I')
                    {
                        Tablet t = tablets[i];
                        tablets[i] = tablets[j];
                        tablets[j] = t;
                    }
                }
            }
            return 1000 - (systems[0] + systems[1] + systems[2]);
        }
    }

}
