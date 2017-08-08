using System.Linq;
using Application.Contract;

namespace Application.CustomerTypes.Queries.GetCustomerTypeById
{
    public class GetCustomerTypeByIdQuery : IGetCustomerTypeByIdQuery
    {
        private readonly IDatabaseService _databaseService;

        public GetCustomerTypeByIdQuery(IDatabaseService databaseService)
        {
            _databaseService = databaseService;
        }

        public GetCustomerTypeByIdModel Execute(int customerTypeId)
        {
            var query = from customerType in _databaseService.CustomerTypes
                join created in _databaseService.Accounts on customerType.CreatedBy equals created.Id
                join updated in _databaseService.Accounts on customerType.UpdatedBy equals updated.Id
                where customerType.Id == customerTypeId
                select new GetCustomerTypeByIdModel()
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
            return query.First();
        }
    }
}