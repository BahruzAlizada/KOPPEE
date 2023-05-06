using System.ComponentModel.DataAnnotations;

namespace KOPPEE.ViewsModel
{
    public class UpdateVM
    {

        [Required(ErrorMessage ="Name can not be null")]
        public string Name { get; set; }
        [Required]
        public string Surname { get; set; }
        [Required(ErrorMessage ="UserName can not be null")]
        public string UserName { get; set; }
        [Required(ErrorMessage ="Email can not be null")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        public string Role { get; set; }
    }
}
