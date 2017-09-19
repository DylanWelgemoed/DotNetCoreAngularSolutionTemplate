using System.Collections.Generic;
using Template.Mock.Factories;
using Template.Model.Users;

namespace Template.Mock
{
    internal static class MockData
    {
        private static IList<User> users;

        public static IList<User> Users
        {
            get
            {
                if (users == null)
                    users = UserFactory.BuildUsers();

                return users;
            }
        }
    }
}