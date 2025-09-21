using System.Security.Cryptography;
using System.Text;

namespace EcommerceApplicationWeb.Application.Features
{
    public class UserService : IUserService
    {
        private readonly IApplicationUnitOfWork _unitOfWork;

        public UserService(IApplicationUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task CreateAsync(User user)
        {
            if (!string.IsNullOrWhiteSpace(user.PasswordHash))
                user.PasswordHash = HashPassword(user.PasswordHash);

            _unitOfWork.UserRepository.Add(user);
            await _unitOfWork.SaveAsync();
        }

        public async Task UpdateAsync(User user)
        {
            var existing = await _unitOfWork.UserRepository.GetByIdAsync(user.Id);
            if (existing != null)
            {
                existing.Username = user.Username;
                existing.Email = user.Email;
                if (!string.IsNullOrWhiteSpace(user.PasswordHash))
                    existing.PasswordHash = HashPassword(user.PasswordHash);
            }
            await _unitOfWork.SaveAsync();
        }

        public async Task DeleteAsync(Guid id)
        {
            await _unitOfWork.UserRepository.RemoveAsync(id); // use the actual Guid
            await _unitOfWork.SaveAsync();
        }

        public async Task<User> GetAsync(Guid id)
        {
            return await _unitOfWork.UserRepository.GetByIdAsync(id); // use the actual Guid
        }

        public async Task<User?> GetByEmailAsync(string email)
        {
            return await _unitOfWork.UserRepository.GetByEmailAsync(email);
        }


        private static string HashPassword(string password)
        {
            using var sha = SHA256.Create();
            var bytes = sha.ComputeHash(Encoding.UTF8.GetBytes(password));
            return Convert.ToBase64String(bytes);
        }

        public bool VerifyPassword(string password, string hash)
        {
            return HashPassword(password) == hash;
        }
    }
}
