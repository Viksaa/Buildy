using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Buildy.Models.PC_Components.PC_Helper_Models
{
    public class CoolingType
    {
        [Key]
        public int Id { get; set; }

        public string Name { get; set; }

        public ICollection<Cooling> Coolings { get; set; }
    }
}