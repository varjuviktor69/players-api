﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PlayersAPI.Models
{
    public class Player
    {
        [Key]
        public int PlayerID { get; set; }
        public int Age { get; set; }
        [ForeignKey("ClubID")]
        public int ClubID { get; set; }
        [Required]
        [StringLength(100)]
        public string FullName { get; set; }
        [Column(TypeName ="decimal(3,2)")]
        public decimal Height { get; set; }
        public int Salary { get; set; }
        [Column(TypeName = "decimal(4,1)")]
        public decimal Weight { get; set; }

    }
}
