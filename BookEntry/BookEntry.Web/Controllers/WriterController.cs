using BookEntry.Web.Models;
using Framework.Entities;
using Framework.ServicesFold;
using Microsoft.AspNetCore.Mvc;

namespace BookEntry.Web.Controllers
{
    public class WriterController : Controller
    {
        IFileHelper _fileHelper;
        private readonly IWriterServices _writerServices ;
        public WriterController(IFileHelper fileHelper, IWriterServices writerServices)
        {
            _fileHelper = fileHelper;
            _writerServices = writerServices;
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult AddWriter()
        {
            var model = new WriterModel();
            return View(model);

        }
        [HttpPost]
        public IActionResult AddWriter(WriterModel model)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    // tour.TourUrl = _fileHelper.UploadFile(tour.CoverPhotoUrl);
                    model.WritterphotoURL = _fileHelper.UploadFile(model.CoverPhotoUrl);
                    var data = new Writer
                    {
                        WritterName = model.WritterName,
                        MobileNumber = model.MobileNumber,
                        WritterphotoURL = model.WritterphotoURL,
                    };
                    _writerServices.AddWriter(data);    
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
