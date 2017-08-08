using System.Collections.Generic;

namespace Application.Customers.Queries.GetCustomers
{
    public interface IGetCustomersQuery
    {
        List<GetCustomersModel> Execute(int companyId);
    }
}