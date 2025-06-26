namespace BookEntry.Web.Models
{
    public class WriterModel
    {
        //public int Id { get; set; }
        public string? WritterName { get; set; }
        public string? MobileNumber { get; set; }
        public string? WritterphotoURL { get; set; }
        public IFormFile CoverPhotoUrl { get; set; }

    }
}
