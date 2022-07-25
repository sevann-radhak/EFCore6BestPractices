using GloboTicket.Domain.Entities;
using GloboTicket.SharedKernel.Configuration;
using Microsoft.EntityFrameworkCore;

namespace GloboTicket.Domain
{
    public class GloboTicketContext : DbContext
    {
        private readonly IModelConfiguration _modelConfiguration;

        public GloboTicketContext(
            DbContextOptions<GloboTicketContext> options,
            IModelConfiguration modelConfiguration) : base(options)
        {
            _modelConfiguration = modelConfiguration;
        }

        public DbSet<Venue> Venue { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(GloboTicketContext).Assembly);
            _modelConfiguration.ConfigureModel(modelBuilder);
        }
    }
}