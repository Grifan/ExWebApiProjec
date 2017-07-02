using System;

namespace ExWebApiProjec.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public DateTime CreationDate { get; set; }

        public int? RoleId { get; set; }
    }
}