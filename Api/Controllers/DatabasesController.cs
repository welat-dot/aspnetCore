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
        [Authorize()]
        public IActionResult Get()
        {
            //var a = HttpContext.User.Claims.ToList();
            //var b = a[3].Value;
            var result = databasesManager.GetAll();
            if (result.success)
                return Ok(result.data);
            return BadRequest();
        }
        [Route(template:"add"),HttpPost]
        [Authorize()]
        public IActionResult Add(Databases database)
        {
            var result = databasesManager.Add(database);
            if (result.success)
                return Ok();
            return BadRequest();
        }
    }
}
