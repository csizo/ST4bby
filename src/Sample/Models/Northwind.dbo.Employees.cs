// This class was automatically generated with love by ST4bby 2/14/2015 1:42:45 PM.
// Read more at http://jbubriski.github.com/ST4bby/

namespace Model
{
	using System;
	using System.ComponentModel.DataAnnotations;
	using System.ComponentModel.DataAnnotations.Schema;
	
	public class Employees
	{
		[Key, DatabaseGenerated(DatabaseGeneratedOption.Identity), Required, Display(Name="Employee ID")]
		public int EmployeeID { get; set; }
		
		[Required, Display(Name="Last Name"), StringLength(40)]
		public string LastName { get; set; }
		
		[Required, Display(Name="First Name"), StringLength(20)]
		public string FirstName { get; set; }
		
		[Display(Name="Title"), StringLength(60)]
		public string Title { get; set; }
		
		[Display(Name="Title Of Courtesy"), StringLength(50)]
		public string TitleOfCourtesy { get; set; }
		
		[Display(Name="Birth Date")]
		public Nullable<DateTime> BirthDate { get; set; }
		
		[Display(Name="Hire Date")]
		public Nullable<DateTime> HireDate { get; set; }
		
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
		
		[Display(Name="Home Phone"), StringLength(48)]
		public string HomePhone { get; set; }
		
		[Display(Name="Extension"), StringLength(8)]
		public string Extension { get; set; }
		
		[Display(Name="Photo")]
		public string Photo { get; set; }
		
		[Display(Name="Notes")]
		public string Notes { get; set; }
		
		[Display(Name="Reports To")]
		public Nullable<int> ReportsTo { get; set; }
		
		[Display(Name="Photo Path"), StringLength(510)]
		public string PhotoPath { get; set; }
	}
}
