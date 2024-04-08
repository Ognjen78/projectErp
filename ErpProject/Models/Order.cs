namespace ErpProject.Models
{
    public class Order
    {
        public int id { get; set; }
        public DateOnly orderDate { get; set; }
        public decimal itemsPrice { get; set; }
        public decimal shippingPrice { get; set; }
        public decimal totalPrice { get; set; }
        public Guid transactionId { get; set; }
        public DateTime transactionDate { get; set; }
        public decimal transactionAmount { get; set; }
        public string paymentStatus { get; set; }
        public Guid idUser { get; set; }
        public int idShipping { get; set; }

    }
}
