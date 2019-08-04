using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Buildy.Models.PC_Components
{
    public class CPU
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Manufacturer { get; set; }
        public float Price { get; set; }
        public string ImageURL { get; set; }
        public int Cores { get; set; }
        public int Threads { get; set; }
        public float Frequency { get; set; }
        public int Cache { get; set; }
        public string Socket { get; set; }
        public bool CoolingSolution { get; set; }
    }
}