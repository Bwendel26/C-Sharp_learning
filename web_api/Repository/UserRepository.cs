using System.Collections.Generic;
using web_api.Models;
using System.Linq;

namespace web_api.Repository
{
    public class UserRepository : IUserRepository
    {
        private readonly UserDbContext _context;
        public UserRepository(UserDbContext ctx) 
        {
            _context = ctx;
        }

        public void Add(User user) 
        {
            _context.Users.Add(user);
            _context.SaveChanges();
        }
        public User Find(long id) 
        {
            return _context.Users.FirstOrDefault(u => u.UserId == id);
        }
        public IEnumerable<User> GetAll() 
        {
            return _context.Users.ToList();
        }
        public void Remove(long id)
        {
            var entity = _context.Users.First(u => u.UserId == id);
            _context.Users.Remove(entity);
            _context.SaveChanges();
        }
        public void Update(User user)
        {
            _context.Users.Update(user);
            _context.SaveChanges();
        }
    }
}