// This class was automatically generated with love by ST4bby 2/14/2015 1:42:47 PM.
// Read more at http://jbubriski.github.com/ST4bby/

namespace Model
{
	using System;
	using System.ComponentModel.DataAnnotations;
	using System.ComponentModel.DataAnnotations.Schema;
	
	public class EmployeeTerritories
	{
		[Key, Required, Display(Name="Employee ID")]
		public int EmployeeID { get; set; }
		
		[Key, Required, Display(Name="Territory ID"), StringLength(40)]
		public string TerritoryID { get; set; }
	}
}
