using AspNet.Models;
using AspNet.Models.Enums;

namespace AspNet.Data
{
    public class SeedingService
    {
        private AspNetContext _context;
        public SeedingService(AspNetContext context)
        {
            _context = context;
        }
        public void Seed()
        {
            if(_context.Department.Any()|| _context.Seller.Any() || _context.SalesRecord.Any())
            {
                return;
            }
            Department d1 = new Department(1,"Computers");
            Department d2 = new Department(2,"Electronics");
            Department d3 = new Department(3,"Fashion");
            Department d4 = new Department(4,"Books");

            Seller s1 = new Seller(1,"Bob","bob@gmail.com", new DateTime(1998,4,21),1000.0,d1);
            Seller s2 = new Seller(2,"Fred","fred@gmail.com", new DateTime(1998,4,21),1000.0,d2);
            Seller s3 = new Seller(3,"vi", "vi@gmail.com", new DateTime(1998,4,21),1000.0,d3);
            Seller s4 = new Seller(4,"nat", "nat@gmail.com", new DateTime(1998,4,21),1000.0,d4);

            SalesRecord r1 = new SalesRecord(1, new DateTime(2018,09,25),110000.0, SalesStatus.Canceled,s4);
            SalesRecord r2 = new SalesRecord(2, new DateTime(2018,09,25),110000.0, SalesStatus.Canceled,s2);
            SalesRecord r3 = new SalesRecord(3, new DateTime(2018,09,25),110000.0, SalesStatus.Canceled,s1);
            SalesRecord r4 = new SalesRecord(4, new DateTime(2018,09,25),110000.0, SalesStatus.Canceled,s3);

            _context.Department.AddRange(d1,d2,d3,d4);
            _context.Seller.AddRange(s1,s2,s3,s4);
            _context.SalesRecord.AddRange(r1,r2,r3,r4);
            _context.SaveChanges();
        }
    }
}
