using Microsoft.EntityFrameworkCore;
using MyPortfolio.MessageApi.Entities;

namespace MyPortfolio.MessageApi.Context
{
    public class MyPortfolioDbContext : DbContext
    {
        public MyPortfolioDbContext(DbContextOptions<MyPortfolioDbContext> contextOptions) : base(contextOptions)
        {

        }

        public DbSet<Contact> Contacts { get; set; }
        public DbSet<Message> Messages { get; set; }
    }
}
