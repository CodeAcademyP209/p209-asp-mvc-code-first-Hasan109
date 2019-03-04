using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using Rent.Models;

namespace Rent.DAL
{
    public class RentContext:DbContext 
    {
        public RentContext():base("Rent") 
        {

        }
        public DbSet<Rents>  Rents{ get; set; }
    }
}