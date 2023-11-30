namespace HotelProject.EntityLayer.Concrete
{
	public class Testimonial
    {
        public int TestimonialID { get; set; }
        public string? NameSurname { get; set; }
		public string? Title { get; set; }
		public string? Comment { get; set; }
        public DateTime TestimonialDate { get; set; }
        public string? ImageURL { get; set; }
        public bool IsActive { get; set; }
    }
}