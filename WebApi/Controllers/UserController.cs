using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Data.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        const string token = "1245ASDFA$%ASDFASGAS";

        //JSON in body
        //Content-Type: application/json
        [HttpPost]
        [Route("[action]")]
        public ActionResult<string> Login([FromBody] UserLogin userLogin)
        {
            return token;
        }

        //Use QueryString
        [HttpPost]
        [Route("[action]")]
        public ActionResult<string> Login2([FromQuery] UserLogin userLogin)
        {
            return token;
        }

        //Use FormFields in body
        //Content-Type: application/x-www-form-urlencoded
        [HttpPost]
        [Route("[action]")]
        public ActionResult<string> Login3([FromForm] UserLogin userLogin)
        {
            return token;
        }

        [Authorize]
        [HttpGet]
        [Route("[action]")]
        public ActionResult<string> GetUsername()
        {
            return User.Identity.Name;
        }

    }
}