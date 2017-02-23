using Microsoft.VisualStudio.TestTools.UnitTesting;
using CafeX.DataStore;
using System.Collections.Generic;
using CafeX.DataObjects.Model;

namespace CafeX.MockData.Tests
{
    [TestClass()]
    public class BillManagerTests
    {
        [TestMethod()]
        public void GetBillAmountWithServiceChargeTest_Pass()
        {
            // arrange  
            decimal tip = 5.00m;
            decimal expected = 8.85m;
            BillManager billmanager = new BillManager(new MockData(), tip);
            List<CustomerOrder> orderList = new List<CustomerOrder>();
            orderList.Add(new CustomerOrder() { ItemNumber = 100, Quantity = 1 });
            orderList.Add(new CustomerOrder() { ItemNumber = 101, Quantity = 1 });
            orderList.Add(new CustomerOrder() { ItemNumber = 102, Quantity = 1 });

            // act  
            decimal actual = billmanager.GetBillAmountWithServiceCharge(orderList);
            // assert  
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void GetBillAmountTest_Pass()
        {
            // arrange  
            decimal tip = 5.00m;
            decimal expected = 8.50m;
            BillManager billmanager = new BillManager(new MockData(), tip);
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