using System.Collections.Generic;

namespace Application.ProductCategories.Queries.GetProductCategories
{
    public interface IGetProductCategoriesQuery
    {
        List<GetProductCategoriesModel> Execute();
    }
}