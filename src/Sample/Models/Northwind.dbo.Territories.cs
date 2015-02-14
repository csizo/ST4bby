// This class was automatically generated with love by ST4bby 2/14/2015 1:42:46 PM.
// Read more at http://jbubriski.github.com/ST4bby/

namespace Model
{
	using System;
	using System.ComponentModel.DataAnnotations;
	using System.ComponentModel.DataAnnotations.Schema;
	
	public class Territories
	{
		[Key, Required, Display(Name="Territory ID"), StringLength(40)]
		public string TerritoryID { get; set; }
		
		[Required, Display(Name="Territory Description"), StringLength(100)]
		public char TerritoryDescription { get; set; }
		
		[Required, Display(Name="Region ID")]
		public int RegionID { get; set; }
	}
}
