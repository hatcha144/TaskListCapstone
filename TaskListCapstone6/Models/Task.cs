using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace TaskListCapstone6.Models
{
    public class Task
    {
        public int ID { get; set; }
        public int UserID { get; set; }
        public string Description { get; set; }
        public DateTime DueDate { get; set; }
        public bool Complete { get; set; }
    }
    
  
    public class DBTaskContext : DbContext
    {
        public DbSet<Task> Tasks { get; set; }
    }


}