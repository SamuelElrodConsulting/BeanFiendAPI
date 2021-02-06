using BeanFiendAPI.Model;
using BeanFiendAPI.Persistence.SQLite;
using Microsoft.AspNetCore.Mvc;

namespace BeanFiendAPI.Web.Controllers
{
    public class BeanerController : BaseApiController
    {
        private readonly BeanFiendSQLiteDbContext _dbContext;

        public BeanerController(BeanFiendSQLiteDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_dbContext.Beaners);
        }

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            return Ok(_dbContext.Beaners.Find(id));
        }

        [HttpPost]
        public IActionResult Post(Beaner beaner)
        {
            _dbContext.Add(beaner);
            _dbContext.SaveChanges();

            return Ok(beaner);
        }
    }
}