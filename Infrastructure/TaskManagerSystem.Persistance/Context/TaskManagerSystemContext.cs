using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskManagerSystem.Domain;
using TaskManagerSystem.Domain.Entities;

namespace TaskManagerSystem.Persistance.Context
{
    public class TaskManagerSystemContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=localhost;Database=TaskManagerSystem;User Id=sa;Password=Yasin123!;TrustServerCertificate=True;");
        }
    
        public DbSet<Project> Projects { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<SubTask> SubTasks { get; set; }
        public DbSet<TaskManagerSystem.Domain.Task> Tasks { get; set; }
        public DbSet<Team> Teams { get; set; }
        public DbSet<TeamMembers> TeamMembers { get; set; }
        public DbSet<User> Users { get; set; }


    }
}
