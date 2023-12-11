namespace HotelProject.EntityLayer.Concrete.Blogs
{
	public class BlogCategory
	{
		public int BlogCategoryID { get; set; }
		public string CategoryName { get; set; }
		public string CategoryDescription { get; set; }
		public DateTime CategoryDate { get; set; }
		public bool IsActive { get; set; }

		public List<Blog> Blogs { get; set; }
	}
}