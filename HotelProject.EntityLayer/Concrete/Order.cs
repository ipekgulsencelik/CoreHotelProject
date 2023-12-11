using System.ComponentModel.DataAnnotations.Schema;

namespace HotelProject.EntityLayer.Concrete
{
	public class Order
	{
		public int OrderID { get; set; }
		public string OrderNumber { get; set; }
		public string RoomNumber { get; set; }
		public string? Description { get; set; }

		[Column(TypeName = "Date")]
		public DateTime OrderDate { get; set; }
		public decimal TotalPrice { get; set; }
		public EnumPaymentType PaymentType { get; set; }
		public EnumOrderState OrderState { get; set; }
		public bool Status { get; set; }

		public int PaymentID { get; set; }
		public Payment Payment { get; set; }

		public List<OrderDetail> OrderDetails { get; set; }
	}

	public enum EnumPaymentType
	{
		CreditCart = 0,
        Eft = 1
	}

	public enum EnumOrderState
	{
		waiting = 0,
		unpaid = 1,
		completed = 2
	}
}