using System;
using System.Collections.Generic;
using Application.Contract;
using Common.Services;

namespace Persistence.Context
{
    public class DatabaseInitializer : IDatabaseInitializer
    {
        private IDatabaseService _databaseService;
        private readonly IHashService _hashService;

        public DatabaseInitializer(IHashService hashService)
        {
            _hashService = hashService;
        }

        public void SetDatabaseService(IDatabaseService databaseService)
        {
            _databaseService = databaseService;
        }

        public void Seed()
        {
            this.SeedCompany();
            this.SeedRole();
            this.SeedAccount();
            this.SeedTax();
            this.SeedCost();
            this.SeedCurrency();
            _databaseService.Save();
        }

        public void SeedCompany()
        {
            var company = new Domain.Company()
            {
                Code = "VietPower",
                Name = "Công Ty TNHH Sản Xuất Tủ Bảng Điện VietPower",
                Address = "KM1855 Đường Võ Nguyên Giáp (Quốc Lộ 1A), Xã Phước Tân, Thành Phố Biên Hòa, Tỉnh Đồng Nai",
                Phone = "(84-61) 2860669 / 2860779",
                PhoneBackup = "",
                CompanyAccountId = 1,
                CreatedAt = new DateTime(),
                UpdatedAt = new DateTime(),
                CreatedBy = 1,
                UpdatedBy = 1
            };
            _databaseService.Companies.Add(company);
        }

        public void SeedRole()
        {
            var roles = new List<Domain.Role>()
            {
                new Domain.Role()
                {
                    Code = "QLND",
                    Name = "Quản Lý Người Dùng",
                    Description = "Quyền Quản Lý Người Dùng",
                    Active = true,
                    CreatedAt = new DateTime(),
                    UpdatedAt = new DateTime(),
                    CreatedBy = 1,
                    UpdatedBy = 1
                },
                new Domain.Role()
                {
                    Code = "QLDMK",
                    Name = "Quản Lý Danh Mục Kho",
                    Description = "Quyền Quản Lý Danh Mục Kho",
                    Active = true,
                    CreatedAt = new DateTime(),
                    UpdatedAt = new DateTime(),
                    CreatedBy = 1,
                    UpdatedBy = 1
                },
                new Domain.Role()
                {
                    Code = "QLDMSP",
                    Name = "Quản Lý Danh Mục Sản Phẩm",
                    Description = "Quyền Quản Lý Danh Mục Sản Phẩm",
                    Active = true,
                    CreatedAt = new DateTime(),
                    UpdatedAt = new DateTime(),
                    CreatedBy = 1,
                    UpdatedBy = 1
                },
                new Domain.Role()
                {
                    Code = "QLDMKH",
                    Name = "Quản Lý Danh Mục Khách Hàng",
                    Description = "Quyền Quản Lý Danh Mục Khách Hàng",
                    Active = true,
                    CreatedAt = new DateTime(),
                    UpdatedAt = new DateTime(),
                    CreatedBy = 1,
                    UpdatedBy = 1
                },
                new Domain.Role()
                {
                    Code = "QLCNKH",
                    Name = "Quản Lý Công Nợ Khách Hàng",
                    Description = "Quyền Quản Lý Công Nợ Khách Hàng",
                    Active = true,
                    CreatedAt = new DateTime(),
                    UpdatedAt = new DateTime(),
                    CreatedBy = 1,
                    UpdatedBy = 1
                },
                new Domain.Role()
                {
                    Code = "QLĐH",
                    Name = "Quản Lý Đơn Hàng",
                    Description = "Quyền Quản Lý Đơn Hàng",
                    Active = true,
                    CreatedAt = new DateTime(),
                    UpdatedAt = new DateTime(),
                    CreatedBy = 1,
                    UpdatedBy = 1
                },
                new Domain.Role()
                {
                    Code = "QLNK",
                    Name = "Quản Lý Nhập Kho",
                    Description = "Quyền Quản Lý Nhập Kho",
                    Active = true,
                    CreatedAt = new DateTime(),
                    UpdatedAt = new DateTime(),
                    CreatedBy = 1,
                    UpdatedBy = 1
                },
                new Domain.Role()
                {
                    Code = "QLXK",
                    Name = "Quản Lý Xuất Kho",
                    Description = "Quyền Quản Lý Xuất Kho",
                    Active = true,
                    CreatedAt = new DateTime(),
                    UpdatedAt = new DateTime(),
                    CreatedBy = 1,
                    UpdatedBy = 1
                },
                new Domain.Role()
                {
                    Code = "TK",
                    Name = "Thẻ Kho",
                    Description = "Quyền Xem Thẻ Kho",
                    Active = true,
                    CreatedAt = new DateTime(),
                    UpdatedAt = new DateTime(),
                    CreatedBy = 1,
                    UpdatedBy = 1
                },
                new Domain.Role()
                {
                    Code = "QLGH",
                    Name = "Quản Lý Giao Hàng",
                    Description = "Quyền Quản Lý Giao Hàng",
                    Active = true,
                    CreatedAt = new DateTime(),
                    UpdatedAt = new DateTime(),
                    CreatedBy = 1,
                    UpdatedBy = 1
                },
                new Domain.Role()
                {
                    Code = "BC",
                    Name = "Báo Cáo",
                    Description = "Quyền Xem Báo Cáo",
                    Active = true,
                    CreatedAt = new DateTime(),
                    UpdatedAt = new DateTime(),
                    CreatedBy = 1,
                    UpdatedBy = 1
                }
            };
            _databaseService.Roles.AddRange(roles);
        }

