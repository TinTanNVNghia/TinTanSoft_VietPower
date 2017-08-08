using System.Collections.Generic;
using System.Linq;
using Application.Contract;

namespace Application.Products.Queries.GetProducts
{
    public class GetProductsQuery : IGetProductsQuery
    {
        private readonly IDatabaseService _databaseService;

        public GetProductsQuery(IDatabaseService databaseService)
        {
            _databaseService = databaseService;
        }

        public List<GetProductsModel> Execute(int companyId)
        {
            var query = from product in _databaseService.Products
                join category in _databaseService.ProductCategories on product.CategoryId equals category.Id
                join currency in _databaseService.Currencies on product.CurrencyId equals currency.Id
                join unit in _databaseService.Units on product.UnitId equals unit.Id
                join created in _databaseService.Accounts on product.CreatedBy equals created.Id
                join updated in _databaseService.Accounts on product.UpdatedBy equals updated.Id
                where product.CompanyId == companyId
                select new GetProductsModel()
                {
                    Id = product.Id,
                    Code = product.Code,
                    Name = product.Name,
                    Description = product.Description,
                    Production = product.Production,
                    CategoryName = category.Name,
                    CategoryCode = category.Code,
                    CurrencyCode = currency.Code,
                    Unit = unit.Code,
                    InUintPrice = product.InUintPrice,
                    OutUnitPrice = product.OutUnitPrice,
                    BaseUnitPrice = product.BaseUnitPrice,
                    QuotaWarehouse = product.QuotaWarehouse,
                    Active = product.Active,
                    CreatedAt = product.CreatedAt,
                    UpdatedAt = product.UpdatedAt,
                    CreatedBy = created.UserName,
                    UpdatedBy = updated.UserName
                };
            return query.ToList();
        }
    }
}