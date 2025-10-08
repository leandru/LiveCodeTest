using Microsoft.EntityFrameworkCore;
using Taller.Application.Abstractions;
using Taller.Domain;

namespace Taller.Infrastructure
{
    public class EfReportDbContext : DbContext
    {
        private ISecretProvider _secretProvider;

        public DbSet<Report> Reports { get; set; }

        public EfReportDbContext( ISecretProvider secretProvider)
        {
            _secretProvider = secretProvider;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(
                @"Server=(localdb)\mssqllocaldb;Database=Taller;Trusted_Connection=True;ConnectRetryCount=0");
        }
    }
}
