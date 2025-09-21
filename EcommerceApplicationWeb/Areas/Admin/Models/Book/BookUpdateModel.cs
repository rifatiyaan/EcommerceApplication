//using Autofac;
//using EcommerceApplicationWeb.Domain.Entities;
//using EcommerceApplicationWeb.Domain.Features;
//using System.ComponentModel.DataAnnotations;

//namespace EcommerceApplicationWeb.Areas.Admin.Models.Book
//{
//    public class BookUpdateModel
//    {
//        [Required]
//        public Guid Id { get; set; }
//        [Required]
//        public string Title { get; set; }
//        [Required]
//        public string PublishDate { get; set; }
//        public string AuthorName { get; set; }

//        private IBookService _bookService;

//        public BookUpdateModel()
//        {

//        }

//        public BookUpdateModel(IBookService bookService)
//        {
//            _bookService = bookService;
//        }

//        internal void Resolve(ILifetimeScope scope)
//        {
//            _bookService = scope.Resolve<IBookService>();
//        }

//        internal async Task LoadAsync(Guid id)
//        {
//            Book book = await _bookService.GetBookAsync(id);
//            if (book is not null)
//            {
//                Id = book.Id;
//                Title = book.Title;
//                PublishDate = book.PublishDate;
//                AuthorName = book.AuthorName;
//            }
//        }

//        internal async Task UpdateBookAsync()
//        {
//            if (!string.IsNullOrWhiteSpace(Title)
//                )
//            {
//                await _bookService.UpdateBookAsync(Id, Title, PublishDate, AuthorName);
//            }
//        }
//    }
//}

