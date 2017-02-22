using CafeX.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CafeX.DataObjects.Model;

namespace CafeX.MockData
{

    /// <summary>
    /// Mock data service 
    /// </summary>
    public class MockData : IDataService
    {
        const decimal MaxServiceCharge = 20.00m;

        const decimal HotFoodServiceCharge = 0.20m;

        const decimal FoodServiceCharge = 0.10m;
        public MockData()
        {
            SetMenu();
        }

        /// <summary>
        /// property to hold the sample menu
        /// </summary>
        public List<MenuItem> CafeXMenu { get; set; }

        /// <summary>
        /// calculates the bill amount given the order items
        /// </summary>
        /// <param name="custorder"></param>
        /// <returns></returns>
        public decimal GetBillAmount(List<CustomerOrder> custorder)
        {
            decimal amount = (decimal)custorder.Sum(x => CafeXMenu.Where(i => i.Id == x.ItemNumber).FirstOrDefault().Price * x.Quantity);
        
            return amount;
        }

        /// <summary>
        /// sets the sample menu
        /// </summary>
        private void  SetMenu()
        {
            CafeXMenu =  new List<MenuItem>() { new MenuItem() { Id = 100, Name = "Cola", Price = 00.50, MenuItemType = MenuItemType.Drink | MenuItemType.Cold }, new MenuItem() { Id = 101, Name = "Coffee", Price = 1.00, MenuItemType = MenuItemType.Drink | MenuItemType.Hot}, new MenuItem() { Id = 102, Name = "Cheese Sandwich", Price = 2.00, MenuItemType = MenuItemType.Sandwich | MenuItemType.Cold}, new MenuItem() { Id = 103, Name = "Steak Sandwich", Price = 4.50, MenuItemType = MenuItemType.Sandwich | MenuItemType.Hot } };
        }
    }
}
