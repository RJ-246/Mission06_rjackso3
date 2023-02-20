using System;
using System.ComponentModel.DataAnnotations;

namespace Mission06_rjackso3.Models
{
	public class Category
	{
		[Key]
		[Required]
		public int CategoryID { get; set; }
		public string CategoryName { get; set; }

	}
}

