﻿using Microsoft.AspNetCore.Identity;

namespace StudentsAdminEditors.Models
{
    public class ApplicationUser : IdentityUser
    {
        public bool IsActive { get; set; } = true;        
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
        public DateTime? LastLoginAt { get; set; }
        public int LoginCount { get; set; } = 0;
        public string? AdminNote { get; set; }
    }
}
