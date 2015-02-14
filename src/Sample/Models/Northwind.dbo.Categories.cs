// This class was automatically generated with love by ST4bby 2/14/2015 1:42:46 PM.
// Read more at http://jbubriski.github.com/ST4bby/

namespace Model
{
	using System;
	using System.ComponentModel.DataAnnotations;
	using System.ComponentModel.DataAnnotations.Schema;
	
	public class Categories
	{
		[Key, DatabaseGenerated(DatabaseGeneratedOption.Identity), Required, Display(Name="Category ID")]
		public int CategoryID { get; set; }
		
		[Required, Display(Name="Category Name"), StringLength(30)]
		public string CategoryName { get; set; }
		
		[Display(Name="Description")]
		public string Description { get; set; }
		
		[Display(Name="Picture")]
		public string Picture { get; set; }
	}
}
