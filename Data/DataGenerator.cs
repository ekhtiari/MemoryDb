using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public class DataGenerator
    {
        public static void InitData(IServiceProvider serviceProvider)
        {
            using var context = new ApplicationDbcontextMemory(serviceProvider.GetRequiredService<DbContextOptions<ApplicationDbcontextMemory>>());

            context.Patients.AddRange(
                new Patient
                {
                    Id = 1,
                    Age = 12,
                    Famili = "ekh",
                    Name = "iman"
                },
                new Patient
                {
                    Id = 2,
                    Age = 12,
                    Famili = "ekh",
                    Name = "iman"
                },
                new Patient
                {
                    Id = 3,
                    Age = 42,
                    Famili = "ekh",
                    Name = "iman"
                },
                new Patient
                {
                    Id = 4,
                    Age = 52,
                    Famili = "ekh",
                    Name = "iman"
                },
                new Patient
                {
                    Id = 5,
                    Age = 12,
                    Famili = "ekh",
                    Name = "iman"
                });
        }
    }
}
