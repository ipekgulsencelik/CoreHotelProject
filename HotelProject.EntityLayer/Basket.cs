using HotelProject.EntityLayer.Concrete;

namespace HotelProject.EntityLayer
{
	public class Basket
	{
		public int BasketID { get; set; }
		public decimal Price { get; set; }
		public decimal Count { get; set; }
		public decimal TotalPrice { get; set; }

		public int RoomID { get; set; }
		public Room Room{ get; set; }

		public int RoomStatusID { get; set; }
		public RoomStatus RoomStatus { get; set; }
	}
}