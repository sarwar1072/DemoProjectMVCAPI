using DevSkill.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Framework.Entities
{
    public class BookWritter:IEntity<int>
    {
        public int Id { get; set; }
        public int BookId { get; set; }
        public Book? Book { get; set; }
        public int WriterId { get; set; }
        public Writer? Writer { get; set; }
    }
}
