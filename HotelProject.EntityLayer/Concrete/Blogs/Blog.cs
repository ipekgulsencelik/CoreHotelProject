namespace HotelProject.EntityLayer.Concrete.Blogs
{
	public class Blog
    {
        public int BlogID { get; set; }
        public string Title { get; set; }
        public string ImageURL { get; set; }
        public DateTime BlogDate { get; set; }
		public bool IsHome { get; set; }
		public bool IsActive { get; set; }

		public int AppUserID { get; set; }
		public AppUser AppUser { get; set; }

		public int BlogCategoryID { get; set; }
		public BlogCategory BlogCategory { get; set; }

		public List<TagCloud> TagClouds { get; set; }
		public List<BlogComment> BlogComments { get; set; }
		public List<BlogContent> BlogContents { get; set; }
	}
}