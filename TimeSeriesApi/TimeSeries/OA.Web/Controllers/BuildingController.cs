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
    public class BuildingController : ControllerBase
    {
        private readonly IBuildingService buildingService;

        public BuildingController(IBuildingService buildingService)
        {
            this.buildingService = buildingService;
        }

        [HttpGet]
        [ActionName("GetBuildingList")]
        public async Task<IActionResult> GetBuildingList()
        {
            return Ok(await buildingService.GetBuildings());
        }
    }
}
