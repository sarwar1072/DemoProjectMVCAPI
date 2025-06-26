using Framework.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Framework.ServicesFold
{
    public class WriterServices: IWriterServices
    {
        private  readonly IProjectUnitOfWork _unitOfWork;
        public WriterServices(IProjectUnitOfWork unitOfWork)
        {
                _unitOfWork = unitOfWork;
        }
        public void AddWriter(Writer writer)
        {
            if(writer == null)
            {
                throw new InvalidOperationException("Writer can not be null");
            }

            _unitOfWork.writerRepo.Add(writer);
            _unitOfWork.Save(); 
        }

    }
}
