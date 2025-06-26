using DevSkill.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Framework.Entities
{
    public class Writer:IEntity<int>
    {
        public int Id { get; set; }
        public string? WritterName { get; set; }
        public string? MobileNumber { get; set; }
        public string? WritterphotoURL { get; set; }
        public ICollection<Book> Books { get; set; }=new List<Book>();

    }
}
