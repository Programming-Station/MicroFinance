using MicroFinance.Models;
using Microsoft.EntityFrameworkCore;

namespace MicroFinance.Database
{
    public class MicroFineceContext : DbContext
    {
        public MicroFineceContext(DbContextOptions<MicroFineceContext> options) : base(options)
        {

        }
        public DbSet<State> states { get; set; }
        public DbSet<City> cities { get; set; }
        public DbSet<Company> companies { get; set; }
        public DbSet<Role> roles { get; set; }  
        public DbSet<GovtDocumet> govtDocumet { get; set; }
        public DbSet<Branch> branch { get; set; }

    }
}
