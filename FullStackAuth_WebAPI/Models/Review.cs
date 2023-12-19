﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Identity;

namespace FullStackAuth_WebAPI.Models
{
    public class Review
    {
        [Key] 
        public int Id { get; set; }

        [Required]
        public string BookId { get; set; }

        [Required]
        public string Text { get; set; }

        [Required]
        public string Rating { get; set; }

        [ForeignKey("User")]
        public string UserId { get; set;}

        public User User { get; set;}
    }
}
