using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace HR_System.Models.HR_Models
{
    public class JobsContext:ApplicationDbContext
    {
        public DbSet<Article> Ariticles { get; set; }
    }
}