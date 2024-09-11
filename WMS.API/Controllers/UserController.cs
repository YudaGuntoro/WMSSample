using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;
using System;
using WMS.Domain;
using WMS.Persistence.Services.CheckStockServices;
using WMS.Persistence.Services.UserServices;
using WMS.Domain.Entity;

namespace WMS.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        protected readonly IUserService Context;
        public UserController(IUserService _Data)
        {
            Context = _Data;
        }

        [HttpGet]
        [Route("GetAllUser")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<User>> GetAllUser()
        {
            try
            {
                var result = await Context.GetAllUser();
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
