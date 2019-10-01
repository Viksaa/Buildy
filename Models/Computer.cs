using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
using Buildy.Models.PC_Components;

namespace Buildy.Models
{
    public class Computer
    {
        [Key]
        public int Id { get; set; }

        public string Name { get; set; }

        public int CaseId { get; set; }

        [ForeignKey("CaseId")]
        public Case Case { get; set; }

        public int CoolingId { get; set; }

        [ForeignKey("CoolingId")]
        public Cooling Cooling { get; set; }

        public int CoolingAmmount { get; set; }

        public int CpuId { get; set; }

        [ForeignKey("CpuId")]
        public CPU Cpu { get; set; }

        public int GpuId { get; set; }

        [ForeignKey("GpuId")]
        public GPU Gpu { get; set; }

        public int MotherboardId { get; set; }

        [ForeignKey("MotherboardId")]
        public Motherboard Motherboard { get; set; }

        public int PsuId { get; set; }

        [ForeignKey("PsuId")]
        public PSU Psu { get; set; }

        public int RamId { get; set; }

        [ForeignKey("RamId")]
        public RAM Ram { get; set; }

        public int RamAmmount { get; set; }

        public int StorageId { get; set; }

        [ForeignKey("StorageId")]
        public Storage Storage { get; set; }

        public int StorageAmmount { get; set; }

        public virtual ICollection<ApplicationUser> Users { get; set; }

    }
}