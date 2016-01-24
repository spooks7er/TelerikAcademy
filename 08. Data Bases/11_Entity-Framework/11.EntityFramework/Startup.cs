namespace EntityFrameworkHw
{
    using System;
    using System.Linq;

    public class Startup
    {
        public static void Main()
        {
            var nwDao = new NorthwindDAO();

            var data1 = nwDao.CustomersWithOrdersIn1997ToCanada();
            data1.ForEach(Console.WriteLine);

            var data2 = nwDao.CustomersWithOrdersIn1997ToCanadaNativeQuery();
            data2.ForEach(Console.WriteLine);

            nwDao.CreateDatabase();

            Customer cust = new Customer();

            cust.CustomerID = "65465";
            cust.CompanyName = "TEST";
            cust.ContactName = "TEST";
            cust.ContactTitle = "TEST";
            cust.Address = "TEST";
            cust.City = "TEST";
            cust.PostalCode = "TEST";
            cust.Country = "TEST";
            cust.Phone = "TEST";
            cust.Fax = "TEST";

            nwDao.AddCustomer(cust);

            //nwDao.RemoveCustomer(cust);

            var ctx1 = new NorthwindEntities();
            var empCtx1 = ctx1.Employees.FirstOrDefault();
            empCtx1.FirstName = "from CTX1";

            var ctx2 = new NorthwindEntities();
            var empCtx2 = ctx2.Employees.FirstOrDefault();
            empCtx2.FirstName = "from CTX2";


            ctx1.SaveChanges();
            ctx2.SaveChanges();
            // the last change is saved

            ctx1.Dispose();
            ctx2.Dispose();
        }
    }
}
