using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace DSS.Identidade.API.Data
{
    public class ApplicationsDbContext : IdentityDbContext
    {
        public ApplicationsDbContext(DbContextOptions<ApplicationsDbContext> op) : base(op) { }
    }
}
