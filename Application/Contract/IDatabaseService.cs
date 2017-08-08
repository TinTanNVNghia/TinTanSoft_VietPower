using Microsoft.EntityFrameworkCore;

namespace Application.Contract
{
    public interface IDatabaseService
    {
        DbSet<Domain.Account> Accounts { get; set; }
        DbSet<Domain.AccountantCode> AccountantCodes { get; set; }
        DbSet<Domain.Barcode> Barcodes { get; set; }
        DbSet<Domain.Branch> Branches { get; set; }
        DbSet<Domain.Company> Companies { get; set; }
        DbSet<Domain.Contact> Contacts { get; set; }
        DbSet<Domain.Cost> Costs { get; set; }
        DbSet<Domain.Currency> Currencies { get; set; }
        DbSet<Domain.CurrencyDetail> CurrencyDetails { get; set; }
        DbSet<Domain.Customer> Customers { get; set; }
        DbSet<Domain.CustomerType> CustomerTypes { get; set; }
        DbSet<Domain.Department> Departments { get; set; }
        DbSet<Domain.Expense> Expenses { get; set; }
        DbSet<Domain.ExpenseCategory> ExpenseCategories { get; set; }
        DbSet<Domain.Export> Exports { get; set; }
        DbSet<Domain.ExportDetail> ExportDetails { get; set; }
        DbSet<Domain.Gender> Genders { get; set; }
        DbSet<Domain.History> Histories { get; set; }
        DbSet<Domain.Import> Imports { get; set; }
        DbSet<Domain.ImportDetail> ImportDetails { get; set; }
        DbSet<Domain.Income> Incomes { get; set; }
        DbSet<Domain.IncomeCategory> IncomeCategories { get; set; }
        DbSet<Domain.Language> Languages { get; set; }
        DbSet<Domain.OrderSupplier> OrderSuppliers { get; set; }
        DbSet<Domain.OrderSupplierDetail> OrderSupplierDetails { get; set; }
        DbSet<Domain.Paid> Paids { get; set; } 
        DbSet<Domain.Permission> Permissions { get; set; }
        DbSet<Domain.Position> Positions { get; set; }
        DbSet<Domain.Product> Products { get; set; }
        DbSet<Domain.ProductBranch> ProductBranchs { get; set; }
        DbSet<Domain.ProductCategory> ProductCategories { get; set; }
        DbSet<Domain.ProductCategoryBranch> ProductCategoryBranchs { get; set; }
        DbSet<Domain.QuotaBranch> QuotaBranchs { get; set; }
        DbSet<Domain.QuotaWarehouse> QuotaWarehouses { get; set; }
        DbSet<Domain.Role> Roles { get; set; }
        DbSet<Domain.Sale> Sales { get; set; }
        DbSet<Domain.SaleDetail> SaleDetails { get; set; }
        DbSet<Domain.Setting> Settings { get; set; }
        DbSet<Domain.Supplier> Suppliers { get; set; }
        DbSet<Domain.SupplierProduct> SupplierProducts { get; set; }
        DbSet<Domain.Tax> Taxs { get; set; }
        DbSet<Domain.Translate> Translates { get; set; }
        DbSet<Domain.Unit> Units { get; set; }
        DbSet<Domain.Warehouse> Warehouses { get; set; }
        void Save();
    }
}