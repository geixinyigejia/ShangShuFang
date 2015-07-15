using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

//using
using System.Data.Entity;
using WebAPIDemo2_BookService.Models;

namespace WebAPIDemo2_BookService.Models
{
    public class BookServiceContext : DbContext
    {
        public BookServiceContext()
            : base("name=BookServiceContext")
        {
            this.Database.Log = s => System.Diagnostics.Debug.WriteLine(s);
        }

        public DbSet<Author> Authors { get; set; }

        public DbSet<Book> Books { get; set; }
    }
}