using Project.Models;
using Microsoft.EntityFrameworkCore;

namespace Project.Data{
    public class ProjectContext : DbContext{
        public ProjectContext(DbContextOptions<ProjectContext> opt) : base(opt){

        }
        public DbSet <Command> Commands { get; set; }

    }
}