namespace Application.Customers.Queries.GetCustomerById
{
    public interface IGetCustomerByIdQuery
    {
        GetCustomerByIdModel Execute(int customerId);
    }
}