namespace TodoApi.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; }

        public string? Name { get; set; }
        public int DisplayOrder { get; set; }
        public DateTime CreatedDate { get; set; } = DateTime.Now;
    }
}
