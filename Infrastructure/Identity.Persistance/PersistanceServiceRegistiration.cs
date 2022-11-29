using Identity.Domain;
using Identity.Persistance.Contexts;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Identity.Persistance
{
    public static class PersistanceServiceRegistiration
    {
        public static void AddPersistanceServices(this IServiceCollection services)
        {
            services.AddDbContext<IdentityExampleDbContext>(options => options.UseSqlServer("Server=AHMET\\SQLEXPRESS;Database=IdentityExampleDb;Encrypt=False; Trusted_Connection=True;"));

            services.AddIdentity<AppUser,AppRole>().AddEntityFrameworkStores<IdentityExampleDbContext>().AddDefaultTokenProviders();

        }
    }
}
