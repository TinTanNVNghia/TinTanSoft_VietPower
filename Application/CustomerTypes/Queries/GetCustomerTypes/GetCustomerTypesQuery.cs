using System.Collections.Generic;
using System.Linq;
using Application.Contract;

namespace Application.CustomerTypes.Queries.GetCustomerTypes
{
    public class GetCustomerTypesQuery : IGetCustomerTypesQuery
    {
        private readonly IDatabaseService _databaseService;

        public GetCustomerTypesQuery(IDatabaseService databaseService)
        {
            _databaseService = databaseService;
        }

        public List<GetCustomerTypesModel> Execute(int companyId)
        {
            var query = from customerType in _databaseService.CustomerTypes
                join created in _databaseService.Accounts on customerType.CreatedBy equals created.Id
                join updated in _databaseService.Accounts on customerType.UpdatedBy equals updated.Id
                where customerType.CompanyId == companyId
                select new GetCustomerTypesModel()
                {
                    Id = customerType.Id,
                    Code = customerType.Code,
                    Name = customerType.Name,
                    Description = customerType.Description,
                    Active = customerType.Active,
                    CreatedAt = customerType.CreatedAt,
                    UpdatedAt = customerType.UpdatedAt,
                    CreatedBy = created.UserName,
                    UpdatedBy = updated.UserName
                };
            return query.ToList();
        }
    }
}