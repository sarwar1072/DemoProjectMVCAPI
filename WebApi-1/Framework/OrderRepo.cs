using DevSkill.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Framework
{
    public class OrderRepo:Repository<Order,int>, IOrderRepo    
    {
        public OrderRepo(AppDbcontext dbcontext):base(dbcontext)
        {
                
        }
    }
}
