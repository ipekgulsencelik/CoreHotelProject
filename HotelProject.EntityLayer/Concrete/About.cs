namespace HotelProject.EntityLayer.Concrete
{
	public class About
    {
        public int AboutID { get; set; }
        public string? Title1 { get; set; }
        public string? Title2 { get; set; }
        public string? Description1 { get; set; }
        public string? Description2 { get; set; }
        public string? VideoURL { get; set; }
		public bool IsActive { get; set; }
	}
}