namespace ApiSteam.Models
{
    public class Discount
    {
        public Guid IdDiscount { get; set; }
        public int PriceDiscount { get; set; }
        public long porcentageDiscount { get; set; }
        public DateTime StartDiscount {  get; set; }
        public DateTime EndDiscount { get; set; }


    }
}
