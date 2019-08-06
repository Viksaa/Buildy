using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Buildy.Models.PC_Components.PC_Helper_Models
{
    public class MotherboardType
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<Case> Cases { get; set; }
        public ICollection<Motherboard> Motherboards { get; set; }
    }
}