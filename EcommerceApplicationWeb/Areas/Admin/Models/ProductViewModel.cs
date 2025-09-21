//using Autofac;
//using EcommerceApplicationWeb.Domain.Features;
//using EcommerceApplicationWeb.Infrastructure;
//using System.Web;

//namespace EcommerceApplicationWeb.Areas.Admin.Models
//{
//    public class ProductViewModel
//    {
//        private ILifetimeScope _scope;
//        private IProductService _productService;

//        public ProductViewModel() { }
//        public ProductViewModel(IProductService productService)
//        {
//            _productService = productService;
//        }

//        internal void Resolve(ILifetimeScope scope)
//        {
//            _scope = scope;
//            _productService = _scope.Resolve<IProductService>();
//        }

//        public Guid Id { get; set; }
//        public string Name { get; set; } = null!;
//        public string? Description { get; set; }
//        public decimal Price { get; set; }
//        public int Stock { get; set; }
//        public Guid CategoryId { get; set; }
//        public string? ImageUrl { get; set; }

//        internal async Task CreateAsync()
//        {
//            await _productService.CreateProductAsync(Name, Description, Price, Stock, CategoryId, ImageUrl);
//        }

//        internal async Task LoadAsync(Guid id)
//        {
//            var product = await _productService.GetProductAsync(id);
//            if (product is not null)
//            {
//                Id = product.Id;
//                Name = product.Name;
//                Description = product.Description;
//                Price = product.Price;
//                Stock = product.Stock;
//                CategoryId = product.CategoryId;
//                ImageUrl = product.ImageUrl;
//            }
//        }

//        internal async Task UpdateAsync()
//        {
//            await _productService.UpdateProductAsync(Id, Name, Description, Price, Stock, CategoryId, ImageUrl);
//        }

//        internal async Task DeleteAsync(Guid id)
//        {
//            await _productService.DeleteProductAsync(id);
//        }

//        internal async Task<object> GetPagedAsync(DataTablesAjaxRequestUtility dt)
//        {
//            var data = await _productService.GetPagedProductsAsync(
//                dt.PageIndex,
//                dt.PageSize,
//                dt.SearchText,
//                dt.GetSortText(new string[] { "Name", "Price", "Stock" })
//            );

//            return new
//            {
//                recordsTotal = data.total,
//                recordsFiltered = data.totalDisplay,
//                data = data.records.Select(r => new string[]
//                {
//                    HttpUtility.HtmlEncode(r.Name),
//                    HttpUtility.HtmlEncode(r.Description),
//                    r.Price.ToString(),
//                    r.Stock.ToString(),
//                    r.Id.ToString()
//                }).ToArray()
//            };
//        }
//    }
//}
