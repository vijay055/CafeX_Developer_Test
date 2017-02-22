using Microsoft.VisualStudio.TestTools.UnitTesting;
using CafeX.DataStore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CafeX.DataObjects.Model;

namespace CafeX.DataStore.Tests
{
    [TestClass()]
    public class BillManagerTests
    {
        [TestMethod()]
        public void GetBillAmountTest_Pass()
        {
            // arrange  
            decimal tip = 5.00m;
            decimal expected = 8.50m;
            BillManager billmanager = new BillManager(new MockData.MockData(), tip);
            List<CustomerOrder> orderList = new List<CustomerOrder>();
            orderList.Add(new CustomerOrder() { ItemNumber = 100, Quantity = 1 });
            orderList.Add(new CustomerOrder() { ItemNumber = 101, Quantity = 1 });
            orderList.Add(new CustomerOrder() { ItemNumber = 102, Quantity = 1 });
            
            // act  
            decimal actual = billmanager.GetBillAmount(orderList);
            // assert  
            Assert.AreEqual(expected, actual);
        }
    }
}