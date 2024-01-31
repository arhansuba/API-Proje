namespace API_Proje.Models
{
    public class ProductionOrder
    {
        public int Id { get; set; }
        public string ProductionStockNo { get; set; }
        public string OrderNo { get; set; }
        public DateTime CreateDate { get; set; }
    }
}
