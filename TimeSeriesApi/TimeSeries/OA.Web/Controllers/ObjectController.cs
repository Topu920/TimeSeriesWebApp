using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

using OA.Service;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OA.Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ObjectController : ControllerBase
    {
        private readonly IObjectService service;

        public ObjectController(IObjectService service)
        {
            this.service = service;
        }

        [HttpGet]
        [ActionName("GetObjectList")]
        public async Task<IActionResult> GetObjectList()
        {
            return Ok(await service.GetObjects());
        }
    }
}
