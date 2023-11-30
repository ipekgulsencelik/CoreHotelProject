namespace HotelProject.EntityLayer.Concrete
{
	public class Booking
	{
		public int BookingID { get; set; }
		public DateTime BookingDate { get; set; }
		public string? Description { get; set; }
		public bool IsActive { get; set; }

		public int ReservationID { get; set; }
		public Reservation Reservation { get; set; }

		public int AppUserID { get; set; }
		public AppUser AppUser { get; set; }

		public int RoomID { get; set; }
		public Room Room { get; set; }
	}
}