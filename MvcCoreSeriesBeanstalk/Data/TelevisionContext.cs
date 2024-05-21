using Microsoft.EntityFrameworkCore;
using MvcCoreSeriesBeanstalk.Models;

namespace MvcCoreSeriesBeanstalk.Data
{
    public class TelevisionContext : DbContext
    {
        public TelevisionContext(DbContextOptions<TelevisionContext> options) : base(options)
        {
        }

        public DbSet<Serie> Series { get; set; }
    }
}
