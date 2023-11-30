namespace HotelProject.EntityLayer.Concrete
{
	public class Gallery
    {
        public int GalleryID { get; set; }
		public string? ImageName { get; set; }
		public string? ImageURL { get; set; }
		public DateTime ImageDate { get; set; }
		public bool IsActive { get; set; }
	}
}