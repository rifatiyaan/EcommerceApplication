//using Autofac;
//using EcommerceApplicationWeb.Areas.Admin.Models.Book;
//using EcommerceApplicationWeb.Infrastructure;
//using Microsoft.AspNetCore.Mvc;

//namespace EcommerceApplicationWeb.Web.Areas.Admin.Controllers
//{
//    [Area("Admin")]
//    public class BookController : Controller
//    {
//        private readonly ILifetimeScope _scope;
//        private readonly ILogger<BookController> _logger;

//        public BookController(ILifetimeScope scope, ILogger<BookController> logger)
//        {
//            _logger = logger;
//            _scope = scope;
//        }
//        public IActionResult Index()
//        {
//            return View();
//        }

//        public IActionResult Create()
//        {
//            var model = _scope.Resolve<BookCreateModel>();
//            return View(model);
//        }
//        [HttpPost, ValidateAntiForgeryToken]
//        public async Task<IActionResult> Create(BookCreateModel model)
//        {
//            if (ModelState.IsValid)
//            {
//                try
//                {
//                    model.Resolve(_scope);
//                    await model.CreateBookAsync();
//                    TempData.Put("ResponseMessage", new ResponseModel
//                    {
//                        Message = "Book created successfully",
//                        Type = ResponseTypes.Success
//                    });
//                    return RedirectToAction("Index");
//                }
//                catch (Exception ex)
//                {
//                    _logger.LogError(ex, "Server error");
//                    TempData.Put("ResponseMessage", new ResponseModel
//                    {
//                        Message = "There was a problem creating the book",
//                        Type = ResponseTypes.Danger
//                    });
//                }
//            }
//            return View(model);
//        }
//        public async Task<JsonResult> GetBooks()
//        {
//            var dataTablesModel = new DataTablesAjaxRequestUtility(Request);
//            var model = _scope.Resolve<BookListModel>();
//            var data = await model.GetPagedBookAsync(dataTablesModel);
//            return Json(data);
//        }

//        public async Task<IActionResult> Update(Guid id)
//        {
//            var model = _scope.Resolve<BookUpdateModel>();
//            await model.LoadAsync(id);
//            return View(model);
//        }

//        [HttpPost, ValidateAntiForgeryToken]
//        public async Task<IActionResult> Update(BookUpdateModel model)
//        {
//            model.Resolve(_scope);
//            if (ModelState.IsValid)
//            {
//                try
//                {

//                    await model.UpdateBookAsync();
//                    return RedirectToAction("Index");
//                }
//                catch (Exception ex)
//                {
//                    _logger.LogError(ex, "Server error");
//                    TempData.Put("ResponseMessage", new ResponseModel
//                    {
//                        Message = "There was a problem updating the book",
//                        Type = ResponseTypes.Danger
//                    });
//                }
//            }
//            return View(model);
//        }

//        [HttpPost, ValidateAntiForgeryToken]
//        public async Task<IActionResult> Delete(Guid id)
//        {
//            var model = _scope.Resolve<BookListModel>();

//            if (ModelState.IsValid)
//            {
//                try
//                {
//                    await model.DeleteBookAsync(id); TempData.Put("ResponseMessage", new ResponseModel
//                    {
//                        Message = "Book deleted successfuly",
//                        Type = ResponseTypes.Success
//                    });

//                    return RedirectToAction("Index");
//                }
//                catch (Exception e)
//                {
//                    _logger.LogError(e, "Server Error");

//                    TempData.Put("ResponseMessage", new ResponseModel
//                    {
//                        Message = "There was a problem in deleting book",
//                        Type = ResponseTypes.Danger
//                    });
//                }
//            }

//            return RedirectToAction("Index");
//        }
//    }




//}

