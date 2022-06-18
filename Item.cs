using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace minigames
{
    internal class Item
    {
        public string Name { get; private set; }
        public int Quantity { get; private set; }   

        public Item(string name, int quantity)
        {
            Name = name;
            Quantity=quantity;
        }
    }
}
