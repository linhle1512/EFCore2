using Microsoft.AspNetCore.Mvc;
using EFcore.DTOs;
using EFcore.Services;

namespace EFcore.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CategoriesController
    {
        private readonly ICategoryService _categoryService;

        public CategoriesController(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }

        [HttpGet]
        public IEnumerable<GetCategoryResponse> GetAll()
        {
            return _categoryService.GetAll();
        }

        [HttpGet("{id}")]
        public GetCategoryResponse? GetById(int id)
        {
            return _categoryService.GetById(id);
        }

        [HttpPost]
        public AddCategoryResponse? Add([FromBody] AddCategoryRequest requestModel)
        {
            return _categoryService.Create(requestModel);
        }

        [HttpPut]
        public UpdateCategoryResponse? Update([FromBody] UpdateCategoryRequest requestModel)
        {
            return _categoryService.Update(requestModel);
        }

        [HttpDelete("{id}")]
        public bool Delete(int id)
        {
            return _categoryService.Delete(id);
        }
    }
}