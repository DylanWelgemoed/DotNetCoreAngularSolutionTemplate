using System.Collections.Generic;
using Template.Auth.Models.Users;

namespace Template.Auth.Data.Mock.Factories
{
    internal static class UserFactory
    {
        internal static IList<User> Build()
        {
            return new List<User>
            {
                new User
                {
                    Key = "053bb0c3-0023-46ea-9886-7afe58369510",
                    UserName = "Robin.Shillabeer",
                    FirstName = "Robin",
                    LastName = "Shillabeer",
                    EmailAddress = "rshillabeer0@opera.com",
                    Roles = new List<UserRole>() { UserRole.Admin, UserRole.User }
                },
                new User
                {
                    Key = "a249190a-f74d-4c7f-bfb9-b7e7f0f8a501",
                    UserName = "Florie.Satterfitt",
                    FirstName = "Florie",
                    LastName = "Satterfitt",
                    EmailAddress = "fsatterfitt1@craigslist.org",
                    Roles = new List<UserRole>() { UserRole.User }
                },
                new User
                {
                    Key = "de74ee2e-c0dc-4dfe-a263-d9130db37b03",
                    UserName = "Floris.Coyish",
                    FirstName = "Floris",
                    LastName = "Coyish",
                    EmailAddress = "fcoyish2@yellowbook.com",
                    Roles = new List<UserRole>() { UserRole.Admin }
                },
                new User
                {
                    Key = "3823d597-7893-4001-a3d4-a420308839e4",
                    UserName = "Jasun.Devenport",
                    FirstName = "Jasun",
                    LastName = "Devenport",
                    EmailAddress = "jdevenport3@springer.com",
                    Roles = new List<UserRole>() { UserRole.Admin }
                },
                new User
                {
                    Key = "17dba8bf-d9a2-41f0-9db1-16d108f7d860",
                    UserName = "Raynell.Dautry",
                    FirstName = "Raynell",
                    LastName = "Dautry",
                    EmailAddress = "rdautry4@reddit.com",
                    Roles = new List<UserRole>() { UserRole.User }
                },
                new User
                {
                    Key = "4befec2f-fa59-4f62-9225-47b678e777c8",
                    UserName = "Fred.Elce",
                    FirstName = "Fred",
                    LastName = "Elce",
                    EmailAddress = "felce5@yelp.com",
                    Roles = new List<UserRole>() { UserRole.User }
                },
                new User
                {
                    Key = "54f8dbbd-cd70-440d-a9dc-2edfe4f1d0d6",
                    UserName = "Ebenezer.Gehrts",
                    FirstName = "Ebenezer",
                    LastName = "Gehrts",
                    EmailAddress = "egehrts6@irs.gov",
                    Roles = new List<UserRole>() { UserRole.User }
                },
                new User
                {
                    Key = "d817b220-8791-43ad-8a47-4cbb9e316573",
                    UserName = "Bibby.Filler",
                    FirstName = "Bibby",
                    LastName = "Filler",
                    EmailAddress = "bfiller7@networkadvertising.org",
                    Roles = new List<UserRole>() { UserRole.User }
                },
                new User
                {
                    Key = "4677396d-aac1-4263-b270-7a542a357175",
                    UserName = "Barnaby.McGray",
                    FirstName = "Barnaby",
                    LastName = "McGray",
                    EmailAddress = "bmcgray8@time.com",
                    Roles = new List<UserRole>() { UserRole.Admin, UserRole.User }
                },
                new User
                {
                    Key = "14c2ddf3-fc9d-4c73-849a-84b2f6c916d4",
                    UserName = "Hakim.Gallen",
                    FirstName = "Hakim",
                    LastName = "Gallen",
                    EmailAddress = "hgallen9@squidoo.com",
                    Roles = new List<UserRole>() { UserRole.User }
                }
            };
        }
    }
}