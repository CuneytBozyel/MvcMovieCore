using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Linq;

namespace MvcMovie.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new MvcMovieContext(
                serviceProvider.GetRequiredService<DbContextOptions<MvcMovieContext>>()))
            {
                // Look for any movies.
                if (context.User.Any())
                {
                    return;   // DB has been seeded
                }

                context.User.AddRange(
                     new User
                     {
                         Id =1,
                         Name = "When Harry Met Sally",
                         SurName = "DateTime.Parse()",
                       
                     },

                     new User
                     {
                          Id =2,
                         Name = "When Harry Met Sally",
                         SurName = "DateTime.Parse()",
                     },
                    new User
                     {
                          Id =3,
                         Name = "When Harry Met Sally",
                         SurName = "DateTime.Parse()",
                     }
                   
                );
                context.SaveChanges();
            }
        }
    }
}