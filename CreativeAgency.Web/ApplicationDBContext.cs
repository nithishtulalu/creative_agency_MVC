using CreativeAgency.Web.Models;
using Microsoft.EntityFrameworkCore;

namespace CreativeAgency.Web
{
    public class ApplicationDBContext:DbContext
    {
        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options):base(options)
        {
            
        }
        public DbSet<ContactFormModel> ContactForms { get; set; }
    }
}
