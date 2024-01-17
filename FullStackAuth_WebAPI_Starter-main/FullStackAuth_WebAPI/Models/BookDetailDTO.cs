
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;




namespace FullStackAuth_WebAPI.Models
{
	public class BookDetailDTO
	{
		[Key]

		public int Id { get; set; }
		public string BookId { get; set; }
		public double AverageRating { get; set; }

		[ForeignKey("Review")]
		public Review review { get; set; }




		

		
		
	}
}

