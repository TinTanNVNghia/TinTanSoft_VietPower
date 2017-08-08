namespace Application.Products.Queries.GetProductById
{
    public interface IGetProductByIdQuery
    {
        GetProductByIdModel Execute(int productId);
    }
}