namespace ErhasTicaret.Domain.Models
{
    public class BasketItem
    {
        public string BasketItemId { get; set; }
        public string ProductId { get; set; }
        public Product Product { get; set; }
        public string Quantity { get; set; }
        public string UserId { get; set; }
        public User User { get; set; }
    }
}
