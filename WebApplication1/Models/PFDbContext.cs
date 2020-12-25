using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Portfolio.Models
{
    public class PFDbContext : DbContext
    {


        public PFDbContext(DbContextOptions<PFDbContext> options) : base(options)
        { }

        public DbSet<Article> Articles { get; set; }
        public DbSet<ArticleType> ArticleTypes { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<Education> Educations { get; set; }
        public DbSet<Exprience> Expriences { get; set; }
        public DbSet<Projects> Projects { get; set; }
    }
}
