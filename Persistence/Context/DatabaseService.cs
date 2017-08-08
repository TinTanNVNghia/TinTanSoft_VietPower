using System.Linq;
using Application.Contract;
using Common.Settings;
using Domain;
using Microsoft.EntityFrameworkCore;
using Persistence.Configs;

namespace Persistence.Context
{
    public class DatabaseService : DbContext, IDatabaseService
    {
        #region Collection DbSet<Entity>

        public DbSet<Account> Accounts { get; set; }
        public DbSet<AccountantCode> AccountantCodes { get; set; }
        public DbSet<Barcode> Barcodes { get; set; }
        public DbSet<Branch> Branches { get; set; }
        public DbSet<Company> Companies { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<Cost> Costs { get; set; }
        public DbSet<Currency> Currencies { get; set; }
        public DbSet<CurrencyDetail> CurrencyDetails { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<CustomerType> CustomerTypes { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Expense> Expenses { get; set; }
        public DbSet<ExpenseCategory> ExpenseCategories { get; set; }
        public DbSet<Export> Exports { get; set; }
        public DbSet<ExportDetail> ExportDetails { get; set; }
        public DbSet<Gender> Genders { get; set; }
        public DbSet<History> Histories { get; set; }
        public DbSet<Import> Imports { get; set; }
        public DbSet<ImportDetail> ImportDetails { get; set; }
        public DbSet<Income> Incomes { get; set; }
        public DbSet<IncomeCategory> IncomeCategories { get; set; }
        public DbSet<Language> Languages { get; set; }
        public DbSet<OrderSupplier> OrderSuppliers { get; set; }
        public DbSet<OrderSupplierDetail> OrderSupplierDetails { get; set; }
        public DbSet<Paid> Paids { get; set; }
        public DbSet<Permission> Permissions { get; set; }
        public DbSet<Position> Positions { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<ProductBranch> ProductBranchs { get; set; }
        public DbSet<ProductCategory> ProductCategories { get; set; }
        public DbSet<ProductCategoryBranch> ProductCategoryBranchs { get; set; }
        public DbSet<QuotaBranch> QuotaBranchs { get; set; }
        public DbSet<QuotaWarehouse> QuotaWarehouses { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<Sale> Sales { get; set; }
        public DbSet<SaleDetail> SaleDetails { get; set; }
        public DbSet<Setting> Settings { get; set; }
        public DbSet<Supplier> Suppliers { get; set; }
        public DbSet<SupplierProduct> SupplierProducts { get; set; }
        public DbSet<Tax> Taxs { get; set; }
        public DbSet<Translate> Translates { get; set; }
        public DbSet<Unit> Units { get; set; }
        public DbSet<Warehouse> Warehouses { get; set; }

        #endregion

        private readonly IDatabaseInitializer _databaseInitializer;

        public DatabaseService(IDatabaseInitializer databaseInitializer)
        {
            _databaseInitializer = databaseInitializer;
            Database.EnsureCreated();
            if (!Accounts.Any())
            {
                _databaseInitializer.SetDatabaseService(this);
                databaseInitializer.Seed();
            }
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(AppSetting.ConnectionString);
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            #region Collection Entity Config

            new AccountConfig(builder.Entity<Account>());
            new AccountantCodeConfig(builder.Entity<AccountantCode>());
            new BarcodeConfig(builder.Entity<Barcode>());
            new BranchConfig(builder.Entity<Branch>());
            new CompanyConfig(builder.Entity<Company>());
            new ContactConfig(builder.Entity<Contact>());
            new CostConfig(builder.Entity<Cost>());
            new CurrencyConfig(builder.Entity<Currency>());
            new CurrencyDetailConfig(builder.Entity<CurrencyDetail>());
            new CustomerConfig(builder.Entity<Customer>());
            new CustomerTypeConfig(builder.Entity<CustomerType>());
            new DepartmentConfig(builder.Entity<Department>());
            new ExpenseCategoryConfig(builder.Entity<ExpenseCategory>());
            new ExpenseConfig(builder.Entity<Expense>());
            new ExportConfig(builder.Entity<Export>());
            new ExportDetailConfig(builder.Entity<ExportDetail>());
            new GenderConfig(builder.Entity<Gender>());
            new HistoryConfig(builder.Entity<History>());
            new ImportConfig(builder.Entity<Import>());
            new ImportDetailConfig(builder.Entity<ImportDetail>());
            new IncomeCategoryConfig(builder.Entity<IncomeCategory>());
            new IncomeConfig(builder.Entity<Income>());
            new LanguageConfig(builder.Entity<Language>());
            new OrderSupplierConfig(builder.Entity<OrderSupplier>());
            new OrderSupplierDetailConfig(builder.Entity<OrderSupplierDetail>());
            new PermissionConfig(builder.Entity<Permission>());
            new PositionConfig(builder.Entity<Position>());
            new ProductBranchConfig(builder.Entity<ProductBranch>());
            new ProductCategoryBranchConfig(builder.Entity<ProductCategoryBranch>());
            new ProductCategoryConfig(builder.Entity<ProductCategory>());
            new ProductConfig(builder.Entity<Product>());
            new QuotaBranchConfig(builder.Entity<QuotaBranch>());
            new QuotaWarehouseConfig(builder.Entity<QuotaWarehouse>());
            new RoleConfig(builder.Entity<Role>());
            new SaleConfig(builder.Entity<Sale>());
            new SaleDetailConfig(builder.Entity<SaleDetail>());
            new SettingConfig(builder.Entity<Setting>());
            new SupplierConfig(builder.Entity<Supplier>());
            new SupplierProductConfig(builder.Entity<SupplierProduct>());
            new TaxConfig(builder.Entity<Tax>());
            new TranslateConfig(builder.Entity<Translate>());
            new UnitConfig(builder.Entity<Unit>());
            new WarehouseConfig(builder.Entity<Warehouse>());

            #endregion
        }

        public void Save()
        {
            this.SaveChanges();
        }
    }
}