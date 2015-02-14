// This class was automatically generated with love by ST4bby 2/14/2015 1:42:45 PM.
// Read more at http://jbubriski.github.com/ST4bby/

namespace Model
{
	using System;
	using System.ComponentModel.DataAnnotations;
	using System.ComponentModel.DataAnnotations.Schema;
	
	public class Region
	{
		[Key, Required, Display(Name="Region ID")]
		public int RegionID { get; set; }
		
		[Required, Display(Name="Region Description"), StringLength(100)]
		public char RegionDescription { get; set; }
	}
}
