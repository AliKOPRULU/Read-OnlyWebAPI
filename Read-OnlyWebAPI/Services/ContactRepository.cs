using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Read_OnlyWebAPI.Models;

namespace Read_OnlyWebAPI.Services
{
    public class ContactRepository
    {
        private const string CacheKey = "ContactStore";

        public ContactRepository()
        {
            var ctx = HttpContext.Current;

            if (ctx != null)
            {
                if (ctx.Cache[CacheKey] == null)
                {
                    var contacts = new Contact[]
                    {
                        new Contact {Id=1,Name="Ali KÖPRÜLÜ" },
                        new Contact {Id=2,Name="Alper KÖPRÜLÜ" }
                    };
                    ctx.Cache[CacheKey] = contacts;
                }
            }
        }

        public Contact[] GetAllContacts()
        {
            var ctx = HttpContext.Current;

            if (ctx != null)
            {
                return (Contact[])ctx.Cache[CacheKey];
            }
            return new Contact[]
            {
                new Contact
                {
                    Id=0,
                    Name="Placeholder"
                }
            };
        }

        //public Contact[] GetAllContact()//Ex01
        //{
        //    return new Contact[]
        //    {
        //        new Contact {Id=1,Name="Ali KÖPRÜLÜ" },
        //        new Contact {Id=2,Name="Alper KÖPRÜLÜ" }
        //    };
        //}
    }
}