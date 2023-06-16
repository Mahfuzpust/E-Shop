using E_Shop.Models;
using E_Shop.Models.Domain;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace E_Shop.Data
{
    public class ApplicationDBContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options)
            : base(options)
        {

        }

        public DbSet<ProductTypes> ProductTypes { get; set; }
        public DbSet<SpecialTags> SpecialTags { get; set; }
        public DbSet<Products> Products { get; set; }
        public DbSet<NewProduct> NewProduct { get; set; }
    }
}
