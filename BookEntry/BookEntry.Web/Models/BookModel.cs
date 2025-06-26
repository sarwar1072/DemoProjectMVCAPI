namespace BookEntry.Web.Models
{
    public class BookModel
    {
        //public int Id { get; set; }
        public string? BookTitle { get; set; }
        public DateTime PublishDate { get; set; }
        public Double Price { get; set; }
        public IFormFile CoverPhotoUrl { get; set; }

        public string? BookCoverImageURL { get; set; }
    }
}
