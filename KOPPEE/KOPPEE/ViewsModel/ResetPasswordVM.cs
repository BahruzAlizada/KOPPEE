using System.ComponentModel.DataAnnotations;

namespace KOPPEE.ViewsModel
{
    public class ResetPasswordVM
    {
        public string Id { get; set; }
        [Required(ErrorMessage ="Password can not be null")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        [Required(ErrorMessage ="Password can not be null")]
        [DataType(DataType.Password)]
        [Compare("Password")]
        public string CheckPassword { get; set; }
        public bool IsRemember { get; set; }
        
    }
}
