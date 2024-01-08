using AspNet.Models.Enums;

namespace AspNet.Models
{
    public class SalesRecord
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public double Amout { get; set; }
        public SalesStatus Status { get; set; }
        public Seller Seller { get; set; }
        public SalesRecord()
        {
        }
        public SalesRecord(int id, DateTime date, double amout, SalesStatus status, Seller seller)
        {
            Id = id;
            Date = date;
            Amout = amout;
            Status = status;
            Seller = seller;
        }
        
    }
}
