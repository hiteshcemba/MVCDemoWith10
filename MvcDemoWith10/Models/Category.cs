using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace MvcDemoWith10.Models
{

    public class Category
    {

        public int ID { get; set; }
        public string CategoryName { get; set; }
        public string Email { get; set; }
    }
    public class CategoryDBContext : DbContext
    {
        public DbSet<Category> Categories { get; set; }
    }


}