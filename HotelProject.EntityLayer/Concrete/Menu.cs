namespace HotelProject.EntityLayer.Concrete
{
	public class Menu
    {
        public int MenuID { get; set; }
        public string? Title { get; set; }
        public string? Description { get; set; }
		public decimal Price { get; set; }
		public string? ImageURL { get; set; }
		public bool IsActive { get; set; }
	}
}
