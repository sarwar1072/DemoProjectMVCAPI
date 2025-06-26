using Framework;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApi_1.Models;

namespace WebApi_1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderController : ControllerBase
    {
        private readonly IOrderServices _orderServices;
        public OrderController(IOrderServices orderServices)
        {
                _orderServices = orderServices;
        }

        [HttpPost("Create")]
        public IActionResult AddOrder(OrderDTO orderDTO) 
        {
            try
            {
                var model = new List<OrderItem>();
                foreach (var item in orderDTO.ItemDTO)
                {
                    model.Add(new OrderItem
                    {
                        Item = item.Item,
                        Quantity = item.Quantity,
                    });
                }

                var model2 = new Order
                {
                    CustomerName = orderDTO.CustomerName,
                    Items = model,
                    DateTime = orderDTO.DateTime,
                };
                _orderServices.AddOrder(model2);
                return Ok("Success");
            }  
            catch (Exception ex)
            {
                return BadRequest(ex);  
            }
        }
    }
}
