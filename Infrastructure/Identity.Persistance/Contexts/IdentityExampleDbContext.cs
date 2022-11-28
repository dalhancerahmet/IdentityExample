using Identity.Domain;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Identity.Persistance.Contexts
{
    public class IdentityExampleDbContext : IdentityDbContext<AppUser, AppRole, string>
    {
        public IdentityExampleDbContext(DbContextOptions options) : base(options)
        {
        }
    }
}
