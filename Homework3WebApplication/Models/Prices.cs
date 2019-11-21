using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Homework3WebApplication.Models
{
    public class Prices
    {
        [Key]
        public DateTime Date { get; set; }
        public string Category { get; set; }
        public int Rate { get; set; }
    }
}