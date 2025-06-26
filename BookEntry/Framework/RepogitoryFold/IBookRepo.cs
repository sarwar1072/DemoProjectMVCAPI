using DevSkill.Data;
using Framework.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Framework.RepogitoryFold
{
    public interface IBookRepo:IRepository<Book,int>
    {
    }
}
