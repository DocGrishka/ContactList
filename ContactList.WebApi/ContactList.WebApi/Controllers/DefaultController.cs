﻿using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace ContactList.WebApi.Controllers
{
    [Route("api")]
    public class DefaultController : Controller
    {
        // GET: api/get
        [HttpGet("get")]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }
    }
}
