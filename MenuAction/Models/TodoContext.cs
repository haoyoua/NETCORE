
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MenuAction.Models;

namespace TodoApi.Models
{
    public class TodoContext : DbContext {
        public TodoContext(DbContextOptions<TodoContext> options) : base(options) { }
        public DbSet<TodoItem> TodoItems { get; set; }
        public DbSet<frmMenuInfo> frmMenuInfo { get; set; }
        
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<frmMenuInfo>(b =>
            {
                b.ToTable<frmMenuInfo>("frmMenu");
                b.HasKey(p => p.ID);
                b.Property(p => p.MenuName);
            });

        }
    }
}


//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Threading.Tasks;

//namespace MenuAction.Models
//{
//    public class TodoContext
//    {
//    }
//}


