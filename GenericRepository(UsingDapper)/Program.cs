using GenericRepository_UsingDapper_.Concrete;
using GenericRepository_UsingDapper_.Models;
using System.Data.SqlClient;

namespace GenericRepository_UsingDapper_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //İstenilen türün(tablo) ortak bir db menagment(repository) tarafından crud işlemlerine tabi tutulması.

            SqlConnection connection = new SqlConnection("Server=.;Database=Northwind;Trusted_Connection=True;");
            #region For Shippers Table

            #region Insert and GetAll
            Shipper shipper = new Shipper()
            {
                CompanyName = "Yurtiçi Kargo",
                Phone = "444 33 33"
            };
            Shippers shippers = new Shippers();
            Repository<Shipper, int> repofshipper = new Repository<Shipper, int>(connection);
            long fordeleteid = repofshipper.Insert(shipper);
            shippers.shippers.AddRange(repofshipper.GetAll());
            foreach (Shipper item in shippers.shippers)
            {
                Console.WriteLine(item.ID + " " + item.CompanyName + " " + item.Phone);
            }
            #endregion

            #region Delete and GetAll
            Shipper shipper1 = new Shipper()
            {
                ID = int.Parse(fordeleteid.ToString()),
                CompanyName = shipper.CompanyName,
                Phone = shipper.Phone
            };
            repofshipper.Delete(shipper1);
            shippers.shippers = new List<Shipper>();
            shippers.shippers.AddRange(repofshipper.GetAll());
            foreach (Shipper item in shippers.shippers)
            {
                Console.WriteLine(item.ID + " " + item.CompanyName + " " + item.Phone);
            }
            #endregion

            #endregion

            #region For Products Table

            #region Insert and GetAll
            Product product = new Product()
            {
                CategoryID = 1,
                Discontinued = 2,
                ProductName = "banana",
                QuantityPerUnit = "3",
                ReorderLevel = 4,
                UnitsInStock = 5,
                SupplierID = 1,
                UnitPrice = 10,
                UnitsOnOrder = 1
            };
            Products products = new Products();
            Repository<Product, string> repofproduct = new Repository<Product, string>(connection);
            long fordeleteid2 = repofproduct.Insert(product);
            products.products.AddRange(repofproduct.GetAll());
            foreach (Product item in products.products)
            {
                Console.WriteLine(item.ID + " " + item.ProductName + " " + item.SupplierID);
            }
            #endregion

            #region Delete and GetAll
            Product product1 = new Product()
            {
                ID = (fordeleteid2.ToString()),
                CategoryID = product.CategoryID,
                Discontinued = product.Discontinued,
                ProductName = product.ProductName,
                QuantityPerUnit = product.QuantityPerUnit,
                ReorderLevel = product.ReorderLevel,
                UnitsInStock = product.UnitsInStock,
                SupplierID = product.SupplierID,
                UnitPrice = product.UnitPrice,
                UnitsOnOrder = product.UnitsInStock
            };
            repofproduct.Delete(product1);
            products.products = new List<Product>();//liste temizleme islemi yapildi.
            products.products.AddRange(repofproduct.GetAll());
            foreach (Product item in products.products)
            {
                Console.WriteLine(item.ID + " " + item.ProductName + " " + item.SupplierID);
            }
            #endregion

            #endregion

        }
    }
}
