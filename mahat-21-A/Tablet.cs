using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mahat_21_A
{
    public class Tablet
    {
        public string Name { get; set; }
        public string Kind { get; set; }
        public char system { get; set; }
        public double size { get; set; }
        public double price { get; set; }
        public Tablet(string name, string kind, char system, double size, double price)
        {
            this.Name = name;
            this.Kind = kind;
            this.system = system;
            this.size = size;
            this.price = price;
        }
        public bool IsSame(Tablet other)
        {
            return (this.Name == other.Name && this.Kind == other.Kind &&
                this.size == other.size);
        }

    }

}
