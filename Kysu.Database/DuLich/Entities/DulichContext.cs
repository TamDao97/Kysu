using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Kysu.DB.DuLich.Entities
{
    public class DulichContext : DbContext
    {
        public DulichContext() { }
        public DulichContext(DbContextOptions options) : base(options)
        { }

        public DbSet<User> User { get; set; }
        public DbSet<Post> Post { get; set; }
        public DbSet<TouristPlace> TouristPlace { get; set; }
        public DbSet<Comment> Comment { get; set; }
    }
}
