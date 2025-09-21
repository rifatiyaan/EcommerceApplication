public interface IUserService
{
    Task CreateAsync(User user);
    Task UpdateAsync(User user);
    Task DeleteAsync(Guid id);  // <-- change int to Guid
    Task<User> GetAsync(Guid id); // <-- change int to Guid
    Task<User?> GetByEmailAsync(string email);

}
