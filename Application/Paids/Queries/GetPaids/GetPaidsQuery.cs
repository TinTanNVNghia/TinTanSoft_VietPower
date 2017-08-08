using System.Collections.Generic;
using System.Linq;
using Application.Contract;

namespace Application.Paids.Queries.GetPaids
{
    public class GetPaidsQuery : IGetPaidsQuery
    {
        private readonly IDatabaseService _databaseService;

        public GetPaidsQuery(IDatabaseService databaseService)
        {
            _databaseService = databaseService;
        }

        public List<GetPaidsModel> Execute(int companyId)
        {
            var query = from paid in _databaseService.Paids
                join created in _databaseService.Accounts on paid.CreatedBy equals created.Id
                join updated in _databaseService.Accounts on paid.UpdatedBy equals updated.Id
                join sale in _databaseService.Sales on paid.SaleId equals sale.Id
                join customer in _databaseService.Customers on paid.CustomerId equals customer.Id
                where paid.CompanyId == companyId
                select new GetPaidsModel()
                {
                    Id = paid.Id,
                    SaleCode = sale.Code,
                    SaleDate = sale.SaleDate,
                    CustomerName = customer.Name,
                    CustomerCode = customer.Code,
                    PaidDate = paid.PaidDate,
                    PaidValue = paid.PaidValue,
                    Note = paid.Note,
                    CreatedAt = paid.CreatedAt,
                    UpdatedAt = paid.UpdatedAt,
                    CreatedBy = created.UserName,
                    UpdatedBy = updated.UserName
                };
            return query.ToList();
        }
    }
}