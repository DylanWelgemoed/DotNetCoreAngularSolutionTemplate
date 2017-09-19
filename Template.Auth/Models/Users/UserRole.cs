using System;

namespace Template.Auth.Models.Users
{
    [Flags]
    public enum UserRole
    {
        User = 1,
        Admin = 2
    }
}