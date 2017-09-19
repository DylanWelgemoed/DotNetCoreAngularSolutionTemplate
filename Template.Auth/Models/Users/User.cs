using System.Collections.Generic;

namespace Template.Auth.Models.Users
{
    public class User
    {
        public string Key { get; set; }
        public string UserName { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EmailAddress { get; set; }
        public IList<UserRole> Roles { get; set; }
    }
}