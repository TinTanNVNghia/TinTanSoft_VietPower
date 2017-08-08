using System.Collections.Generic;
using System.Linq;
using Application.Contract;

namespace Application.Accounts.Queries.GetAccountById
{
    public class GetAccountByIdQuery : IGetAccountByIdQuery
    {
        private readonly IDatabaseService _databaseService;

        public GetAccountByIdQuery(IDatabaseService databaseService)
        {
            _databaseService = databaseService;
        }

        public GetAccountByIdModel Execute(int accountId)
        {
            var query = from account in _databaseService.Accounts
                join created in _databaseService.Accounts on account.CreatedBy equals created.Id
                join updated in _databaseService.Accounts on account.UpdatedBy equals updated.Id 
                select new GetAccountByIdModel()
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
            return query.First();
        }
    }
}