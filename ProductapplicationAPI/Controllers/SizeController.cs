using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProductBusiness.Services;
using ProductEntity;
using System;
using System.Collections.Generic;

namespace ProductapplicationAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SizeController : ControllerBase
    {
        
        

            private SizeService _sizeService;

            public SizeController(SizeService sizeService)
            {
                _sizeService = sizeService;
            }
            [HttpPost("AddSize")]
            public IActionResult AddSize([FromBody] Size size)
              {
             
            _sizeService.Addsize(size);
            return Ok("article created succesfully");
 
              }
            [HttpGet("GetSize")]
            public Size GetSize(Guid id)
            {
                return _sizeService.GetSize(id);
            }

        }
    }
