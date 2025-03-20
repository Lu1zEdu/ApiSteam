namespace ApiSteam.Models
{
    public class DLC
    {
        public Guid IdDLC { get; set; }
        public string Name { get; set; }
        public int PriceDLC { get; set; }
        public Discount discount { get; set; }
        public string Description { get; set; }
    }
}
