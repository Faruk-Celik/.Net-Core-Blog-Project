using EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concrete
{
    public class Context : DbContext // DbContext sınıfından miras alındı.
    {
        protected override void OnConfiguring ( DbContextOptionsBuilder optionsBuilder )
        {
            optionsBuilder.UseSqlServer("Server=DESKTOP-6VB768D\\SQLEXPRESS02; initial catalog=CoreBlogDb; integrated Security=true;");
        }
        public DbSet<About> Abouts { get; set; }
        public DbSet<Blog> Blogs { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<Writer> Writers { get; set; }
		public DbSet<NewsLetter> NewsLetters { get; set; }
        public DbSet<BlogRayting> BlogRaytings { get; set; }

    }
    

    
}
