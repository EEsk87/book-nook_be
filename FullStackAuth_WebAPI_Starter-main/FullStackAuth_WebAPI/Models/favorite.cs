using System;
namespace FullStackAuth_WebAPI.Models
{
	public class favorite
	{
		public int ID { get; set; }
		public string BookId { get; set; }
		public string Title { get; set; }
		public string ThumbnailURL { get; set; }

		public string UserId { get; set; }
		public User user { get; set; }
	}
}

