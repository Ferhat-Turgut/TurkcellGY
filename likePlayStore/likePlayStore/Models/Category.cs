using System.ComponentModel.DataAnnotations;

namespace likePlayStore.Models
{
    public class Category : IEntity
    {
        public int Id { get; set; }
        [Required,MaxLength(30)]
        public string Name { get; set; }
        public string? Description { get; set; }

        public ICollection<ApplicationsCategories> Applications { get; set; } = new HashSet<ApplicationsCategories>();
    }
}
