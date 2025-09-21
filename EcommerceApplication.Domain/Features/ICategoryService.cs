public interface ICategoryService
{
    Task CreateAsync(Category category);
    Task UpdateAsync(Category category);
    Task SoftDeleteAsync(int id); // 👈 renamed
    Task<Category> GetAsync(int id);
    Task<(IList<Category> records, int total, int totalDisplay)> GetPagedAsync(
        int pageIndex, int pageSize, string? searchText, string? sortBy);
}
