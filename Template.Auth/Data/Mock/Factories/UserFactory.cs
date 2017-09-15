using System.Collections.Generic;
using Template.Auth.Models;

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
                    Email = "tmorris0@hostgator.com",
                    FirstName = "Trudy",
                    LastName = "Morris",
                    UserName = "Trudy.Morris",
                    IsAdmin = true
                },
                new User
                {
                    Email = "wbraganza1@behance.net",
                    FirstName = "Wes",
                    LastName = "Braganza",
                    UserName = "Wes.Braganza",
                    IsAdmin = false
                },
                new User
                {
                    Email = "nalbion2@oaic.gov.au",
                    FirstName = "Nicolais",
                    LastName = "Albion",
                    UserName = "Nicolais.Albion",
                    IsAdmin = false
                },
                new User
                {
                    Email = "ablondelle3@gigabox.com",
                    FirstName = "Adolpho",
                    LastName = "Blondelle",
                    UserName = "Adolpho.Blondelle",
                    IsAdmin = false
                },
                new User
                {
                    Email = "rrowat4@census.gov",
                    FirstName = "Ramon",
                    LastName = "Rowat",
                    UserName = "Ramon.Rowat",
                    IsAdmin = true
                },
                new User
                {
                    Email = "jdines5@behance.net",
                    FirstName = "Jedidiah",
                    LastName = "Dines",
                    UserName = "Jedidiah.Dines",
                    IsAdmin = false
                },
                new User
                {
                    Email = "horry6@tripadvisor.com",
                    FirstName = "Harv",
                    LastName = "Orry",
                    UserName = "Harv.Orry",
                    IsAdmin = false
                },
                new User
                {
                    Email = "cpowell7@scientificamerican.com",
                    FirstName = "Charity",
                    LastName = "Powell",
                    UserName = "Charity.Powell",
                    IsAdmin = true
                },
                new User
                {
                    Email = "ggockeler8@wiley.com",
                    FirstName = "Gibbie",
                    LastName = "Gockeler",
                    UserName = "Gibbie.Gockeler",
                    IsAdmin = false
                },
                new User
                {
                    Email = "fbirrell9@youtube.com",
                    FirstName = "Frank",
                    LastName = "Birrell",
                    UserName = "Frank.Birrell",
                    IsAdmin = false
                }
            };
        }
    }
}