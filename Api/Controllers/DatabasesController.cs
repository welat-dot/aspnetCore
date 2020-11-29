using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Business.Abstract.MasterBusiness;
using Core.Utilitis.Result;
using entities.MasterTable;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DatabasesController : ControllerBase
    {
        private IDatabasesManager databasesManager;
        public DatabasesController(IDatabasesManager databasesManager)
        {
            this.databasesManager = databasesManager;
        }
        
        [Route(template:"getall"),HttpGet]
        [Authorize(Roles = "SystemAdministor")]
        public IActionResult Get()
        {
            var result = databasesManager.GetAll();
           if (result.success)
             return Ok(result.data);
            return BadRequest();
        }
        [Authorize(Roles = "DatabasesList")]
        [Route(template: "getDatabases"), HttpGet]
        public IActionResult GetUserDatabasses()
        {
            var a = HttpContext.User.Claims.ToList();
            int UserId = Convert.ToInt32(a[0].Value);
            var result = databasesManager.GetByUsers(UserId);
            if (result.success)
                return Ok(result.data);
            return BadRequest(result.message);
        }
        [Route(template:"add"),HttpPost]
        [Authorize(Roles = "DatabasesCreate")]
        public IActionResult Add(Databases database)
        {
            var a = HttpContext.User.Claims.ToList();
            int UserId = Convert.ToInt32(a[0].Value);
            database.UsersRefId = UserId;
            var result = databasesManager.Add(entity:database);
            if (result.success)
                return Ok(result);
            return BadRequest(result);
        }
    }
}
