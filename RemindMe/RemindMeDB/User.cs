using System;
using System.Collections.Generic;

namespace RemindMe.RemindMeDB
{
    /// <summary>
    /// ToDoUserRecords
    /// </summary>
    public partial class User
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public int UserId { get; set; }
        public byte[] PasswordHash { get; set; }
    }
}
