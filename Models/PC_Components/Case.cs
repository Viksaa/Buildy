using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Buildy.Models.PC_Components
{
    public class Case
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Manufacturer { get; set; }
        public float Price { get; set; }
        public string ImageURL { get; set; }
        public string Dimensions { get; set; }
        public int MotherboardType { get; set; }
        public int FanSupport { get; set; }
    }
}