using System.Text.Json.Serialization;

namespace HotelProject.EntityLayer.Concrete
{
	public class Room
    {
        public int RoomID { get; set; }
		public string RoomNumber { get; set; }
		public string RoomView {  get; set; }
		public bool IsActive { get; set; }

		public int RoomCategoryID { get; set; }
		[JsonIgnore]
		public RoomCategory RoomCategory { get; set; }

		//public int RoomStatusID { get; set; }
		//[JsonIgnore]
		//public RoomStatus RoomStatus { get; set; }

		public List<RoomDetail> RoomDetails { get; set; }
		public List<Review> Reviews { get; set; }
		public List<Comment> Comments { get; set; }
		public List<OrderDetail> OrderDetails { get; set; }
		public List<Basket> Baskets { get; set; }
		public List<Booking> Bookings { get; set; }
	}
}