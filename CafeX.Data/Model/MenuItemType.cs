using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeX.DataObjects.Model
{
    [Flags]
    public enum MenuItemType
    {
        Drink =1,
        Sandwich=2,
        Hot=4,
        Cold=8
    } 
   
}
