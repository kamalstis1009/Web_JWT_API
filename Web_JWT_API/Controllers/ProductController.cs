using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using SSL_MIS_API.Models;
using Web_JWT_API.Models;
using Web_JWT_API.Services;

namespace Web_JWT_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductService _service;
        private readonly JWTSettings _jwtsettings;

        public ProductController(IProductService service, IOptions<JWTSettings> jwtsettings)
        {
            _service = service; //dependency injection
            _jwtsettings = jwtsettings.Value;
        }

        //======================================================| GET
        [Authorize]
        [HttpGet("GetObjectById")]
        public async Task<IActionResult> GetObjectById([FromQuery] Guid id)
        {
            var response = await _service.GetObjectById(id);
            if (response != null)
            {
                return Ok(response);
            }
            return NotFound();
        }

        //======================================================| ADD
        [Authorize]
        [HttpPost("AddObject")]
        public async Task<IActionResult> AddObject([FromBody] Product model)
        {
            if (model == null)
            {
                throw new ArgumentNullException(nameof(model));
            }
            else
            {
                var response = await _service.AddObject(model);
                if (response != null)
                {
                    //return Ok(response);
                    return CreatedAtAction(nameof(GetObjectById), new { id = model.ProductId }, model); //Get model after creating
                }
                return NotFound();
            }
        }

        //======================================================| UPDATE
        [Authorize]
        [HttpPut("UpdateObjectById")]
        public async Task<IActionResult> UpdateObjectById([FromQuery] Guid id, [FromBody] Product model)
        {
            var response = await _service.UpdateObjectById(id, model);
            if (response != null)
            {
                return Ok(response);
            }
            return NotFound();
        }

        //======================================================| DELETE
        [Authorize]
        [HttpDelete("DeleteObjectById")]
        public async Task<IActionResult> DeleteObjectById([FromQuery] Guid id)
        {
            var response = await _service.DeleteObjectById(id);
            if (response != null)
            {
                return Ok(response);
            }
            return NotFound();
        }

        

    }
}
