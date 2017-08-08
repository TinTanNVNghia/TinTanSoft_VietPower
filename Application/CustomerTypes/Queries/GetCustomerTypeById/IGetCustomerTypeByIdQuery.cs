namespace Application.CustomerTypes.Queries.GetCustomerTypeById
{
    public interface IGetCustomerTypeByIdQuery
    {
        GetCustomerTypeByIdModel Execute(int customerTypeId);
    }
}