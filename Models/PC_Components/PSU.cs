using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Buildy.Models.PC_Components
{
    public class PSU
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Manufacturer { get; set; }
        public float Price { get; set; }
        public string ImageURL { get; set; }
        public bool Modular { get; set; }
        public string Efficiency { get; set; }
        public int Capacity { get; set; }
    }
}