using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace Codefirst.Models
{
    public class VechilesContext:DbContext
    {
        public VechilesContext() :base("name=efVechicles")
        {

        }
        public DbSet<Car> cars { get; set; }
    }
}