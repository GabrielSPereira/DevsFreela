﻿using DevsFreela.Core.Entities;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace DevsFrella.Infrastructure.Persistence
{
    public class DevsFreelaDbContext : DbContext
    {
        public DevsFreelaDbContext(DbContextOptions<DevsFreelaDbContext> options) : base(options)
        {
            
        }

        public DbSet<Project> Projects { get; set; }

        public DbSet<User> Users { get; set; }

        public DbSet<Skill> Skills { get; set; }

        public DbSet<UserSkill> UserSkills { get; set; }

        public DbSet<ProjectComment> ProjectComments { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());            
        }
    }
}
