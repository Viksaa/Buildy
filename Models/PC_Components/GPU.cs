using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Buildy.Models.PC_Components
{
    public class GPU
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Manufacturer { get; set; }
        public float Price { get; set; }
        public string ImageURL { get; set; }
        public int Frequency { get; set; }
        public int MemoryClock { get; set; }
        public string Timing { get; set; }
        public int RAMSize { get; set; }
        public string RAMType { get; set; }
    }
}