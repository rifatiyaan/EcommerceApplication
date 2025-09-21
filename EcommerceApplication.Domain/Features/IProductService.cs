public interface IProductService
{
    Task CreateAsync(Product product);
    Task UpdateAsync(Product product);
    Task SoftDeleteAsync(int id); // 👈 renamed
    Task<Product> GetAsync(int id);
    Task<(IList<Product> records, int total, int totalDisplay)> GetPagedAsync(
        int pageIndex, int pageSize, string? searchText, string? sortBy);
}
