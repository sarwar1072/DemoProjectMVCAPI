using DevSkill.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Framework
{
    public class OrderUnitofwork:UnitOfWork, IOrderUnitofwork
    {
        public IOrderRepo orderRepo {  get; private set; }  
        public OrderUnitofwork(AppDbcontext dbcontext,IOrderRepo order):base(dbcontext)
        {
                orderRepo= order;   
        }
    }
}
