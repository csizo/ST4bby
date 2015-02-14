// This class was automatically generated with love by ST4bby 2/14/2015 1:42:46 PM.
// Read more at http://jbubriski.github.com/ST4bby/

namespace Model
{
	using System;
	using System.ComponentModel.DataAnnotations;
	using System.ComponentModel.DataAnnotations.Schema;
	
	public class Orders
	{
		[Key, DatabaseGenerated(DatabaseGeneratedOption.Identity), Required, Display(Name="Order ID")]
		public int OrderID { get; set; }
		
		[Display(Name="Customer ID"), StringLength(10)]
		public Nullable<char> CustomerID { get; set; }
		
		[Display(Name="Employee ID")]
		public Nullable<int> EmployeeID { get; set; }
		
		[Display(Name="Order Date")]
		public Nullable<DateTime> OrderDate { get; set; }
		
		[Display(Name="Required Date")]
		public Nullable<DateTime> RequiredDate { get; set; }
		
		[Display(Name="Shipped Date")]
		public Nullable<DateTime> ShippedDate { get; set; }
		
		[Display(Name="Ship Via")]
		public Nullable<int> ShipVia { get; set; }
		
		[Display(Name="Freight")]
		public Nullable<decimal> Freight { get; set; }
		
		[Display(Name="Ship Name"), StringLength(80)]
		public string ShipName { get; set; }
		
		[Display(Name="Ship Address"), StringLength(120)]
		public string ShipAddress { get; set; }
		
		[Display(Name="Ship City"), StringLength(30)]
		public string ShipCity { get; set; }
		
		[Display(Name="Ship Region"), StringLength(30)]
		public string ShipRegion { get; set; }
		
		[Display(Name="Ship Postal Code"), StringLength(20)]
		public string ShipPostalCode { get; set; }
		
		[Display(Name="Ship Country"), StringLength(30)]
		public string ShipCountry { get; set; }
	}
}
