// This class was automatically generated with love by ST4bby 2/14/2015 1:42:46 PM.
// Read more at http://jbubriski.github.com/ST4bby/

namespace Model
{
	using System;
	using System.ComponentModel.DataAnnotations;
	using System.ComponentModel.DataAnnotations.Schema;
	
	public class OrderDetails
	{
		[Key, Required, Display(Name="Order ID")]
		public int OrderID { get; set; }
		
		[Key, Required, Display(Name="Product ID")]
		public int ProductID { get; set; }
		
		[Required, Display(Name="Unit Price")]
		public decimal UnitPrice { get; set; }
		
		[Required, Display(Name="Quantity")]
		public short Quantity { get; set; }
		
		[Required, Display(Name="Discount")]
		public string Discount { get; set; }
	}
}
