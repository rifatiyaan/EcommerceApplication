//using EcommerceApplicationWeb.Domain.Entities;
//using EcommerceApplicationWeb.Domain.Repositories;
//using Microsoft.EntityFrameworkCore;

//namespace EcommerceApplicationWeb.Infrastructure.Repositories
//{
//    public class BookRepository : Repository<Book, Guid>, IBookRepository
//    {
//        public BookRepository(IApplicationDbContext context) : base((DbContext)context)
//        {


//        }


//        public async Task<(IList<Book> records, int total, int totalDisplay)> GetTableDataAsync(int pageIndex, int pageSize, string searchText, string orderBy)
//        {
//            return await GetDynamicAsync(x => x.Title.Contains(searchText), orderBy, null, pageIndex, pageSize);
//        }
//    }
//}
