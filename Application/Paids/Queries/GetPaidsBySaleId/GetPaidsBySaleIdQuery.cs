using System.Collections.Generic;
using System.Linq;
using Application.Contract;

namespace Application.Paids.Queries.GetPaidsBySaleId
{
    public class GetPaidsBySaleIdQuery : IGetPaidsBySaleIdQuery
    {
        private readonly IDatabaseService _databaseService;

        public GetPaidsBySaleIdQuery(IDatabaseService databaseService)
        {
            _databaseService = databaseService;
        }

        public List<GetPaidsBySaleIdModel> Execute(int saleId)
        {
            var query = from paid in _databaseService.Paids
                join created in _databaseService.Accounts on paid.CreatedBy equals created.Id
                join updated in _databaseService.Accounts on paid.UpdatedBy equals updated.Id
                join sale in _databaseService.Sales on paid.SaleId equals sale.Id
                join customer in _databaseService.Customers on paid.CustomerId equals customer.Id
                where paid.SaleId == saleId
                select new GetPaidsBySaleIdModel()
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