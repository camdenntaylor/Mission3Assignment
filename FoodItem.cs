using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Mission3Assignment
{
    public class FoodItem
    {
        public string Name { get; set; }
        public string Category { get; set; }
        public string Quantity { get; set; }
        public string Expdate { get; set; }

        public FoodItem(string name, string category, string quantity, string expdate)
        {
            Name = name;
            Category = category;
            Quantity = quantity;
            Expdate = expdate;

        }

    }
}
