namespace WebMVC_1.Models
{
    public class OrderDTO
    {
        public int  OrderNo { get; set; }
        public string? CustomerName { get; set; }
        public DateTime DateTime { get; set; }
        public ICollection<OrderItemDTO> ItemDTO { get; set; }=new List<OrderItemDTO>();    
    }
}
