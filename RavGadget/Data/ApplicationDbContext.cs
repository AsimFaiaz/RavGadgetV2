using Microsoft.EntityFrameworkCore;
using RavGadget.Model;

namespace RavGadget.Data
{
    //add-migration AddCategoryToDb from Tools > NuG Pack Manager Console
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Category> Category { get; set; } //Catrgory = Name of the table
    }
}
