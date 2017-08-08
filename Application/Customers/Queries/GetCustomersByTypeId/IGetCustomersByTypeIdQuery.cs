using System.Collections.Generic;

namespace Application.Customers.Queries.GetCustomersByTypeId
{
    public interface IGetCustomersByTypeIdQuery
    {
        List<GetCustomersByTypeIdModel> Execute(int customerTypeId);
    }
}