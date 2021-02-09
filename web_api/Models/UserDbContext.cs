//console: dotnet add package Microsoft.EntityFrameworkCore.SqlServer
using Microsoft.EntityFrameworkCore;

namespace web_api.Models 
{
    public class UserDbContext : DbContext
    {
        public UserDbContext (DbContextOptions<UserDbContext> options) 
            : base(options)
        {}

        public DbSet<User> Users { get; set; }
    }
}