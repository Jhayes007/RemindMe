using RemindMe.Common.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemindMe.Common.DatabaseModels.User
{
   public class UsersModel
    {
        public int UserId { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public HashCode Password { get; set; }

        public UsersModel() { }

        public UsersModel(Users users)
        {
            UserId = users.UserId;
            Name = users.Name;
            Email = users.Email;
            Password = users.Password;
        }
    }
}
