using System.Collections.Generic;

namespace Application.Products.Queries.GetProducts
{
    public interface IGetProductsQuery
    {
        List<GetProductsModel> Execute(int companyId);
    }
}