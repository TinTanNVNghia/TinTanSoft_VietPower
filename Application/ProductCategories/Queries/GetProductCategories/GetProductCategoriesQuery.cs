using System.Collections.Generic;
using System.Linq;
using Application.Contract;
using Domain;

namespace Application.ProductCategories.Queries.GetProductCategories
{
    public class GetProductCategoriesQuery : IGetProductCategoriesQuery
    {
        private readonly IDatabaseService _databaseService;

        public GetProductCategoriesQuery(IDatabaseService databaseService)
        {
            _databaseService = databaseService;
        }

        public List<GetProductCategoriesModel> Execute()
        {
            var query = from productCategory in _databaseService.ProductCategories
                join productCategoryParent in _databaseService.ProductCategories on productCategory.CategoryParentId equals productCategoryParent.Id
                join branch in _databaseService.Branches on productCategory.BranchId equals branch.Id
                join created in _databaseService.Accounts on productCategory.CreatedBy equals created.Id
                join updated in _databaseService.Accounts on productCategory.UpdatedBy equals updated.Id
                select new GetProductCategoriesModel()
                {
                    Id = productCategory.Id,
                    Code = productCategory.Code,
                    Name = productCategory.Name,
                    Description = productCategory.Description,
                    CategoryParent = productCategoryParent.Name,
                    Branch = branch.Name,
                    Active = productCategory.Active,
                    CreatedAt = productCategory.CreatedAt,
                    UpdatedAt = productCategory.UpdatedAt,
                    CreatedBy = created.UserName,
                    UpdatedBy = updated.UserName
                };
            return query.ToList();    
        }
    }
}