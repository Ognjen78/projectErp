namespace ErpProject.Models
{
    public class OrderItem
    {
        public int id { get; set; }
        public int idOrder { get; set; }
        public int idProduct { get; set; }
        public int quantity { get; set; }
        public decimal price { get; set; }

    }
}
