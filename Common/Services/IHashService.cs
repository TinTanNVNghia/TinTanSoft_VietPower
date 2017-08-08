namespace Common.Services
{
    public interface IHashService
    {
        string Hash(string password);
        bool Compare(string inputPassword, string storedPassword);
    }
}