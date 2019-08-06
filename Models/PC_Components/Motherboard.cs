using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
using Buildy.Models.PC_Components.PC_Helper_Models;

namespace Buildy.Models.PC_Components
{
    public class Motherboard
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public int ManufacturerId { get; set; }
        [ForeignKey("ManufacturerId")]
        public Manufacturer Manufacturer { get; set; }
        public float Price { get; set; }
        public string ImageURL { get; set; }
        public string Socket { get; set; }
        public string Chipset { get; set; }
        public int MemorySupport { get; set; }
        public int DimmSlots { get; set; }
        public string Type { get; set; }
    }
}