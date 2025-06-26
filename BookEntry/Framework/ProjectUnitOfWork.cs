using DevSkill.Data;
using Framework.RepogitoryFold;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Framework
{
    public class ProjectUnitOfWork:UnitOfWork, IProjectUnitOfWork
    {
        public IBookRepo bookRepo {  get;private set; }  
        public IWriterRepo writerRepo { get;private set; }
        public ProjectUnitOfWork(AppDbcontext dbcontext, IBookRepo bookRepog,IWriterRepo writerRepog) :base(dbcontext)
        {
                bookRepo = bookRepog;  
                writerRepo = writerRepog;   
                
        }
    }
}
