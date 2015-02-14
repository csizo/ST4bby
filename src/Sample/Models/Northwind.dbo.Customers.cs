// This class was automatically generated with love by ST4bby 2/14/2015 1:42:46 PM.
// Read more at http://jbubriski.github.com/ST4bby/

namespace Model
{
	using System;
	using System.ComponentModel.DataAnnotations;
	using System.ComponentModel.DataAnnotations.Schema;
	
	public class Customers
	{
		[Key, Required, Display(Name="Customer ID"), StringLength(10)]
		public char CustomerID { get; set; }
		
		[Required, Display(Name="Company Name"), StringLength(80)]
		public string CompanyName { get; set; }
		
		[Display(Name="Contact Name"), StringLength(60)]
		public string ContactName { get; set; }
		
		[Display(Name="Contact Title"), StringLength(60)]
		public string ContactTitle { get; set; }
		
		[Display(Name="Address"), StringLength(120)]
		public string Address { get; set; }
		
		[Display(Name="City"), StringLength(30)]
		public string City { get; set; }
		
		[Display(Name="Region"), StringLength(30)]
		public string Region { get; set; }
		
		[Display(Name="Postal Code"), StringLength(20)]
		public string PostalCode { get; set; }
		
		[Display(Name="Country"), StringLength(30)]
		public string Country { get; set; }
		
		[Display(Name="Phone"), StringLength(48)]
		public string Phone { get; set; }
		
		[Display(Name="Fax"), StringLength(48)]
		public string Fax { get; set; }
	}
}
