using GloboTicket.Domain;
using GloboTicket.Infrastructure;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace GloboTicket.API.DesignTime
{
    public class GloboTicketContextFactory : IDesignTimeDbContextFactory<GloboTicketContext>
    {
        private const string AdminConnectionString = "GLOBOTICKET_ADMIN_CONNECTION_STRING";

        public GloboTicketContext CreateDbContext(string[] args)
        {
            string? connectionString = Environment.GetEnvironmentVariable(AdminConnectionString);
            //string connectionString = "Server=(local);Initial Catalog=GloboTicket;User=app;Password=apppassword;MultipleActiveResultSets=True;";

            if (string.IsNullOrEmpty(connectionString))
            {
                throw new ApplicationException($"Please set the environment variable {AdminConnectionString}");
            }
            
            DbContextOptions<GloboTicketContext>? options = new DbContextOptionsBuilder<GloboTicketContext>()
                .UseSqlServer(connectionString, sqlOptions =>
                {
                    sqlOptions.MigrationsAssembly(typeof(ServiceRegistration).Assembly.FullName);
                })
                .Options;

            return new GloboTicketContext(options, new DesignTimeModelConfiguration());
        }
    }
}
