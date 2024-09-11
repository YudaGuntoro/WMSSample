using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WMS.Domain;
using WMS.Domain.DTOs;
using WMS.Domain.Entity;
using WMS.Persistence.Services.CheckStockServices;

namespace WMS.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CheckStockController : ControllerBase
    {
        protected readonly ICheckStockService Context;
        public CheckStockController(ICheckStockService _Data)
        {
            Context = _Data;
        }

        [HttpGet]
        [Route("GetPartStock/{PartNo}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<Balance>> GetPartStockByPartNo(int PartNo)
        {
            try
            {
                var result = await Context.GetBalanceByPartNo(PartNo);
                var response = new ApiResponse<IEnumerable<Balance>>
                {
                    Success = true,
                    Data = result,
                    ErrorMessage = ""
                };
                return Ok(response);
            }
            catch (Exception ex)
            {
                //log error
                return StatusCode(500, ex.Message);
            }
        }


        [HttpGet]
        [Route("GetItemInfo/{LotNo}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<ItemInfo>> ItemInfo(int LotNo)
        {
            try
            {
                var result = await Context.GetItemInfo(LotNo);
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
