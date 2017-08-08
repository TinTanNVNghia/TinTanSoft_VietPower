using System.Collections.Generic;

namespace Application.Products.Queries.GetProductsByCategoryId
{
    public interface IGetProductsByCategoryIdQuery
    {
        List<GetProductsByCategoryIdModel> Execute(int categoryId);
    }
}