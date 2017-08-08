using System.Collections.Generic;

namespace Application.Accounts.Queries.GetAccountById
{
    public interface IGetAccountByIdQuery
    {
        GetAccountByIdModel Execute(int accountId);
    }
}