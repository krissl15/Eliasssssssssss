using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ActuallEntityTest.Shared;
using ActuallEntityTest.Shared.Models;
using ActuallEntityTest.Shared.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace ActuallEntityTest.Server.Controllers {
    [ApiController]
    [Route("[controller]")]
    public class ProductController : Controller {

        AppDbContext context;

        public ProductController() {
            var context = new AppDbContext();
        }

        [HttpGet]
        public IEnumerable<ProductViewModel> GetAllProducts() {
            using var context = this.context;
            var products = context.Products;

            return products.Select(x => MapToViewModel(x));
        }

        ProductViewModel MapToViewModel(ProductModel product) {
            return new ProductViewModel {
                Name = product.Name,
                ProductId = product.ProductId
            };
        }
    }


}
