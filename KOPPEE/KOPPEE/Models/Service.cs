using System.ComponentModel.DataAnnotations;

namespace KOPPEE.Models
{
	public class Service
	{
		public int Id { get; set; }
		[Required]
		public string Name { get; set; }
		public string Description { get; set; }
		public string Image { get; set; }
		public bool IsDeactive { get; set; }
	}
}
