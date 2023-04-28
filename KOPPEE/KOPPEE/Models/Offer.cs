using System.ComponentModel.DataAnnotations;

namespace KOPPEE.Models
{
    public class Offer
    {
        public int Id { get; set; }
        [Required(ErrorMessage ="Title can not be null")]
        public string Title { get; set; }
        public string SubTitle { get; set; }
        public string Description { get; set; }
    }
}
