namespace ErpProject.Models
{
    public class ShippingAddress
    {
        public int id { get; set; }
        public string country { get; set; }
        public string city { get; set; }
        public decimal shippingPrice { get; set; }
    }
}
