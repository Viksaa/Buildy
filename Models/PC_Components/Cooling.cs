using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
using Buildy.Models.PC_Components.PC_Helper_Models;

namespace Buildy.Models.PC_Components
{
    public class Cooling
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public int ManufacturerId { get; set; }
        [ForeignKey("ManufacturerId")]
        public Manufacturer Manufacturer { get; set; }
        public float Price { get; set; }
        public string ImageURL { get; set; }
        public int Size { get; set; }
        public bool RGB { get; set; }
        public int Speed { get; set; }

        public int TypeId { get; set; }
        [ForeignKey("TypeId")]
        public CoolingType CoolingType { get; set; }
    }
}