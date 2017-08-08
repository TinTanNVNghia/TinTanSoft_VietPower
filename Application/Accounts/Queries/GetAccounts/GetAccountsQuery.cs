using System.Collections.Generic;
using System.Linq;
using Application.Contract;
using Application.Departments.Commands.Create;

namespace Application.Accounts.Queries.GetAccounts
{
    public class GetAccountsQuery : IGetAccountsQuery
    {
        private readonly IDatabaseService _databaseService;

        public GetAccountsQuery(IDatabaseService databaseService)
        {
            _databaseService = databaseService;
        }

        public List<GetAccountsModel> Execute()
        {
            var query = from account in _databaseService.Accounts
                join created in _databaseService.Accounts on account.CreatedBy equals created.Id
                join updated in _databaseService.Accounts on account.UpdatedBy equals updated.Id 
                select new GetAccountsModel()
                {
                    Id = account.Id,
                    UserName = account.UserName,
                    FullName = account.FullName,
                    Email = account.Email,
                    Phone = account.Phone,
                    PhoneBackup = account.PhoneBackup,
                    Age = account.Age,
                    DayOfBirth = account.DayOfBirth,
                    GovernmentId = account.GovernmentId,
                    Address = account.Address,
                    Active = account.Active,
                    Note = account.Note,
                    GenderId = account.GenderId,
                    DepartmentId = account.DepartmentId,
                    PositionId = account.PositionId,
                    BranchId = account.BranchId,
                    RoleId = account.RoleId,
                    CompanyId = account.CompanyId,
                    CreatedAt = account.CreatedAt,
                    UpdatedAt = account.UpdatedAt,
                    CreatedBy = created.UserName,
                    UpdatedBy = updated.UserName
                };
            return query.ToList();
        }
    }
}