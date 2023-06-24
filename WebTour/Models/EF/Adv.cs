﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace WebTour.Models.EF
{
    [Table("tb_Adv")]
    public class Adv : CommonAbs
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public int Type { get; set; }
        [Required]
        [StringLength(250)]
        public string Title { get; set; }
        [StringLength(500)]
        public string Description { get; set; }
        [StringLength(500)]
        public string Image { get; set; }
        [StringLength(500)]
        public string Link { get; set; }
    }
}