using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Buildy.Models
{
    public class User_Computers
    {
        [Key]
        public int Id { get; set; }
        public int ComputerId { get; set; }
        [ForeignKey("ComputerId")]
        public Computer Computer { get; set; }

        public string UserId { get; set; }
        [ForeignKey("UserId")]
        public ApplicationUser User { get; set; }
    }
}