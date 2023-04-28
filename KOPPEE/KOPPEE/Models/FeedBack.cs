using System.ComponentModel.DataAnnotations;

namespace KOPPEE.Models
{
    public class FeedBack
    {
        public int Id { get; set; }
        [Required]
        public string FullName { get; set; }
        public string Role { get; set; }
        public string Description { get; set; }
        public bool IsDeactive { get; set; }
        
    }
}
