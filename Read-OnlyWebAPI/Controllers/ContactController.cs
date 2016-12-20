using Read_OnlyWebAPI.Models;
using Read_OnlyWebAPI.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;

namespace Read_OnlyWebAPI.Controllers
{
    public class ContactController : ApiController
    {
        private ContactRepository contactRepository;
        //public string[] Get()
        //{
        //    return new string[]
        //    {
        //        "Hello",
        //        "World"
        //    };
        //}

        public ContactController()
        {
            this.contactRepository = new ContactRepository();
        }

        //public Contact[] Get()
        //{
        //    return new Contact[]
        //    {
        //        new Contact {Id=1,Name="Ali KÖPRÜLÜ" },
        //        new Contact {Id=2,Name="Dan Roth" }
        //    };
        //}

        public Contact[] Get()
        {
            return this.contactRepository.GetAllContact();
        }
    }
}