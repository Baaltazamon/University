using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Data.Context
{
    public class MyIdentityDbContext : IdentityDbContext<User, Roles, string>
    {
        public MyIdentityDbContext(DbContextOptions<MyIdentityDbContext> options)
            : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            // Добавление дополнительной конфигурации, если необходимо
            builder.Entity<Roles>().HasData(new List<Roles>
            {
                new Roles
                {
                    Id = "1",
                    Name = "Администратор",
                    NormalizedName = "АДМИНИСТРАТОР"
                },
                new Roles
                {
                    Id = "2",
                    Name = "Модератор",
                    NormalizedName = "МОДЕРАТОР"
                }
            });

        }
    }
}
