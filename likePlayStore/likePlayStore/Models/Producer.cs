using System.ComponentModel.DataAnnotations;

namespace likePlayStore.Models
{
    public class Producer:IEntity
    {
        public int Id { get; set; }
        public string Developer { get; set; }
        public string Email { get; set; }
        public string? Biography { get; set; }

        public ICollection<Application> Applications { get; set; }
    }
}
