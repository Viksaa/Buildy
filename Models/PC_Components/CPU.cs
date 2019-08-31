using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
using Buildy.Models.PC_Components.PC_Helper_Models;

namespace Buildy.Models.PC_Components
{
    public class CPU
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public int ManufacturerId { get; set; }
        [ForeignKey("ManufacturerId")]
        public Manufacturer Manufacturer { get; set; }
        public float Price { get; set; }
        [DisplayName("Image")]
        public string ImageURL { get; set; }
        public int Cores { get; set; }
        public int Threads { get; set; }
        public float Frequency { get; set; }
        public int Cache { get; set; }
        public int SocketId { get; set; }
        [ForeignKey("SocketId")]
        public Socket Socket { get; set; }
        public bool CoolingSolution { get; set; }
    }
}