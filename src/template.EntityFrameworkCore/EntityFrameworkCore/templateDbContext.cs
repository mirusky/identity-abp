using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using template.Authorization.Roles;
using template.Authorization.Users;
using template.MultiTenancy;
using Abp.Localization;

namespace template.EntityFrameworkCore
{
    public class templateDbContext : AbpZeroDbContext<Tenant, Role, User, templateDbContext>
    {
        /* Define a DbSet for each entity of the application */
        
        public templateDbContext(DbContextOptions<templateDbContext> options)
            : base(options)
        {
        }

        // add these lines to override max length of property
        // we should set max length smaller than the PostgreSQL allowed size (10485760)
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            
            modelBuilder.Entity<ApplicationLanguageText>()
                .Property(p => p.Value)
                .HasMaxLength(100); // any integer that is smaller than 10485760
        }
    }
}
