using System.Collections.Generic;

namespace Application.CustomerTypes.Queries.GetCustomerTypes
{
    public interface IGetCustomerTypesQuery
    {
        List<GetCustomerTypesModel> Execute(int companyId);
    }
}