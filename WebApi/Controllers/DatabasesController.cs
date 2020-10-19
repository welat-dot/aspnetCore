using Business.Abstract.MasterBusiness;
using Microsoft.AspNetCore.Mvc;
namespace WebApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class DatabasesController : ControllerBase
    {
        private IDatabasesManager databasesManager;
        private IUsersManager usersManager;



        public DatabasesController(IDatabasesManager databasesManager, IUsersManager usersManager)
        {
            this.databasesManager = databasesManager;
            this.usersManager = usersManager;
        }

        [HttpGet(template: "getAllListDatabases")]
        public IActionResult GetDatabasesList()
        {
            var result = databasesManager.GetAll();
            if (result.success)
                return Ok(result.data);
            return BadRequest();

        }
    }
}