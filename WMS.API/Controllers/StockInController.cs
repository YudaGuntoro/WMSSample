using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using System;
using WMS.Domain.Request;
using WMS.Persistence.Services.StockOutService;
using WMS.Persistence.Services.StockInServices;

namespace WMS.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StockInController : ControllerBase
    {
        protected readonly IStockInService Context;
        public StockInController(IStockInService _Data)
        {
            Context = _Data;
        }
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [HttpPost]
        [Route("v1/StockIn")]
        public async Task<IActionResult> StockInAsync(StockIn Data)
        {
            try
            {
                var result = await Context.StockIn(Data);
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
