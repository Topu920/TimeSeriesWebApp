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
    public class DataFieldController : ControllerBase
    {
        private readonly IDataFieldService service;

        public DataFieldController(IDataFieldService service)
        {
            this.service = service;
        }

        [HttpGet]
        [ActionName("GetDataFieldList")]
        public async Task<IActionResult> GetDataFieldList()
        {
            return Ok(await service.GetDataFields());
        }
    }
}
