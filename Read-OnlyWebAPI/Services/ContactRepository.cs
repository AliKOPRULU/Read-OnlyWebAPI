using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Read_OnlyWebAPI.Models;

namespace Read_OnlyWebAPI.Services
{
    public class ContactRepository
    {
        public Contact[] GetAllContact()
        {
            return new Contact[]
            {
                new Contact {Id=1,Name="Ali KÖPRÜLÜ" },
                new Contact {Id=2,Name="Alper KÖPRÜLÜ" }
            };
        }
    }
}