using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations.Schema;

namespace KOPPEE.Models
{
    public class About
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string SubTitleStory { get; set; }
        public string StoryDescription { get; set; }
        public string VisionDescription { get; set; }
        public string VisionGoalOne { get; set; }
        public string VisionGoalTwo { get; set; }
        public string VisionGoalThree { get; set; }
        public string Image { get; set; }
        [NotMapped]
        public IFormFile Photo { get; set; }
    }
}
