using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using Book.Models;


namespace Book.DAL
{
    public class BookContext:DbContext
    {
        public BookContext():base("BookDB")
        {

        }

        public DbSet<Books> Books { get; set; }
    }
}