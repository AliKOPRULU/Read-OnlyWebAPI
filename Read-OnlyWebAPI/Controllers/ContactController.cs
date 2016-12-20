using Read_OnlyWebAPI.Models;
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
        //public string[] Get()
        //{
        //    return new string[]
        //    {
        //        "Hello",
        //        "World"
        //    };
        //}

        public Contact[] Get()
        {
            return new Contact[]
            {
                new Contact {Id=1,Name="Ali KÖPRÜLÜ" },
                new Contact {Id=2,Name="Dan Roth" }
            };
        }
    }
}