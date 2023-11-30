namespace HotelProject.EntityLayer.Concrete
{
	public class RoomStatus
	{
		public int RoomStatusID { get; set; }
		public string RoomNumber { get; set; }
		public bool Status { get; set; }
		//public List<Room> Rooms { get; set; }
		public List<Basket> Baskets { get; set; }
	}
}