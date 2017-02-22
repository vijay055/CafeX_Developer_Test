using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeX.DataObjects.Model
{
    /// <summary>
    /// CustomerOrder data object 
    /// ItemNumber ( menu item number)  and quantity of items
    /// </summary>
    public class CustomerOrder
    {
        public int ItemNumber { get; set; }
        public int Quantity { get; set; }
    }
}
