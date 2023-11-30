namespace HotelProject.EntityLayer.Concrete
{
	public class RoomDetail
    {
        public int RoomDetailID { get; set; }
        public string? ImageURL1 { get; set; }
        public string? ImageURL2 { get; set; }
        public string? ImageURL3 { get; set; }
        public string? Title { get; set; }
        public string? Description1 { get; set; }
        public string? Description2 { get; set; }
        public string? VideoURL { get; set; }

		public int RoomID { get; set; }
		public Room Room { get; set; }
	}
}