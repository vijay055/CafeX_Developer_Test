using CafeX.DataObjects.Model;
using CafeX.DataStore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeX
{
    class Program
    {
         
        static void Main(string[] args)
        {
            // Create the data context
            MockData.MockData mockdata = new MockData.MockData();

            //print menu
            Console.WriteLine(string.Join(Environment.NewLine,mockdata.CafeXMenu.Select(x=>x.Name +" "+ x.Price + " " + x.MenuItemType).ToList()));

            //create the order
            List<CustomerOrder> OrderList  = new List<CustomerOrder>();
            OrderList.Add(new CustomerOrder() { ItemNumber = 100, Quantity = 1 });
            OrderList.Add(new CustomerOrder() { ItemNumber = 101, Quantity = 1 });
            OrderList.Add(new CustomerOrder() { ItemNumber = 102, Quantity = 1 });

            //Create the billmanager and pass the tip
            BillManager bilmanager = new BillManager(mockdata,5.00m);


            decimal billamount = bilmanager.GetBillAmount(OrderList);
            //print the bill amount (inlcudes tip)
            Console.WriteLine("Bill amount = {0:C} ", billamount);

        }
    }
}
