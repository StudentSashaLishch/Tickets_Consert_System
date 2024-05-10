using Microsoft.EntityFrameworkCore;
using Pomelo.EntityFrameworkCore.MySql.Infrastructure;
using System;
using Tickets_Consert_System.MainClasses;

namespace Tickets_Consert_System.Data
{
    public class TicketsConsertSystemContext : DbContext
    {
        public DbSet<Client> Clients { get; set; }
        public DbSet<Singer> Singers { get; set; }
        public DbSet<Manager> Managers { get; set; }
        public DbSet<TicketSell> Tickets { get; set; }
        public DbSet<ContractProposal> ContractProposals { get; set; }
        public DbSet<Consert> Conserts { get; set; }

        public TicketsConsertSystemContext()
        {
            Database.EnsureCreated();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySql("server=localhost;user=root;password=12345;database=consert_system",
                version => version.ServerVersion(new Version(8, 0, 3), ServerType.MySql));
        }
    }
}
