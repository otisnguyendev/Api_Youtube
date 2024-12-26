using Api_Youtube.Dto;
using Api_Youtube.Service;
using Microsoft.AspNetCore.Mvc;

namespace Api_Youtube.Controller;

[Route("api/categories")]
[ApiController]
public class CategoryController : ControllerBase
{
    private readonly CategoryService _categoryService;

    public CategoryController(CategoryService categoryService)
    {
        _categoryService = categoryService;
    }

    [HttpGet]
    public async Task<IActionResult> GetAllCategories()
    {
        var categories = await _categoryService.GetAllCategoriesAsync();
        return Ok(categories);
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> GetCategoryById(int id)
    {
        var category = await _categoryService.GetCategoryByIdAsync(id);
        if (category == null)
        {
            return NotFound();
        }
        return Ok(category);
    }

    [HttpPost]
    public async Task<IActionResult> CreateCategory([FromBody] CategoryDto categoryDto)
    {
        if (categoryDto == null)
        {
            return BadRequest();
        }

        await _categoryService.CreateCategoryAsync(categoryDto);
        return CreatedAtAction(nameof(GetCategoryById), new { id = categoryDto.Name }, categoryDto);
    }

    [HttpPut("{id}")]
    public async Task<IActionResult> UpdateCategory(int id, [FromBody] CategoryDto categoryDto)
    {
        if (categoryDto == null || id <= 0)
        {
            return BadRequest();
        }

        await _categoryService.UpdateCategoryAsync(id, categoryDto);
        return NoContent();  
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> DeleteCategory(int id)
    {
        await _categoryService.DeleteCategoryAsync(id);
        return NoContent();
    }
}
