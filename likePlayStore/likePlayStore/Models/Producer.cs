using System.ComponentModel.DataAnnotations;

namespace likePlayStore.Models
{
    public class Producer:IEntity
    {
        public int Id { get; set; }
        [Required,MaxLength(75)]
        public string Developer { get; set; }
        [Required,EmailAddress]
        public string Email { get; set; }
        [MaxLength(500)]
        public string? Biography { get; set; }

        public ICollection<Application> Applications { get; set; }
    }
}
