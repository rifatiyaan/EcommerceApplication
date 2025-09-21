//using EcommerceApplicationWeb.Domain.Entities;
//using EcommerceApplicationWeb.Domain.Features;

//namespace EcommerceApplicationWeb.Application.Features
//{
//    public class BookService : IBookService
//    {
//        private readonly IApplicationUnitOfWork _unitOfWork;

//        public BookService(IApplicationUnitOfWork unitOfWork)
//        {
//            _unitOfWork = unitOfWork;
//        }
//        public async Task CreateBookAsync(string title, string publishDate, string authorName)
//        {
//            Book book = new Book
//            {
//                Title = title,
//                PublishDate = publishDate,
//                AuthorName = authorName
//            };
//            _unitOfWork.BookRepository.Add(book);
//            await _unitOfWork.SaveAsync();
//        }

//        public async Task DeleteBookAsync(Guid id)
//        {
//            await _unitOfWork.BookRepository.RemoveAsync(id);
//            await _unitOfWork.SaveAsync();
//        }

//        public async Task<Book> GetBookAsync(Guid id)
//        {
//            return await _unitOfWork.BookRepository.GetByIdAsync(id);
//        }



//        public async Task<(IList<Book> records, int total, int totalDisplay)> GetPagedBooksAsync(int pageIndex, int pageSize, string searchText, string sortBy)
//        {
//            return await _unitOfWork.BookRepository.GetTableDataAsync(pageIndex, pageSize, searchText, sortBy);
//        }

//        public async Task UpdateBookAsync(Guid id, string title, string publishDate, string authorName)
//        {
//            var book = await GetBookAsync(id);
//            if (book is not null)
//            {
//                book.Title = title;
//                book.PublishDate = publishDate;
//                book.AuthorName = authorName;
//            }
//            await _unitOfWork.SaveAsync();
//        }

//    }
//}
