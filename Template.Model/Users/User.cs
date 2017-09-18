using System;
using System.Collections.Generic;
using Template.Model.Base;

namespace Template.Model.Users
{
    public class User : BaseModel
    {
        public string Key { get; set; }
        public string EmailAddress { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string PhoneNumber { get; set; }
        public bool IsActive { get; set; }
        public bool EmailConfirmed { get; set; }
        public List<UserRoles> Roles { get; set; }
        public DateTime LastModified { get; set; }
        public DateTime DateCreated { get; set; }
    }
}
