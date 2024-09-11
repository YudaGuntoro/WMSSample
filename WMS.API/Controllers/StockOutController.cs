using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using System;
using WMS.Persistence.Services.StockOutService;
using WMS.Persistence.Services.UserServices;
using WMS.Domain.Request;

namespace WMS.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StockOutController : ControllerBase
    {
        protected readonly IStockOutService Context;
        public StockOutController(IStockOutService _Data)
        {
            Context = _Data;
        }
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [HttpPost]
        [Route("v1/StockOut")]
        public async Task<IActionResult> StockOutAsync(StockOut Data)
        {
            try
            {
                var result = await Context.StockOut(Data);
                return Ok(result);
            }
            catch (Exception ex)
            {
                //log error
                return StatusCode(500, ex.Message);
            }
        }
    }
}
