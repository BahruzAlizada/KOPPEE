using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace KOPPEE.Models
{
	public class Service
	{
		public int Id { get; set; }
		[Required]
		public string Name { get; set; }
		public string Description { get; set; }
		public string Image { get; set; }
		[NotMapped]
		public IFormFile Photo { get; set; }
		public bool IsDeactive { get; set; }
	}
}
