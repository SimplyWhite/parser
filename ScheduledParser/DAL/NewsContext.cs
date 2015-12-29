using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using ScheduledParser.Models;

namespace ScheduledParser.DAL
{
    public class NewsContext : DbContext
    {
        public NewsContext()  : base ("NewsContext")
        {
        }

        public DbSet<NewsItem> NewsItems { get; set; }
        public DbSet<NewsImage> Images { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}