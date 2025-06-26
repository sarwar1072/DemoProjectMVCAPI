using BookEntry.Web.Models;
using Framework.Entities;
using Framework.ServicesFold;
using Microsoft.AspNetCore.Mvc;

namespace BookEntry.Web.Controllers
{
    public class BookController : Controller
    {
        IFileHelper _fileHelper;
        private readonly IBookServices _bookServices;
        public BookController(IFileHelper fileHelper, IBookServices bookServices)
        {
                _fileHelper = fileHelper;
            _bookServices = bookServices;
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult AddBook()
        {
            var model = new BookModel();
            return View(model); 

        }
        [HttpPost]
        public IActionResult AddBook(BookModel model)
        {
            if (ModelState.IsValid)
            {
                try
                {
                   // tour.TourUrl = _fileHelper.UploadFile(tour.CoverPhotoUrl);
                    model.BookCoverImageURL= _fileHelper.UploadFile(model.CoverPhotoUrl);
                    var data = new Book
                    {
                        BookTitle = model.BookTitle,
                        PublishDate = model.PublishDate,
                        Price = model.Price,
                        BookCoverImageURL = model.BookCoverImageURL,
                    };
                    _bookServices.AddBook(data);              
                }
                catch (Exception ex)
                {
                   // _logger.LogError($"{ex.Message}");
                }
            }
            return View(model);
        }

    }
}
