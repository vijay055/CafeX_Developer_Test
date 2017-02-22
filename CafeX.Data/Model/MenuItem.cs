using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeX.DataObjects.Model
{
    public class MenuItem
    {
        /// <summary>
        /// food/drink item number
        /// </summary>
        public int Id { get; set; }
        
        /// <summary>
        /// food/drink anme
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// food/drink unit price
        /// </summary>
        public double Price { get; set; }

        /// <summary>
        /// MenuItemType 
        /// Drink, Food, Hot, Cold
        /// or can be combination drink/cold,drink/Hot,Sandwich/cold,Sandwich/Hot
        /// </summary>
        public MenuItemType MenuItemType{ get; set; }  

    }
}
