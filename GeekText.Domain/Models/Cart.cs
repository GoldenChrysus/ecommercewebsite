﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace GeekText.Domain.Models
{
    public class Cart
    {
        [Key, Required]
        public int id { get; set; }
        [Required]       
        public decimal cart_total { get; set; }
        
        [ForeignKey("user_id"), Required]
        public User user { get; set; }
        
        public Order order { get; set; }
        public virtual ICollection<Cart_Book> cart_Book { get; set; }
    }
}
