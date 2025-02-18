using datoriummerch.Models;
using Microsoft.AspNetCore.Mvc;

namespace datoriummerch.Controllers
{
    [Route("api/datorium-merch")]
    [ApiController]
    public class MerchController
    {
        private readonly MerchContext _dbContext;
        public MerchController(MerchContext context)
        {
            _dbContext = context;
        }

        [HttpGet("ok")] // api/datorium-merch/ok
        public ActionResult<string> GetOk()
        {
            return "OK";
        }
        [HttpGet] // api/datorium-merch
        public ActionResult<IEnumerable<Merch>> GetMerch()
        {
            return _dbContext.Merches.ToList();
        }
    }
}