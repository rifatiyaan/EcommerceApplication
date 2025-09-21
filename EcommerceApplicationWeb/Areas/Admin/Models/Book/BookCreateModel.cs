//using Autofac;
//using EcommerceApplicationWeb.Domain.Features;

//namespace EcommerceApplicationWeb.Areas.Admin.Models.Book
//{
//    public class BookCreateModel
//    {
//        private ILifetimeScope _scope;

//        private IBookService _bookService;

//        public string Title { get; set; }

//        public string PublishDate { get; set; }

//        public string AuthorName { get; set; }

//        public BookCreateModel()
//        {

//        }
//        public BookCreateModel(IBookService bookService)
//        {
//            _bookService = bookService;
//        }

//        internal void Resolve(ILifetimeScope scope)
//        {
//            _scope = scope;
//            _bookService = _scope.Resolve<IBookService>();
//        }

//        internal async Task CreateBookAsync()
//        {
//            await _bookService.CreateBookAsync(Title, PublishDate, AuthorName);
//        }

//    }
//}
