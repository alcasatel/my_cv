﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Routing;
using System.Web.Mvc;

namespace Metanit.Controllers
{
    public class MyController : IController
    {
        public void Execute(RequestContext requestContext)
        {
            string ip = requestContext.HttpContext.Request.UserHostAddress;
            var response = requestContext.HttpContext.Response;
            response.Write("<h2> Ваш ай-пи адрес: " + ip + "</h2>");
        }
    }
}