namespace likePlayStore.Models
{
    public class ApplicationsCategories
    {
        public int ApplicationId { get; set; }
        public Application Application { get; set; }

        public int CategoryId { get; set; }
        public Category Category { get; set; }
    }
}
