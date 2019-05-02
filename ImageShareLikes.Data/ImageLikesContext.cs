using Microsoft.EntityFrameworkCore;

namespace ImageShareLikes.Data
{
    public class ImageLikesContext : DbContext
    {
        private string _connectionString;

        public DbSet<Image> Images { get; set; }

        public ImageLikesContext(string connectionString)
        {
            _connectionString = connectionString;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(_connectionString);
        }
    }
}