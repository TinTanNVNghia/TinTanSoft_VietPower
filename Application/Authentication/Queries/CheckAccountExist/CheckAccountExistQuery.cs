using System.Linq;
using Application.Contract;
using Common.Services;

namespace Application.Authentication.Queries.CheckAccountExist
{
    public class CheckAccountExistQuery : ICheckAccountExistQuery
    {
        private readonly IDatabaseService _databaseService;
        private readonly IHashService _hashService;

        public CheckAccountExistQuery(IDatabaseService databaseService, IHashService hashService)
        {
            _databaseService = databaseService;
            _hashService = hashService;
        }

        public bool Execute(string username, string password)
        {
            var inputPasswordHashed = _hashService.Hash(password);
            var query = from account in _databaseService.Accounts
                where account.UserName == username && account.Password == inputPasswordHashed
                select account;
            var accountCheck = query.First();
            return accountCheck != null;
        }
    }
}