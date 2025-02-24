using Appilcation.Interfaces;
using Appilcation.Models;
using Microsoft.AspNetCore.Mvc;

namespace YadLeyadBack.Controllers
{
    public class CategoriesController : ControllerBase
    {
        
        private readonly ICategoryService _categoryService;
        private IConfiguration _config;
        public CategoriesController(ICategoryService categoryService, IConfiguration config)
        {
            _categoryService = categoryService;
            _config = config;
        }
        [HttpGet]
        [Route("get-categories")]
        public async Task<IActionResult> GetCategories()
        {
            try
            {
                var listCategories = await _categoryService.GetCategoriesList();
                return Ok(listCategories);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        
    }
}
