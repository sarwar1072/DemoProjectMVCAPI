using DevSkill.Data;
using Framework.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Framework.RepogitoryFold
{
    public class BookRepo:Repository<Book,int>, IBookRepo
    {
        public BookRepo(AppDbcontext dbcontext):base(dbcontext)
        {
                
        }
    }
}
