using ISmartServices;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SmartDomain;

namespace SmartCore.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ApperovalController : ControllerBase
    {
        public ApperovalController(IApperovalServices apperovalServices)
        {
            ApperovalServices = apperovalServices;
        }

        public IApperovalServices ApperovalServices { get; }

        [HttpGet("GetAll")]
        public async Task<List<Apperoal>> GetAll()
        {
            return await ApperovalServices.GetAll();
        }

        [HttpPost("PostAll")]
        public async Task<List<Apperoal>> PostAll()
        {
            return await ApperovalServices.GetAll();
        }

        [HttpDelete("DeleteAll")]
        public async Task<List<Apperoal>> DeleteAll()
        {
            return await ApperovalServices.GetAll();
        }

        [HttpPut("PutAll")]
        public async Task<List<Apperoal>> PutAll()
        {
            return await ApperovalServices.GetAll();
        }

        [HttpPatch("PatchAll")]
        public async Task<List<Apperoal>> PatchAll()
        {
            return await ApperovalServices.GetAll();
        }



    }
}
