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
    public class ReadingController : ControllerBase
    {
        private readonly IReadingService service;

        public ReadingController(IReadingService service)
        {
            this.service = service;
        }

        [HttpGet]
        [ActionName("GetAllReadingData")]
        public async Task<IActionResult> GetAllReadingData()
        {
            var result = await service.GetReadings();
            //result = result.Where(i => i.ObjectId == 2).ToList();

            var query = result.Select(g => new { name = g.TimeStamp, count = g.Value }).ToList();
            // for ( )
            return Ok(query);
        }

        [HttpGet]
        [Route("GetReadingList")]
        public async Task<IActionResult> GetReadingList( int buildingId,  int objectId,
             int dataFieldId,  DateTime? startTime,  DateTime? endTime)
        {
            var result = await service.GetReadingsList(buildingId, objectId,
                 dataFieldId, startTime, endTime);
            var query = result.Select(g => new { name = g.TimeStamp, count = g.Value }).ToList();
            return Ok(query);
        }
        



    }

   
}
