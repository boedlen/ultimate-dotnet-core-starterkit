using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Starterkit.Web.BL.ViewModels
{
	public class ProductDTO : BaseDTO
	{
		public string DisplayName { get; set; }
		public DateTime CreatedDate { get; set; }
		public DateTime ModifiedDate { get; set; }
		public Category Category { get; set; }
		public Availability Availability { get; set; }
	}
}
