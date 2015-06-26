﻿using System.Collections.Generic;
using System.Security.Claims;
using Thinktecture.IdentityServer.Core.Services.InMemory;

namespace ExpenseTracker.IdSrv.Config
{
    public static class Users
    {
        public static List<InMemoryUser> Get()
        {
            return new List<InMemoryUser>() {
           
            new InMemoryUser
            {
                Username = "Kevin",
                Password = "secret",
                Subject = "1",

                Claims = new[]
                {
                    new Claim(Thinktecture.IdentityServer.Core.Constants.ClaimTypes.GivenName, "Kevin"),
                    new Claim(Thinktecture.IdentityServer.Core.Constants.ClaimTypes.FamilyName, "Dockx"),
                    new Claim(Thinktecture.IdentityServer.Core.Constants.ClaimTypes.Role, "WebReadUser"),
                    new Claim(Thinktecture.IdentityServer.Core.Constants.ClaimTypes.Role, "WebWriteUser"),
                    new Claim(Thinktecture.IdentityServer.Core.Constants.ClaimTypes.Role, "MobileReadUser"),
                    new Claim(Thinktecture.IdentityServer.Core.Constants.ClaimTypes.Role, "MobileWriteUser") 
               }
            }
            ,
            new InMemoryUser
            {
                Username = "Sven",
                Password = "secret",
                Subject = "2",

                Claims = new[]
                {
                    new Claim(Thinktecture.IdentityServer.Core.Constants.ClaimTypes.GivenName, "Sven"),
                    new Claim(Thinktecture.IdentityServer.Core.Constants.ClaimTypes.FamilyName, "Vercauteren"),
                    new Claim(Thinktecture.IdentityServer.Core.Constants.ClaimTypes.Role, "WebReadUser"),
                    new Claim(Thinktecture.IdentityServer.Core.Constants.ClaimTypes.Role, "MobileReadUser")
               }
            },
             
            new InMemoryUser
            {
                Username = "Nils",
                Password = "secret",
                Subject = "3",

                Claims = new[]
                {
                    new Claim(Thinktecture.IdentityServer.Core.Constants.ClaimTypes.GivenName, "Nils"),
                    new Claim(Thinktecture.IdentityServer.Core.Constants.ClaimTypes.FamilyName, "Missorten"),
                    new Claim(Thinktecture.IdentityServer.Core.Constants.ClaimTypes.Role, "WebWriteUser"), //The user cannot read data anymore
                    new Claim(Thinktecture.IdentityServer.Core.Constants.ClaimTypes.Role, "MobileWriteUser")
               }
            },

            new InMemoryUser
            {
                Username = "Kenneth",
                Password = "secret",
                Subject = "4",

                Claims = new[]
                {
                    new Claim(Thinktecture.IdentityServer.Core.Constants.ClaimTypes.GivenName, "Kenneth"),
                    new Claim(Thinktecture.IdentityServer.Core.Constants.ClaimTypes.FamilyName, "Mills"),
                    new Claim(Thinktecture.IdentityServer.Core.Constants.ClaimTypes.Role, "WebReadUser"),
                    new Claim(Thinktecture.IdentityServer.Core.Constants.ClaimTypes.Role, "WebWriteUser") 
               }
            },
            new InMemoryUser
            {
                Username = "Geert",
                Password = "secret",
                Subject = "5",

                Claims = new[]
                {
                    new Claim(Thinktecture.IdentityServer.Core.Constants.ClaimTypes.GivenName, "Geert"),
                    new Claim(Thinktecture.IdentityServer.Core.Constants.ClaimTypes.FamilyName, "Huls"),
                    new Claim(Thinktecture.IdentityServer.Core.Constants.ClaimTypes.Role, "WebReadUser"),
                    new Claim(Thinktecture.IdentityServer.Core.Constants.ClaimTypes.Role, "WebWriteUser"),
                    new Claim(Thinktecture.IdentityServer.Core.Constants.ClaimTypes.Role, "MobileReadUser"),
                    new Claim(Thinktecture.IdentityServer.Core.Constants.ClaimTypes.Role, "MobileWriteUser") 
               }
            }
           };
        }
    }
}