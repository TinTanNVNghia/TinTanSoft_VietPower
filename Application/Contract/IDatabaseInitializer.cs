namespace Application.Contract
{
    public interface IDatabaseInitializer
    {
        void SetDatabaseService(IDatabaseService databaseService);
        void Seed();
    }
}