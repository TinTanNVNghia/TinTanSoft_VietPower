using Application.Accounts.Queries.GetAccounts;
using Microsoft.AspNetCore.Mvc;

namespace Service.Controllers
{
    public class AccountController : BaseController
    {
        private readonly IGetAccountsQuery _getAccountsQuery;

        public AccountController(IGetAccountsQuery getAccountsQuery)
        {
            _getAccountsQuery = getAccountsQuery;
        }

        [HttpGet]
        public IActionResult Get()
        {
            var accounts = _getAccountsQuery.Execute();
            if (accounts == null)
            {
                return NotFound();
            }
            return Ok(accounts);
        }
    }
}