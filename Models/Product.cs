﻿using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace FurntureWebAPP_ASP_NET_CORE_MVC.Models
{
    public class Product
    {
        public int Id { get; set; }

        [MaxLength(100)]
        public string ImageFileName { get; set; }="";
        [MaxLength(100)]
        public string Name { get; set; } = "";
        [MaxLength(100)]
        public string Brand { get; set; }="";
        [MaxLength(100)]
        public string Category { get; set; } = "";
        public string Description { get; set; } = "";
        [Precision(16,2)]
        public decimal Price{ get; set; } 
        public DateTime CreatedAt { get; set; } 

    }
}
