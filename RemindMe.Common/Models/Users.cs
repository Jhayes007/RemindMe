using RemindMe.Common.DatabaseModels.User;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemindMe.Common.Models
{
    public class Users
    {
        public int UserId { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public HashCode Password { get; set; }

        public Users() { }

        public Users(UsersModel usersModel)
        {
            UserId = usersModel.UserId;
            Name = usersModel.Name;
            Email = usersModel.Email;
            Password = usersModel.Password;
        }
    }
}
