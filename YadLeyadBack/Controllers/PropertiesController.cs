using Appilcation.Interfaces;
using Appilcation.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace YadLeyadBack.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PropertiesController : ControllerBase
    {
        private readonly IPropertyService _propertyService;
        public PropertiesController(IPropertyService propertyService)
        {
            _propertyService = propertyService;
        }
        [Authorize]
        [HttpPost]
        [Route("add-property")]
        public async Task<IActionResult> AddProperty(AddPropertyModel addPropertyModel)
        {
            try
            {   
                var res = await _propertyService.AddProperty(addPropertyModel);
                return Ok(res);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet]
        [Route("address-details")]
        public async Task<IActionResult> GetCityStreetAddressDetails([FromQuery] string val)
        {
            try
            {
                var result = await _propertyService.GetCityStreetAddressDetails(val);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
