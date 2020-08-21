﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WishList.Models
{
    public class Item
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Please enter a description")]
        [StringLength(50)]
        public string Description { get; set; }
        
    }
}
