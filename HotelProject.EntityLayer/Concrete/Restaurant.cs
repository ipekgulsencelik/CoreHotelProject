namespace HotelProject.EntityLayer.Concrete
{
	public class Restaurant
    {
        public int RestaurantID { get; set; }
        public string? Title1 { get; set; }
        public string? Title2 { get; set; }
        public string? Description1 { get; set; }
        public string? Description2 { get; set; }
        public string? Description3 { get; set; }
        public string? ImageURL { get; set; }
        public bool IsActive { get; set; }
    }
}