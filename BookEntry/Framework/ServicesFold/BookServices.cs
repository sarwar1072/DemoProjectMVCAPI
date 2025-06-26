using Framework.Entities;
using Microsoft.AspNetCore.Mvc.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Framework.ServicesFold
{
    public class BookServices: IBookServices
    {
        private readonly IProjectUnitOfWork _projectUnitOfWork;
        public BookServices(IProjectUnitOfWork projectUnitOfWork)
        {
                _projectUnitOfWork = projectUnitOfWork;
        }

        public void AddBook(Book book)
        {
            if(book == null) 
            {
                throw new InvalidOperationException("Book can not be null");
            }

            _projectUnitOfWork.bookRepo.Add(book);
            _projectUnitOfWork.Save();  
        }

       
    }
}
