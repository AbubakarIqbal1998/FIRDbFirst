using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Services.Feature.Admins.Core.DataModel;
using Services.Feature.Admins.Interface;
using Services.Feature.Admins.Service;


namespace FIR.APIGateway.Areas.Adminsss.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AdminsController : ControllerBase
    {
        public AdminService service;

        public AdminsController(AdminService service)
        {
            this.service = service;
        }
        [HttpPost]
        [Route("PostAdmin")]
        public async Task<IActionResult> PostAdmin([FromBody] Admin abj)
        {
          await  service.PostAdmin(abj);
            return Ok();
        }

        [HttpPut]
        [Route("PutAdmin")]
        public async Task<IActionResult> PutAdmin([FromBody] Admin abj)
        {
            await service.PutAdmin(abj);
            return Ok();
        }
    }
}
