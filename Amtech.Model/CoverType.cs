﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Amtech.Models
{
    public class CoverType
    {
        //This is the cover type table
        [Key]
        public int Id { get; set; }
        [Display(Name ="Cover Type")]
        [Required]
        [MaxLength(50)]
        public string Name { get; set; }
        
    }
}
