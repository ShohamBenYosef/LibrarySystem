using LibrarySystem.Models;
using LibrarySystem.Services;

namespace LibrarySystem.Repositories
{
    public class InMemoryUserRepository : IUserRepository
    {
        private readonly List<User> _users = new List<User>();
        private int _nextId = 1;



        public User GetUserById(int id)
        {
            return _users.FirstOrDefault(u => u.Id == id);
        }

        public IEnumerable<User> GetAllUsers()
        {
            return _users;
        }

        public void AddUser(User user)
        { 
            if (user == null)
            {
                throw new ArgumentNullException(nameof(user));
            }
            user.Id = _nextId++;
            _users.Add(user);
        }


    }
}