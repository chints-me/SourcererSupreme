using Microsoft.EntityFrameworkCore;
using SourcererSupreme.Designer.Data.Models;
using System.Collections.Generic;

namespace SourcererSupreme.Designer.Data
{
    public class DesignerDbContext : DbContext
    {
        public DesignerDbContext(DbContextOptions<DesignerDbContext> options)
            : base(options)
        {
        }

        public DbSet<Project> Projects => Set<Project>();
        public DbSet<Form> Forms { get; set; }
        public DbSet<FormControl> FormControls => Set<FormControl>();
    }
}