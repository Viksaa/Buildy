using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Buildy.Models.PC_Components
{
    public class RAM
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Manufacturer { get; set; }
        public float Price { get; set; }
        public string ImageURL { get; set; }
        public int Frequency { get; set; }
        public string MemoryType { get; set; }
        public int Size { get; set; }
        public string Timing { get; set; }
    }
}