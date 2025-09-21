using AutoMapper;
using EcommerceApplicationWeb.Application.DTOs;
using EcommerceApplicationWeb.Infrastructure;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace EcommerceApplicationWeb.Web.Api
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductService _productService;
        private readonly IApplicationDbContext _context;
        private readonly IMapper _mapper;

        public ProductController(IProductService productService, IApplicationDbContext context, IMapper mapper)
        {
            _productService = productService;
            _context = context;
            _mapper = mapper;
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            var product = await _context.Products
                .Include(p => p.Category)
                .FirstOrDefaultAsync(p => p.Id == id && p.IsActive);

            if (product == null)
                return NotFound();

            var dto = _mapper.Map<ProductResponseDto>(product);
            return Ok(dto);
        }

        [HttpGet]
        public async Task<IActionResult> GetPaged(
            [FromQuery] int pageIndex = 1,
            [FromQuery] int pageSize = 10,
            [FromQuery] string? searchText = null,
            [FromQuery] string? sortBy = null)
        {
            var query = _context.Products
                .Include(p => p.Category)
                .Where(p => p.IsActive)
                .AsQueryable();

            if (!string.IsNullOrWhiteSpace(searchText))
                query = query.Where(p => p.Title.Contains(searchText) || p.Code.Contains(searchText));

            query = sortBy?.ToLower() switch
            {
                "price" => query.OrderBy(p => p.Price),
                "price_desc" => query.OrderByDescending(p => p.Price),
                _ => query.OrderBy(p => p.Title)
            };

            var total = await query.CountAsync();
            var records = await query.Skip((pageIndex - 1) * pageSize).Take(pageSize).ToListAsync();

            var dtoList = _mapper.Map<List<ProductResponseDto>>(records);

            return Ok(new { total, totalDisplay = dtoList.Count, data = dtoList });
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromBody] ProductRequestDto dto)
        {
            var product = _mapper.Map<Product>(dto);
            await _productService.CreateAsync(product);

            var response = _mapper.Map<ProductResponseDto>(product);
            return CreatedAtAction(nameof(Get), new { id = product.Id }, response);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Update(int id, [FromBody] ProductRequestDto dto)
        {
            var product = _mapper.Map<Product>(dto);
            product.Id = id;

            await _productService.UpdateAsync(product);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> SoftDelete(int id)
        {
            await _productService.SoftDeleteAsync(id);
            return NoContent();
        }
    }
}
