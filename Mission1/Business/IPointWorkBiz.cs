using Mission1.Model;
using System.Collections.Generic;

namespace Mission1.Business
{
    public interface IPointWorkBiz
    {
        List<Customer> GetCustomersSortedByLastVisitDate();
        List<Customer> GetCustomersSortedByVisitCount();
        Customer GetCustomer(string phoneNo);
    }
}
