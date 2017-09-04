﻿using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace MiddlewareTest.Controller
{
    public class HomeController
    {
        public string Index(int? id)
        {
            return $"Hello,Robert,{id}";
        }

        //Attribute routing allows (and requires) precise control of which route templates apply to each action.
        [Route("Home/Attribute")]
        public string AttributeContent()
        {
            //var url = Url.Action("Index");
            return "Attribute!";
        }
        public string Test(int id)
        {
            return "Test1";
        }

        [HttpPost]
        public string Test(int id, string s)
        {
            return "Test2";
        }
    }
}
