using DevSkill.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Framework.Entities
{
    public   class Book:IEntity<int>
    {
        public int Id { get; set; }
        public string? BookTitle { get; set; }
        public DateTime PublishDate { get; set; }
        public Double Price { get; set; }
        public string? BookCoverImageURL { get; set; }
        public ICollection<Writer> Writers { get; set; }=new List<Writer>();    
    }
}
