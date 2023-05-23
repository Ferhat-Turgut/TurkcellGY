using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace likePlayStore.Models
{
    public class Application : IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime? ReleaseDate { get; set; }
        public string? Description { get; set; }
        public double Rating { get; set; }
        public Int64 DowloadCounter { get; set; }
        public bool IsInstalled { get; set; }

        //Navigation
        public Producer Producer { get; set; }
        public int ProducerId { get; set; }

        public ICollection<ApplicationsCategories> Categories { get; set; } = new HashSet<ApplicationsCategories>();

    }
}
