namespace HotelProject.EntityLayer.Concrete.Blogs
{
	public class BlogComment
	{
		public int BlogCommentID { get; set; }
		public string NameSurname { get; set; }
		public string Email { get; set; }
		public DateTime CommentDate { get; set; }
		public string Message { get; set; }

		public int BlogID { get; set; }
		public Blog Blog { get; set; }
	}
}
