using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using template.Authorization.Roles;
using template.Authorization.Users;
using template.MultiTenancy;

namespace template.EntityFrameworkCore
{
    public class templateDbContext : AbpZeroDbContext<Tenant, Role, User, templateDbContext>
    {
        /* Define a DbSet for each entity of the application */
        
        public templateDbContext(DbContextOptions<templateDbContext> options)
            : base(options)
        {
        }
    }
}
