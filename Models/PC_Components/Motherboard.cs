using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Buildy.Models.PC_Components
{
    public class Motherboard
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Manufacturer { get; set; }
        public float Price { get; set; }
        public string ImageURL { get; set; }
        public string Socket { get; set; }
        public string Chipset { get; set; }
        public int MemorySupport { get; set; }
        public int DimmSlots { get; set; }
        public string Type { get; set; }
    }
}