        public void SeedAccount()
        {
            var account = new Domain.Account()
            {
                UserName = "admin",
                Password = _hashService.Hash("admin"),
                CreatedAt = new DateTime(),
                UpdatedAt = new DateTime(),
                CreatedBy = 1,
                UpdatedBy = 1
            };
            _databaseService.Accounts.Add(account);
        }

        public void SeedPermission()
        {
            var permissions = new List<Domain.Permission>()
            {
                new Domain.Permission()
                {
                    UserId = 1,
                    RoleId = 1,
                    CreatedAt = new DateTime(),
                    UpdatedAt = new DateTime(),
                    CreatedBy = 1,
                    UpdatedBy = 1
                },
                new Domain.Permission()
                {
                    UserId = 1,
                    RoleId = 2,
                    CreatedAt = new DateTime(),
                    UpdatedAt = new DateTime(),
                    CreatedBy = 1,
                    UpdatedBy = 1
                },
                new Domain.Permission()
                {
                    UserId = 1,
                    RoleId = 3,
                    CreatedAt = new DateTime(),
                    UpdatedAt = new DateTime(),
                    CreatedBy = 1,
                    UpdatedBy = 1
                },
                new Domain.Permission()
                {
                    UserId = 1,
                    RoleId = 4,
                    CreatedAt = new DateTime(),
                    UpdatedAt = new DateTime(),
                    CreatedBy = 1,
                    UpdatedBy = 1
                },
                new Domain.Permission()
                {
                    UserId = 1,
                    RoleId = 5,
                    CreatedAt = new DateTime(),
                    UpdatedAt = new DateTime(),
                    CreatedBy = 1,
                    UpdatedBy = 1
                },
                new Domain.Permission()
                {
                    UserId = 1,
                    RoleId = 6,
                    CreatedAt = new DateTime(),
                    UpdatedAt = new DateTime(),
                    CreatedBy = 1,
                    UpdatedBy = 1
                },
                new Domain.Permission()
                {
                    UserId = 1,
                    RoleId = 7,
                    CreatedAt = new DateTime(),
                    UpdatedAt = new DateTime(),
                    CreatedBy = 1,
                    UpdatedBy = 1
                },
                new Domain.Permission()
                {
                    UserId = 1,
                    RoleId = 8,
                    CreatedAt = new DateTime(),
                    UpdatedAt = new DateTime(),
                    CreatedBy = 1,
                    UpdatedBy = 1
                },
                new Domain.Permission()
                {
                    UserId = 1,
                    RoleId = 9,
                    CreatedAt = new DateTime(),
                    UpdatedAt = new DateTime(),
                    CreatedBy = 1,
                    UpdatedBy = 1
                },
                new Domain.Permission()
                {
                    UserId = 1,
                    RoleId = 10,
                    CreatedAt = new DateTime(),
                    UpdatedAt = new DateTime(),
                    CreatedBy = 1,
                    UpdatedBy = 1
                },new Domain.Permission()
                {
                    UserId = 1,
                    RoleId = 11,
                    CreatedAt = new DateTime(),
                    UpdatedAt = new DateTime(),
                    CreatedBy = 1,
                    UpdatedBy = 1
                } 
            };
            _databaseService.Permissions.AddRange(permissions);
        }

        public void SeedTax()
        {
            var tax = new Domain.Tax()
            {
                Code = "VAT",
                Name = "Thuế Giá Trị Gia Tăng",
                Description = "",
                Active = true,
                CreatedAt = new DateTime(),
                UpdatedAt = new DateTime(),
                CreatedBy = 1,
                UpdatedBy = 1
            };
            _databaseService.Taxs.Add(tax);
        }

        public void SeedCost()
        {
            var cost = new Domain.Cost()
            {
                Code = "PGH",
                Name = "Phí Giao Hàng",
                Description = "",
                Active = true,
                CreatedAt = new DateTime(),
                UpdatedAt = new DateTime(),
                CreatedBy = 1,
                UpdatedBy = 1
            };
            _databaseService.Costs.Add(cost);
        }

        public void SeedCurrency()
        {
            var currency = new Domain.Currency()
            {
                Code = "VND",
                Name = "Việt Nam Đồng",
                Description = "",
                Active = true,
                DefaultValuePerVnd = 1,
                CreatedAt = new DateTime(),
                UpdatedAt = new DateTime(),
                CreatedBy = 1,
                UpdatedBy = 1
            };
            _databaseService.Currencies.Add(currency);
        }
    }
}