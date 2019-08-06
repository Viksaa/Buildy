using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Buildy.Models.PC_Components.PC_Helper_Models
{
    public class Manufacturer
    {
        [Key]
        public int Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public ICollection<Case> Cases { get; set; }
        public ICollection<Cooling> Coolings{ get; set; }
        public ICollection<GPU> Gpus{ get; set; }
        public ICollection<CPU> Cpus{ get; set; }
        public ICollection<Motherboard> Motherboards { get; set; }
        public ICollection<PSU> Psus { get; set; }
        public ICollection<Storage> Storages { get; set; }
    }
}