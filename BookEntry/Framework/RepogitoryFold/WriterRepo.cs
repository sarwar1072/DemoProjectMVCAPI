using DevSkill.Data;
using Framework.Entities;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Framework.RepogitoryFold
{
    public class WriterRepo:Repository<Writer,int>, IWriterRepo
    {
        public WriterRepo(AppDbcontext dbcontext):base(dbcontext)
        {
                
        }
    }
}
