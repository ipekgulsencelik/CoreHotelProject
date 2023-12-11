namespace HotelProject.EntityLayer.Concrete
{
	public class Payment
	{
		public int PaymentID { get; set; }
		public string CardName { get; set; }
		public string CardNumber { get; set; }
		public string ExpirationMonth { get; set; }
		public string ExpirationYear { get; set; }
		public string CVV { get; set; }
		public bool Status { get; set; }

        public List<Order> Orders { get; set; }
    }
}