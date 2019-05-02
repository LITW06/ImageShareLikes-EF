using System.IO;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace ImageShareLikes.Data
{
    public class ImageLikesContextFactory : IDesignTimeDbContextFactory<ImageLikesContext>
    {
        public ImageLikesContext CreateDbContext(string[] args)
        {
            var config = new ConfigurationBuilder()
                .SetBasePath(Path.Combine(Directory.GetCurrentDirectory(), $"..{Path.DirectorySeparatorChar}ImageShareLikes.Web"))
                .AddJsonFile("appsettings.json")
                .AddJsonFile("appsettings.local.json", optional: true, reloadOnChange: true).Build();

            return new ImageLikesContext(config.GetConnectionString("ConStr"));
        }
    }
}