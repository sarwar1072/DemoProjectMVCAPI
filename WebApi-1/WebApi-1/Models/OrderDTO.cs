namespace WebApi_1.Models
{
    public class OrderDTO
    {
        public string? CustomerName {  get; set; }
        public DateTime DateTime { get; set; }
        public ICollection<OrderItemDTO> ItemDTO { get; set; }
    }
}

