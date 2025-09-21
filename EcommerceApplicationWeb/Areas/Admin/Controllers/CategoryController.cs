using AutoMapper;
using EcommerceApplicationWeb.Application.DTOs;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace EcommerceApplicationWeb.Web.Api
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        private readonly ICategoryService _categoryService;
        private readonly IMapper _mapper;

        public CategoryController(ICategoryService categoryService, IMapper mapper)
        {
            _categoryService = categoryService;
            _mapper = mapper;
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            var category = await _categoryService.GetAsync(id);
            if (category == null) return NotFound();

            var dto = _mapper.Map<CategoryResponseDto>(category);
            return Ok(dto);
        }

        [HttpGet]
        public async Task<IActionResult> GetPaged(
            [FromQuery] int pageIndex = 1,
            [FromQuery] int pageSize = 10,
            [FromQuery] string? searchText = null,
            [FromQuery] string? sortBy = null)
        {
            var (records, total, totalDisplay) =
                await _categoryService.GetPagedAsync(pageIndex, pageSize, searchText, sortBy);

            var dtoList = _mapper.Map<List<CategoryResponseDto>>(records);

            return Ok(new { total, totalDisplay, data = dtoList });
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromBody] CategoryRequestDto dto)
        {
            var category = _mapper.Map<Category>(dto);
            await _categoryService.CreateAsync(category);

            var response = _mapper.Map<CategoryResponseDto>(category);
            return CreatedAtAction(nameof(Get), new { id = category.Id }, response);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Update(int id, [FromBody] CategoryRequestDto dto)
        {
            var category = _mapper.Map<Category>(dto);
            category.Id = id;

            await _categoryService.UpdateAsync(category);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> SoftDelete(int id)
        {
            await _categoryService.SoftDeleteAsync(id);
            return NoContent();
        }
    }
}
