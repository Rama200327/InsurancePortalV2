using InsuraV2.Data;
using InsuraV2.Models;
using Microsoft.EntityFrameworkCore;

namespace InsuraV2.Data
{ 
    public class InsuraDbContext : DbContext
    {
        
        // Receives the database connection settings and passes them to DbContext by using ( : base(options) ) .
        public InsuraDbContext(DbContextOptions<InsuraDbContext> options)
            : base(options)
        {

        }


        // Database tables represented by Entity Framework :
        public DbSet<Policy> Policies { get; set; }
        public DbSet<Motor> Motors { get; set; }
        public DbSet<Travel> Travels { get; set; }
        public DbSet<Marine> Marines { get; set; }
        public DbSet<Medical> Medicals { get; set; }


    }
}