using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeliFood.Domain.Model.DTO
{
    public class AuthenticateRequest
    {
        [Required]
        public string Username { get; set; }

        [Required]
        public string Password { get; set; }

        public AuthenticateRequest(string username, string password)
        {
            Username = username;
            Password = password;
        }
    }
}
