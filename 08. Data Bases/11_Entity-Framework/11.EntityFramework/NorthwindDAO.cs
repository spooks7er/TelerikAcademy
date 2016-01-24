namespace EntityFrameworkHw
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class NorthwindDAO
    {
        public List<string> CustomersWithOrdersIn1997ToCanada()
        {
            using (var db = new NorthwindEntities())
            {
                var data = db.Orders
                    .Where(o => o.OrderDate.Value.Year == 1997)
                    .Where(o => o.ShipCountry == "Canada")
                    .Select(c => c.CustomerID)
                    .Distinct()
                    .ToList();
                //Console.WriteLine(data);
                return data;
            }
        }

        public List<string> CustomersWithOrdersIn1997ToCanadaNativeQuery()
        {
            using (var db = new NorthwindEntities())
            {
                var query = @"SELECT DISTINCT CustomerID
                                FROM Orders
                                WHERE year(OrderDate) = 1997
	                                AND ShipCountry = 'Canada'";
                var data = db.Database.SqlQuery<string>(query)
                    .ToList();
                //Console.WriteLine(data);
                return data;
            }
        }

        public bool CreateDatabase()
        {
            using (var db = new NorthwindEntities())
            {
                return db.Database.CreateIfNotExists();
            }
        }

        public void AddCustomer(Customer customer)
        {
            using (var db = new NorthwindEntities())
            {
                db.Customers.Add(customer);
                db.SaveChanges();
            }
        }

        public void RemoveCustomer(Customer customer)
        {
            using (var db = new NorthwindEntities())
            {
                string command = string.Format("DELETE FROM Customers WHERE CustomerID = '{0}'", customer.CustomerID);
                db.Database.ExecuteSqlCommand(command);
                db.SaveChanges();
            }
        }
    }
}