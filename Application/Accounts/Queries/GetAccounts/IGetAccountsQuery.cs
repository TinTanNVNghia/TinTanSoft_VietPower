using System.Collections.Generic;

namespace Application.Accounts.Queries.GetAccounts
{
    public interface IGetAccountsQuery
    {
        List<GetAccountsModel> Execute();
    }
}