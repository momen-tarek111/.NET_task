﻿using System.ComponentModel.DataAnnotations;
namespace Project3.Models
{
    public class Company
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }

    }
}
