﻿using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AchiveClub.Shared.Models
{
    public class User
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string FirstName { get; set; }

        [Required]
        public string LastName { get; set; }

        [Required]
        public string Email { get; set; }

        [Required]
        public string Password { get; set; }

        public List<CompletedAchive> CompletedAchivements { get; set; }

        public User()
        {
            CompletedAchivements = new List<CompletedAchive>();
        }

        public override string ToString()
        {
            return $"{FirstName} {LastName}\n" +
                $"{Email}\n" +
                $"[{Password}]";
        }
    }
}
