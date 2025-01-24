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
        public int Quantity { get; set; }
        public DateTime Expdate { get; set; }

        //assign user input variables to a FoodItem object
        public FoodItem(string name, string category, int quantity, DateTime expdate)
        {
            Name = name;
            Category = category;
            Quantity = quantity;
            Expdate = expdate;

        }

    }
}
