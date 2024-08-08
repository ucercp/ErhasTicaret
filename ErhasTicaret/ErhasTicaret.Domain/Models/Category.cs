namespace ErhasTicaret.Domain.Models
{
    public class Category
    {
        public string CategoryId { get; set; }
        public string Name { get; set; }
        public ICollection<Product> Products { get; set; }
    }
}
