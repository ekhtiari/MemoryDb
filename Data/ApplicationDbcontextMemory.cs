using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public class ApplicationDbcontextMemory:IdentityDbContext<IdentityUser>
    {
        public ApplicationDbcontextMemory(DbContextOptions<ApplicationDbcontextMemory> options):base(options){}

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }

        public DbSet<Patient> Patients { get; set; }
    }
}
