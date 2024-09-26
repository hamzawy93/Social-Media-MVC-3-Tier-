using Microsoft.EntityFrameworkCore;
using Social_Media.DAL.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Social_Media.DAL.Database
{
    public class ApplicationDbContext :DbContext
    {
     

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=.;Database=SocialMediaDB;Trusted_Connection=True;MultipleActiveResultSets=true;TrustServerCertificate=true");
        }
        public DbSet<User> Users { get; set; }
        public DbSet<Post> Posts { get; set; }

    }
    }
