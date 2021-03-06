﻿using Microsoft.EntityFrameworkCore;
using Stories.Models;

namespace Stories.Data
{
    public class StoriesContext : DbContext
    {
        public DbSet<Project> Projects { get; set; }
        public DbSet<Story> Stories { get; set; }
        public DbSet<Type> Types { get; set; }
        public DbSet<State> States { get; set; }
        public DbSet<BusinessRule> BusinessRules { get; set; }
        public DbSet<Scenario> Scenarios { get; set; }

        public StoriesContext(DbContextOptions<StoriesContext> options) : base(options)
        {
        }
    }
}