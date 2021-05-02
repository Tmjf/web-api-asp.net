using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace web_api.Data
{
    public class AppDbInitializer
    {
        public static void Seed(IApplicationBuilder applicationBuilder)
        {
            using (var serviceScope = applicationBuilder.ApplicationServices.CreateScope())
            {
                var context = serviceScope.ServiceProvider.GetService<AppDbContext>();

                if (!context.Users.Any())
                {
                    context.Users.AddRange(new Models.Users()
                    {
                        FirstName = "Bogg",
                        LastName = "Dann",
                        Email = "wicked@gmail.com",
                        Country = "Libasol",
                        JobTitle = "CEO",
                    });
                }
                context.SaveChanges();
            }
        }
    }
}
