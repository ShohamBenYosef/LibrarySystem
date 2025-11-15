using LibrarySystem.Models;

namespace LibrarySystem.Services
{
    public interface IUserRepository
    {
        User GetUserById(int id);
        IEnumerable<User> GetAllUsers();
        void AddUser(User user);
    }
}