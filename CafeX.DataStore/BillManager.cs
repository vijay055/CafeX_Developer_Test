using CafeX.Abstractions;
using CafeX.DataObjects.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeX.DataStore
{
    public class BillManager
    {
        IDataService _dataService = null;
        decimal _tip = 0.00m;

        public BillManager(IDataService dataservice,decimal tip)
        {
            _dataService = dataservice;
            _tip = tip;
        }

        /// <summary>
        /// Gives the billamount(billamount + tip) taking customer order
        /// </summary>
        /// <param name="custOrder"></param>
        /// <returns></returns>
        public decimal GetBillAmount(List<CustomerOrder> custOrder)
        {
            decimal amount = _dataService.GetBillAmount(custOrder);

            return amount +_tip;
        }

    }
}
