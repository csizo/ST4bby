// This class was automatically generated with love by ST4bby 2/14/2015 1:42:46 PM.
// Read more at http://jbubriski.github.com/ST4bby/

namespace Model
{
	using System;
	using System.ComponentModel.DataAnnotations;
	using System.ComponentModel.DataAnnotations.Schema;
	
	public class CustomerCustomerDemo
	{
		[Key, Required, Display(Name="Customer ID"), StringLength(10)]
		public char CustomerID { get; set; }
		
		[Key, Required, Display(Name="Customer Type ID"), StringLength(20)]
		public char CustomerTypeID { get; set; }
	}
}
