using Microsoft.AspNetCore.Mvc;
using my_test_api.Model;

namespace my_test_api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserOrderController : ControllerBase
    {
        DBContext dbContext;
        public UserOrderController(DBContext dBContext)
        {
            this.dbContext = dBContext;
        }
        // GET api/<UserOrderController>/1
        [HttpGet("{id}")]
        public string Get(int id)
        {
            var query = (from u in dbContext.Set<TableUser>()
                        join o in dbContext.Set<TableOrder>()
                        on u.Key equals o.UserKey
                        where u.Key == id
                        select new { u, o }).SingleOrDefault();
            string result = $"UserKey: {query.u.Key}, UserName: {query.u.Name}, OrderKey: {query.u.Key}, OrderCode: {query.o.Code}";
            return result;
        }
    }
}
