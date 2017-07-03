using System;
using System.ComponentModel.DataAnnotations;

namespace ExWebApiProjec.Models
{
    public class User
    {
        public int Id { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public string Password { get; set; }
        public DateTime CreationDate { get; set; }

        public int? RoleId { get; set; }
    }
}