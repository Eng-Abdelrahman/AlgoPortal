using Data.Domain;
using Data.Map;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repo
{
    public class DbContext : IdentityDbContext<ApplicationUser>
    {
        public DbContext(DbContextOptions<DbContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            new ItemMap(builder.Entity<Item>());

        }

        public DbSet<Item> Items { get; set; }

    }
}
