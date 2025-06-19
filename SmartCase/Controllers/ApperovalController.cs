using ISmartServices;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SmartDomain;
using SmartInfrastructure;

namespace SmartCase.Controllers
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

        [HttpGet]
        public async Task<List<Apperoal>> GetAll()
        {
            return await ApperovalServices.GetAll();
        }
    }
}
