using DevSkill.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Framework
{
    public class Order : IEntity<int>
    {
        public int Id { get; set; }
        public string? CustomerName { get; set; }
        public ICollection<OrderItem> Items { get; set; }   = new List<OrderItem>();    
        public DateTime DateTime { get; set; }
    }
}

