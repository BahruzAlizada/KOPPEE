using System;
using System.ComponentModel.DataAnnotations;

namespace KOPPEE.Models
{
    public class Reservation
    {
        public int Id { get; set; }
        [Required(ErrorMessage ="Name can not be null")]
        public string Name { get; set; }
        [Required(ErrorMessage ="Phone number can not be null")]
        [DataType(DataType.PhoneNumber)]
        public string PhoneNumber { get; set; }
        [Required(ErrorMessage ="Date can not be null")]
        public DateTime CreatedTime { get; set; } = DateTime.Now;
        [Required(ErrorMessage ="Date can not be null")]
        [DataType(DataType.Date)]
        public DateTime Date { get; set; }
        [Required(ErrorMessage ="Time can not be null")]
        [DataType(DataType.Time)]
        public DateTime Time { get; set; }
        public bool IsDeactive { get; set; }
    }
}
