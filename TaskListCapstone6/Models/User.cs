using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace TaskListCapstone6.Models
{
    public class User
    {
        public int ID { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }

    }
    public class DBUserContext : DbContext
    {
        public DbSet<User> Users { get; set; }
    }

}