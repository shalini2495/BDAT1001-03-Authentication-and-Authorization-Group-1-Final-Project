using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Authentication_and_Authorization.Models
{
    public class ApplicationDbContext : IdentityDbContext<IdentityUser>
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {
        }

        public ApplicationDbContext(DbContextOptions options, DbContextOptions<ApplicationDbContext> dbContextOptions) : base(options)
        {
            //private Contact contact = new Contact();
        }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options, DbContextOptions<ApplicationDbContext> DbContextOptionsBuilder) : base(options)
        {

        }

        public object Contact { get; internal set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }
    }

}
