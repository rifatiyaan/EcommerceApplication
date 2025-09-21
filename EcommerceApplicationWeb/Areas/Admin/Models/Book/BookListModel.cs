//using EcommerceApplicationWeb.Domain.Features;
//using EcommerceApplicationWeb.Infrastructure;
//using System.Web;

//namespace EcommerceApplicationWeb.Areas.Admin.Models.Book
//{
//    public class BookListModel
//    {
//        private readonly IBookService _bookService;
//        public BookListModel()
//        {

//        }
//        public BookListModel(IBookService bookService)
//        {
//            _bookService = bookService;

//        }


//        public async Task<object> GetPagedBookAsync(DataTablesAjaxRequestUtility dataTablesUtility)
//        {
//            var data = await _bookService.GetPagedBooksAsync(
//                dataTablesUtility.PageIndex,
//                dataTablesUtility.PageSize,
//                dataTablesUtility.SearchText,
//                dataTablesUtility.GetSortText(new string[] { "Title", "PublishDate", "AuthorName" }));

//            return new
//            {
//                recordsTotal = data.total,
//                recordsFiltered = data.totalDisplay,
//                data = (from record in data.records
//                        select new string[]
//                        {
//                                HttpUtility.HtmlEncode(record.Title),
//                                HttpUtility.HtmlEncode(record.PublishDate),
//                                HttpUtility.HtmlEncode(record.AuthorName),
//                                record.Id.ToString()
//                        }
//                    ).ToArray()
//            };
//        }
//        internal async Task DeleteBookAsync(Guid id)
//        {
//            await _bookService.DeleteBookAsync(id);
//        }
//    }
//}

