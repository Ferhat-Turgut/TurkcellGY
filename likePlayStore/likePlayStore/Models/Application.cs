using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace likePlayStore.Models
{
    public class Application : IEntity
    {
        public int Id { get; set; }
        [Required,MaxLength(50)]
        public string Name { get; set; }
        [Required]
        public DateTime ReleaseDate { get; set; }
        [MaxLength(300)]
        public string? Description { get; set; }
        [Required]
        public double Rating { get; set; }
        [Required]
        public Int64 DowloadCounter { get; set; }
        [Required]
        public bool IsInstalled { get; set; }

        //Navigation
        public Producer Producer { get; set; }
        public int ProducerId { get; set; }

        public ICollection<ApplicationsCategories> Categories { get; set; } = new HashSet<ApplicationsCategories>();

    }
}
