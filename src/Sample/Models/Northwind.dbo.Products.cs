// This class was automatically generated with love by ST4bby 2/14/2015 1:42:46 PM.
// Read more at http://jbubriski.github.com/ST4bby/

namespace Model
{
	using System;
	using System.ComponentModel.DataAnnotations;
	using System.ComponentModel.DataAnnotations.Schema;
	
	public class Products
	{
		[Key, DatabaseGenerated(DatabaseGeneratedOption.Identity), Required, Display(Name="Product ID")]
		public int ProductID { get; set; }
		
		[Required, Display(Name="Product Name"), StringLength(80)]
		public string ProductName { get; set; }
		
		[Display(Name="Supplier ID")]
		public Nullable<int> SupplierID { get; set; }
		
		[Display(Name="Category ID")]
		public Nullable<int> CategoryID { get; set; }
		
		[Display(Name="Quantity Per Unit"), StringLength(40)]
		public string QuantityPerUnit { get; set; }
		
		[Display(Name="Unit Price")]
		public Nullable<decimal> UnitPrice { get; set; }
		
		[Display(Name="Units In Stock")]
		public Nullable<short> UnitsInStock { get; set; }
		
		[Display(Name="Units On Order")]
		public Nullable<short> UnitsOnOrder { get; set; }
		
		[Display(Name="Reorder Level")]
		public Nullable<short> ReorderLevel { get; set; }
		
		[Required, Display(Name="Discontinued")]
		public bool Discontinued { get; set; }
	}
}
