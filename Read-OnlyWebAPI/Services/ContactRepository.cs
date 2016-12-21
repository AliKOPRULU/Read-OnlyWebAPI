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

        public Contact[] GetAllContacts()//03
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

        public bool SaveContact(Contact contact)//work of saving a contact. 
        {
            var ctx = HttpContext.Current;

            if (ctx != null)
            {
                try
                {
                    var currentData = ((Contact[])ctx.Cache[CacheKey]).ToList();
                    currentData.Add(contact);
                    ctx.Cache[CacheKey] = currentData.ToArray();

                    return true;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.ToString());
                    return false;
                }
            }
            return false;
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