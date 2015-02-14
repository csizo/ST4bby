// This class was automatically generated with love by ST4bby 2/14/2015 1:42:46 PM.
// Read more at http://jbubriski.github.com/ST4bby/

namespace Model
{
	using System;
	using System.ComponentModel.DataAnnotations;
	using System.ComponentModel.DataAnnotations.Schema;
	
	public class Shippers
	{
		[Key, DatabaseGenerated(DatabaseGeneratedOption.Identity), Required, Display(Name="Shipper ID")]
		public int ShipperID { get; set; }
		
		[Required, Display(Name="Company Name"), StringLength(80)]
		public string CompanyName { get; set; }
		
		[Display(Name="Phone"), StringLength(48)]
		public string Phone { get; set; }
	}
}
