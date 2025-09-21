using EcommerceApplicationWeb.Application;
using Microsoft.EntityFrameworkCore;

public class CategoryService : ICategoryService
{
    private readonly IApplicationUnitOfWork _unitOfWork;

    public CategoryService(IApplicationUnitOfWork unitOfWork)
    {
        _unitOfWork = unitOfWork;
    }

    public async Task CreateAsync(Category category)
    {
        _unitOfWork.CategoryRepository.Add(category);
        await _unitOfWork.SaveAsync();
    }

    public async Task SoftDeleteAsync(int id) // 👈 updated
    {
        var category = await _unitOfWork.CategoryRepository.GetByIdAsync(id);
        if (category == null)
            throw new KeyNotFoundException($"Category with ID {id} not found.");

        if (category.IsActive)
        {
            category.IsActive = false;
            category.UpdatedAt = DateTime.UtcNow;
            await _unitOfWork.SaveAsync();
        }
    }

    public async Task UpdateAsync(Category category)
    {
        var existing = await _unitOfWork.CategoryRepository.GetByIdAsync(category.Id);
        if (existing != null && existing.IsActive)
        {
            existing.Title = category.Title;
            existing.Description = category.Description;
            existing.Metadata = category.Metadata;
            existing.UpdatedAt = DateTime.UtcNow;

            await _unitOfWork.SaveAsync();
        }
    }

    public async Task<Category> GetAsync(int id)
    {
        return await _unitOfWork.CategoryRepository.Query()
            .Include(c => c.Products)
            .FirstOrDefaultAsync(c => c.Id == id && c.IsActive);
    }

    public async Task<(IList<Category> records, int total, int totalDisplay)> GetPagedAsync(
        int pageIndex, int pageSize, string? searchText, string? sortBy)
    {
        var query = _unitOfWork.CategoryRepository.Query()
            .Where(c => c.IsActive); // 👈 only active

        if (!string.IsNullOrWhiteSpace(searchText))
        {
            query = query.Where(c => c.Title.Contains(searchText));
        }

        var total = await query.CountAsync();

        query = sortBy?.ToLower() switch
        {
            "title" => query.OrderBy(c => c.Title),
            _ => query.OrderBy(c => c.Id)
        };

        var records = await query
            .Skip((pageIndex - 1) * pageSize)
            .Take(pageSize)
            .ToListAsync();

        return (records, total, total);
    }
}
