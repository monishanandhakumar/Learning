using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Codefirst.Models
{
    [Table("name=tblCar")]
    public class Car
    {
        [Key]
        public int carno { get; set; }
        public string carname { get; set; }
        public string carcompany { get; set; }
    }
}