using System;
using System.Collections.Generic;
using Template.Model.Base;

namespace Template.Model.Users
{
    public class User : BaseModel
    {
        public string Key { get; set; }
        public string UserName { get; set; }
        public string EmailAddress { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PhoneNumber { get; set; }
        public bool IsActive { get; set; }
        public bool EmailConfirmed { get; set; }
        public IList<UserRole> Roles { get; set; }
        public DateTime LastModified { get; set; }
        public DateTime DateCreated { get; set; }
    }
}