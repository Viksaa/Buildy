using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Buildy.Models.PC_Components
{
    public class Storage
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Manufacturer { get; set; }
        public float Price { get; set; }
        public string ImageURL { get; set; }
        public string Type { get; set; }
        public int Capacity { get; set; }
        public int ReadingSpeed { get; set; }
        public int WritingSpeed { get; set; }
    }
}