using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Starterkit.Web.BL.ViewModels;
using Starterkit.Web.BL;

namespace Starterkit.Controllers
{
	namespace Starterkit.Web.Controllers
	{
		public class ProductApiController : Controller
		{
			List<ProductDTO> _products;
			public ProductApiController()
			{
				_products = new List<ProductDTO>()
				{

			   new ProductDTO() {Availability = Availability.InStock, Category = Category.Blue, Id = 1, DisplayName = "TypeWriter Is Awesome" },
			   new ProductDTO() {Availability = Availability.BackOrdered, Category = Category.Red, Id = 2, DisplayName = "TypeScript Is Awesome" },
			   new ProductDTO() {Availability = Availability.OutOfStock, Category = Category.Green, Id = 3, DisplayName = "RevGen Is Awesome" }
			};
			}

			[HttpGet]
			public ProductDTO GetProduct(int productId)
			{
				// _product = _service.get(productId);
				return _products.SingleOrDefault(x => x.Id == productId);
			}

			[HttpGet]
			public List<ProductDTO> SearchProducts(string productName)
			{
				//var _products = _service.search(productName);
				return _products;
			}

			//[HttpGet]
			//[Route("searchcomplex")]
			//public List<ProductDTO> SearchComplexProducts([FromUri]ProductSearchCriteriaDTO searchCriteria)
			//{
			//	//var _products = _service.search(productName);
			//	return _products;
			//}

			[HttpPost]
			public bool EditProduct(ProductDTO product)
			{
				//_service.update(product);
				return true;
			}
		}
	}
}
