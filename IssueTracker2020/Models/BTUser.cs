﻿using IssueTracker2020.Extensions;
using Microsoft.AspNetCore.Identity;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace IssueTracker2020.Models

{
    public class BTUser : IdentityUser

    {
        [Required]
        [StringLength(50)]
        public string FirstName { get; set; }

        [Required]
        [StringLength(50)]
        public string LastName { get; set; }

        [Display(Name = "Full Name")]
        [NotMapped]
        public string FullName
        { get { return $"{FirstName} {LastName}"; } }

        [Display(Name = "Avatar")]
        [MaxFileSize(2 * 1024 * 1024)]
        public string ImagePath { get; set; }

        public byte[] ImageData { get; set; }

        public List<ProjectUser> ProjectUsers { get; set; }
    }
}