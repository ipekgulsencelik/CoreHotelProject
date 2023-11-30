namespace HotelProject.EntityLayer.Concrete
{
	public class Comment
    {
        public int CommentID { get; set; }
        public DateTime CommentDate { get; set; }
        public string CommentText { get; set; }
		public bool IsApproved { get; set; }
		public bool CommentStatus { get; set; }

		public int AppUserID { get; set; }
		public AppUser AppUser { get; set; }

		public int RoomID { get; set; }
		public Room Room { get; set; }
	}
}