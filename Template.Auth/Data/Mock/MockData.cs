using System.Collections.Generic;
using Template.Auth.Data.Mock.Factories;
using Template.Auth.Models.Security;
using Template.Auth.Models.Users;

namespace Template.Auth.Data.Mock
{
    internal static class MockData
    {
        private static IList<Credentials> credentials;
        public static IList<Credentials> Credentials
        {
            get
            {
                if (credentials == null)
                    credentials = SecurityFactory.Build();

                return credentials;
            }
        }


        private static IList<User> users;
        public static IList<User> Users
        {
            get
            {
                if (users == null)
                    users = UserFactory.Build();

                return users;
            }
        }
    }
}