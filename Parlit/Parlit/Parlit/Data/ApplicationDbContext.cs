using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Parlit.Models;

namespace Parlit.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<IdentityRole>().HasData(new IdentityRole { Name = "Parlitor", NormalizedName = "PARLITOR" });
        }

        public DbSet<Parlitor> parlitor { get; set; }
        public DbSet<Submission> submission { get; set; }
        public DbSet<VoteHistory> voteHistory { get; set; }
        public DbSet<VoteTally> voteTally { get; set; }
    }
}
