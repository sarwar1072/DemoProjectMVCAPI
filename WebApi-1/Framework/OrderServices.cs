using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Framework
{
    public class OrderServices: IOrderServices
    {
        private readonly IOrderUnitofwork _unitofwork;
        public OrderServices(IOrderUnitofwork unitofwork)
        {
            _unitofwork = unitofwork; 
        }

        public void AddOrder(Order order)        
        {
            if (order == null) throw new ArgumentNullException("Order can not be null");

            _unitofwork.orderRepo.Add(order);
            _unitofwork.Save(); 
        }
    }
}
