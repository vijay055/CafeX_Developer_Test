using CafeX.DataObjects.Model;
using System.Collections.Generic;

namespace CafeX.Abstractions
{
    public interface IDataService
    {
        decimal GetBillAmount(List<CustomerOrder> customerOrder);

        decimal GetBillAmountWithServiceCharge(List<CustomerOrder> customerOrder);
    }
}
