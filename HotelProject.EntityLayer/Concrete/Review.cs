namespace HotelProject.EntityLayer.Concrete
{
	public class Review
    {
        public int ReviewID { get; set; }
        public string? ReviewScore { get; set; }

		public int RoomID { get; set; }
		public Room Room { get; set; }

		public int AppUserID { get; set; }
		public AppUser AppUser { get; set; }
	}
}