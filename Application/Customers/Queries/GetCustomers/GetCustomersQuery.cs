﻿using System.Collections.Generic;
using System.Linq;
using Application.Contract;

namespace Application.Customers.Queries.GetCustomers
{
    public class GetCustomersQuery : IGetCustomersQuery
    {
        private readonly IDatabaseService _databaseService;

        public GetCustomersQuery(IDatabaseService databaseService)
        {
            _databaseService = databaseService;
        }

        public List<GetCustomersModel> Execute(int companyId)
        {
            var query = from customer in _databaseService.Customers
                join created in _databaseService.Accounts on customer.CreatedBy equals created.Id
                join updated in _databaseService.Accounts on customer.UpdatedBy equals updated.Id
                join gender in _databaseService.Genders on customer.GenderId equals gender.Id
                join customerType in _databaseService.CustomerTypes on customer.CustomerTypeId equals customerType.Id
                join contact in _databaseService.Contacts on customer.ContactId equals contact.Id
                where customer.CompanyId == companyId
                select new GetCustomersModel()
                {
                    Id = customer.Id,
                    Code = customer.Code,
                    Name = customer.Name,
                    Address = customer.Address,
                    Email = customer.Email,
                    Phone = customer.Phone,
                    PhoneBackup = customer.PhoneBackup,
                    Gender = gender.Name,
                    CustomerType = customerType.Name,
                    CustomerTypeCode = customerType.Code,
                    Contact = contact.FullName,
                    ContactPhone = contact.Phone,
                    BankAccountName = customer.BankAccountName,
                    BankAccountNumber = customer.BankAccountNumber,
                    BankName = customer.BankName,
                    TaxNumber = customer.TaxNumber,
                    DeductionPercent = customer.DeductionPercent,
                    Active = customer.Active,
                    CreatedAt = customer.CreatedAt,
                    UpdatedAt = customer.UpdatedAt,
                    CreatedBy = created.UserName,
                    UpdatedBy = updated.UserName
                };
            return query.ToList();
        }
    }
}