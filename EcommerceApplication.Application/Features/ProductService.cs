using EcommerceApplicationWeb.Application;
using Microsoft.EntityFrameworkCore;

public class ProductService : IProductService
{
    private readonly IApplicationUnitOfWork _unitOfWork;

    public ProductService(IApplicationUnitOfWork unitOfWork)
    {
        _unitOfWork = unitOfWork;
    }

    public async Task CreateAsync(Product product)
    {
        _unitOfWork.ProductRepository.Add(product);
        await _unitOfWork.SaveAsync();
    }

    public async Task UpdateAsync(Product product)
    {
        var existing = await _unitOfWork.ProductRepository.GetByIdAsync(product.Id);
        if (existing != null && existing.IsActive)
        {
            existing.Title = product.Title;
            existing.Code = product.Code;
            existing.Price = product.Price;
            existing.Stock = product.Stock;
            existing.CategoryId = product.CategoryId;
            existing.ImageUrl = product.ImageUrl;
            existing.Metadata = product.Metadata;
            existing.ParentId = product.ParentId;
            existing.UpdatedAt = DateTime.UtcNow;
        }
        await _unitOfWork.SaveAsync();
    }

    public async Task SoftDeleteAsync(int id) // 👈 updated
    {
        var product = await _unitOfWork.ProductRepository.GetByIdAsync(id);
        if (product != null && product.IsActive)
        {
            product.IsActive = false;
            product.UpdatedAt = DateTime.UtcNow;
            await _unitOfWork.SaveAsync();
        }
    }

    public async Task<Product> GetAsync(int id)
    {
        return await _unitOfWork.ProductRepository.Query()
            .FirstOrDefaultAsync(p => p.Id == id && p.IsActive);
    }

    public async Task<(IList<Product> records, int total, int totalDisplay)> GetPagedAsync(
        int pageIndex,
        int pageSize,
        string? searchText,
        string? sortBy,
        int? categoryId = null,
        decimal? minPrice = null,
        decimal? maxPrice = null)
    {
        var query = _unitOfWork.ProductRepository.Query()
            .Where(p => p.IsActive); // 👈 only active

        if (!string.IsNullOrWhiteSpace(searchText))
        {
            query = query.Where(p => p.Title.Contains(searchText) || p.Code.Contains(searchText));
        }

        if (categoryId.HasValue)
            query = query.Where(p => p.CategoryId == categoryId.Value);

        if (minPrice.HasValue)
            query = query.Where(p => p.Price >= minPrice.Value);

        if (maxPrice.HasValue)
            query = query.Where(p => p.Price <= maxPrice.Value);

        var total = await query.CountAsync();

        query = sortBy?.ToLower() switch
        {
            "title" => query.OrderBy(p => p.Title),
            "price" => query.OrderBy(p => p.Price),
            _ => query.OrderBy(p => p.Id)
        };

        var records = await query
            .Skip((pageIndex - 1) * pageSize)
            .Take(pageSize)
            .ToListAsync();

        return (records, total, total);
    }

    public Task<(IList<Product> records, int total, int totalDisplay)> GetPagedAsync(
        int pageIndex, int pageSize, string? searchText, string? sortBy)
    {
        // redirect to the full one but without filters
        return GetPagedAsync(pageIndex, pageSize, searchText, sortBy, null, null, null);
    }
}
