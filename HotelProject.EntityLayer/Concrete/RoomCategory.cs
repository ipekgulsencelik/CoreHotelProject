namespace HotelProject.EntityLayer.Concrete
{
	public class RoomCategory
	{
		public int RoomCategoryID { get; set; }
		public string CategoryName { get; set; }
		public string CategoryDescription { get; set; }
		public string ImageURL { get; set; }
		public decimal Price { get; set; }
		public int PersonCount { get; set; }
		public string RoomSize { get; set; }
		public int BedCount { get; set; }
		public DateTime CategoryDate { get; set; }
		public bool IsActive { get; set; }

		public List<Room> Rooms { get; set; }
	}
}