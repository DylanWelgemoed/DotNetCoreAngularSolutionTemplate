using System;
using System.Collections.Generic;
using Template.Model.Users;

namespace Template.Mock.Factories
{
    internal static class UserFactory
    {
        internal static IList<User> BuildUsers()
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
                    PhoneNumber = "8868684915",
                    IsActive = false,
                    LastModified = new DateTime(2016, 07, 25),
                    DateCreated = new DateTime(2016, 07, 29),
                    Roles = new List<UserRole>() { UserRole.Admin, UserRole.User }
                },
                new User
                {
                    Key = "a249190a-f74d-4c7f-bfb9-b7e7f0f8a501",
                    UserName = "Florie.Satterfitt",
                    FirstName = "Florie",
                    LastName = "Satterfitt",
                    EmailAddress = "fsatterfitt1@craigslist.org",
                    PhoneNumber = null,
                    IsActive = true,
                    LastModified = new DateTime(2017, 08, 03),
                    DateCreated = new DateTime(2017, 08, 18),
                    Roles = new List<UserRole>() { UserRole.User }
                },
                new User
                {
                    Key = "de74ee2e-c0dc-4dfe-a263-d9130db37b03",
                    UserName = "Floris.Coyish",
                    FirstName = "Floris",
                    LastName = "Coyish",
                    EmailAddress = "fcoyish2@yellowbook.com",
                    PhoneNumber = "5296920149",
                    IsActive = true,
                    LastModified = new DateTime(2017,04,26),
                    DateCreated = new DateTime(2017,05,20),
                    Roles = new List<UserRole>() { UserRole.Admin }
                },
                new User
                {
                    Key = "3823d597-7893-4001-a3d4-a420308839e4",
                    UserName = "Jasun.Devenport",
                    FirstName = "Jasun",
                    LastName = "Devenport",
                    EmailAddress = "jdevenport3@springer.com",
                    PhoneNumber = "3517160615",
                    IsActive = true,
                    LastModified = new DateTime(2015,08,01),
                    DateCreated = new DateTime(2015,12,08),
                    Roles = new List<UserRole>() { UserRole.Admin }
                },
                new User
                {
                    Key = "17dba8bf-d9a2-41f0-9db1-16d108f7d860",
                    UserName = "Raynell.Dautry",
                    FirstName = "Raynell",
                    LastName = "Dautry",
                    EmailAddress = "rdautry4@reddit.com",
                    PhoneNumber = "6218230459",
                    IsActive = false,
                    LastModified = new DateTime(2017,05,22),
                    DateCreated = new DateTime(2017,09,08),
                    Roles = new List<UserRole>() { UserRole.User }
                },
                new User
                {
                    Key = "4befec2f-fa59-4f62-9225-47b678e777c8",
                    UserName = "Fred.Elce",
                    FirstName = "Fred",
                    LastName = "Elce",
                    EmailAddress = "felce5@yelp.com",
                    PhoneNumber = "3398902491",
                    IsActive = true,
                    LastModified = new DateTime(2017,04,27),
                    DateCreated = new DateTime(2017,08,24),
                    Roles = new List<UserRole>() { UserRole.User }
                },
                new User
                {
                    Key = "54f8dbbd-cd70-440d-a9dc-2edfe4f1d0d6",
                    UserName = "Ebenezer.Gehrts",
                    FirstName = "Ebenezer",
                    LastName = "Gehrts",
                    EmailAddress = "egehrts6@irs.gov",
                    PhoneNumber = "5666449645",
                    IsActive = false,
                    LastModified = new DateTime(2015,08,10),
                    DateCreated = new DateTime(2016,10,20),
                    Roles = new List<UserRole>() { UserRole.User }
                },
                new User
                {
                    Key = "d817b220-8791-43ad-8a47-4cbb9e316573",
                    UserName = "Bibby.Filler",
                    FirstName = "Bibby",
                    LastName = "Filler",
                    EmailAddress = "bfiller7@networkadvertising.org",
                    PhoneNumber = "7461080498",
                    IsActive = true,
                    LastModified = new DateTime(2016,04,21),
                    DateCreated = new DateTime(2017,03,26),
                    Roles = new List<UserRole>() { UserRole.User }
                },
                new User
                {
                    Key = "4677396d-aac1-4263-b270-7a542a357175",
                    UserName = "Barnaby.McGray",
                    FirstName = "Barnaby",
                    LastName = "McGray",
                    EmailAddress = "bmcgray8@time.com",
                    PhoneNumber = "3165125562",
                    IsActive = false,
                    LastModified = new DateTime(2016,11,17),
                    DateCreated = new DateTime(2017,01,08),
                    Roles = new List<UserRole>() { UserRole.Admin, UserRole.User }
                },
                new User
                {
                    Key = "14c2ddf3-fc9d-4c73-849a-84b2f6c916d4",
                    UserName = "Hakim.Gallen",
                    FirstName = "Hakim",
                    LastName = "Gallen",
                    EmailAddress = "hgallen9@squidoo.com",
                    PhoneNumber = "5997360378",
                    IsActive = true,
                    LastModified = new DateTime(2001,04,09),
                    DateCreated = new DateTime(2017,06,19),
                    Roles = new List<UserRole>() { UserRole.User }
                }
            };
        }
    }
}