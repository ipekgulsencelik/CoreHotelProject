namespace HotelProject.EntityLayer.Concrete.Blogs
{
	public class BlogContent
	{
		public int BlogContentID { get; set; }
		public string ContentValue { get; set; }
		public DateTime ContentDate { get; set; }
		public bool IsActive { get; set; }

		public int BlogID { get; set; }
		public Blog Blog { get; set; }
	}
}