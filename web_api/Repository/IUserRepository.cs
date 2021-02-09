using web_api.Models;
using System.Collections.Generic;

namespace web_api.Repository 
{
    public interface IUserRepository 
    {
        void Add(User user);
        IEnumerable<User> GetAll();
        User Find(long id);
        void Remove(long id);
        void Update(User user);
    }
}