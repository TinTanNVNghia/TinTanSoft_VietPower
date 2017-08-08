namespace Application.Authentication.Queries.CheckAccountExist
{
    public interface ICheckAccountExistQuery
    {
        bool Execute(string username, string password);
    }
}