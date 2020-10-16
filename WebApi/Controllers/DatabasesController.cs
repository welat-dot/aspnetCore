using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Business.Abstract.MasterBusiness;
namespace WebApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class DatabasesController:ControllerBase
    {
        private IDatabasesManager databasesManager;
        private IUsersManager usersManager;

       

        public DatabasesController(IDatabasesManager databasesManager,IUsersManager usersManager)
        {
            this.databasesManager = databasesManager;
            this.usersManager=usersManager;
        }

        [HttpGet(template:"getAllListDatabases")]
        public IActionResult GetDatabasesList()
        {
            var result=databasesManager.GetAll();
            if(result.success)
                return Ok(result.data);
            return BadRequest();
            
        }
    }
}