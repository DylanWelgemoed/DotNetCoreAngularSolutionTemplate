using System.Collections.Generic;
using Template.Auth.Models.Security;

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
                    UserName = "Robin.Shillabeer",
                    Password = "Shillabeer"
                },
                new Credentials
                {
                    UserName = "Florie.Satterfitt",
                    Password = "Satterfitt"
                },
                new Credentials
                {
                    UserName = "Floris.Coyish",
                    Password = "Coyish"
                },
                new Credentials
                {
                    UserName = "Jasun.Devenport",
                    Password = "Devenport"
                },
                new Credentials
                {
                    UserName = "Raynell.Dautry",
                    Password = "Dautry"
                },
                new Credentials
                {
                    UserName = "Fred.Elce",
                    Password = "Elce"
                },
                new Credentials
                {
                    UserName = "Ebenezer.Gehrts",
                    Password = "Gehrts"
                },
                new Credentials
                {
                    UserName = "Bibby.Filler",
                    Password = "Filler"
                },
                new Credentials
                {
                    UserName = "Barnaby.McGray",
                    Password = "McGray"
                },
                new Credentials
                {
                    UserName = "Hakim.Gallen",
                    Password = "Gallen"
                }
            };
        }
    }
}