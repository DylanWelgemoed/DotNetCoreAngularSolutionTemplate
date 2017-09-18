using System.Collections.Generic;
using Template.Auth.Models;

namespace Template.Auth.Data.Mock.Factories
{
    internal static class SecurityFactory
    {
        internal static IList<Credentials> Build()
        {
            return new List<Credentials>
            {
                new Credentials
                {
                    UserName = "Trudy.Morris",
                    Password = "Morris"
                },
                new Credentials
                {
                    UserName = "Wes.Braganza",
                    Password = "Braganza"
                },
                new Credentials
                {
                    UserName = "Nicolais.Albion",
                    Password = "Albion"
                },
                new Credentials
                {
                    UserName = "Adolpho.Blondelle",
                    Password = "Blondelle"
                },
                new Credentials
                {
                    UserName = "Ramon.Rowat",
                    Password = "Rowat"
                },
                new Credentials
                {
                    UserName = "Jedidiah.Dines",
                    Password = "Dines"
                },
                new Credentials
                {
                    UserName = "Harv.Orry",
                    Password = "Orry"
                },
                new Credentials
                {
                    UserName = "Charity.Powell",
                    Password = "Powell"
                },
                new Credentials
                {
                    UserName = "Gibbie.Gockeler",
                    Password = "Gockeler"
                },
                new Credentials
                {
                    UserName = "Frank.Birrell",
                    Password = "Birrell"
                }
            };
        }
    }
}