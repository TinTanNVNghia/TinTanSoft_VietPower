using System.Collections.Generic;

namespace Application.Paids.Queries.GetPaidsByCustomerId
{
    public interface IGetPaidsByCustomerIdQuery
    {
        List<GetPaidsByCustomerIdModel> Execute(int customerId);
    }
}