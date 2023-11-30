namespace HotelProject.EntityLayer.Concrete
{
	public class Reservation
	{
		public int ReservationID { get; set; }
		public int AdultCount { get; set; }
		public int ChildCount { get; set; }
		public DateTime CheckInDate { get; set; }
		public DateTime CheckOutDate { get; set; }
	}
}
