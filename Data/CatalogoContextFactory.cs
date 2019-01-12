using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace API.Data
{
    public class CatalogoContextFactory : IDesignTimeDbContextFactory<CatalagoContext>
    {
        private readonly string ConnectionString = "Server=Server=DESKTOP-NPKEPVO\\SQLEXPRESS;Database=dbCatalogo;Trusted_Connection=True;";

        public CatalagoContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<CatalagoContext>();
            optionsBuilder.UseSqlServer(ConnectionString);

            return new CatalagoContext(ConnectionString);
        }
    }
}