using System;
using System.ComponentModel.DataAnnotations;

namespace Mission06_rjackso3.Models
{
	public class NewMovieData
	{
		[Key]
		[Required]
		public int MovieID { get; set; }
        [Required]
        public string Title { get; set; }
        [Required]
        public ushort Year { get; set; }
        [Required]
        public string Director { get; set; }
        [Required]
        public string Rating { get; set; }
		public bool Edited { get; set; }
		public string LentTo { get; set; }
		[StringLength(25, ErrorMessage = "Notes are limited to 25 characters.")]
		public string Notes { get; set; }


        //ForeignKey Relationships
        [Required]
        public int CategoryID { get; set; }
        public Category category { get; set; }
    }
}

