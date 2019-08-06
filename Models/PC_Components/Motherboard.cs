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
        public int SocketId { get; set; }
        [ForeignKey("SocketId")]
        public Socket Socket { get; set; }
        public int ChipsetId { get; set; }
        [ForeignKey("ChipsetId")]
        public Chipset Chipset { get; set; }
        public int MemorySupport { get; set; }
        public int DimmSlots { get; set; }
        public int MotherboardTypeId { get; set; }
        [ForeignKey("MotherboardTypeId")]
        public MotherboardType MotherboardType { get; set; }
    }
}