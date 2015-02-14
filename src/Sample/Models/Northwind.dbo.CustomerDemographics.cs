// This class was automatically generated with love by ST4bby 2/14/2015 1:42:45 PM.
// Read more at http://jbubriski.github.com/ST4bby/

namespace Model
{
	using System;
	using System.ComponentModel.DataAnnotations;
	using System.ComponentModel.DataAnnotations.Schema;
	
	public class CustomerDemographics
	{
		[Key, Required, Display(Name="Customer Type ID"), StringLength(20)]
		public char CustomerTypeID { get; set; }
		
		[Display(Name="Customer Desc")]
		public string CustomerDesc { get; set; }
	}
}
