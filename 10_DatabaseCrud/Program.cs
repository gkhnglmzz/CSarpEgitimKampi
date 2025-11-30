using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_DatabaseCrud
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Crud-->Create--Read--Update--Delete

            Console.WriteLine("*****Menü sipariş işlem Paneli******");

            Console.WriteLine();
          


            Console.WriteLine("-------------------------");

            #region Kategori ekleme İşlemi

            //Console.Write("Eklemek İstediğiniz Kategori Adı: ");
            //string categoryName = Console.ReadLine();


            //SqlConnection connection = new SqlConnection("Data Source=GÖKHAN;initial catalog=EğitimKampiDb;integrated security=true");
            //connection.Open();
            //SqlCommand command = new SqlCommand("insert into TblCategory(CategoryName) values (@p1)", connection);
            //command.Parameters.AddWithValue("@p1", categoryName);
            //command.ExecuteNonQuery();
            //connection.Close();

            //Console.Write("Kategori başarıyla eklendi!");

            #endregion

            #region Ürün ekleme işlemi

            //string productName;
            //decimal productPrice;
            ////bool productStatus;

            //Console.Write("Eklemek istediğiniz ürün :");
            //productName=Console.ReadLine();
            //Console.Write("Ürün Fiyatı:");
            //productPrice=decimal.Parse(Console.ReadLine());

            //SqlConnection connection = new SqlConnection("Data source=GÖKHAN;initial catalog=EğitimKampiDb;integrated security=true");
            //connection.Open();
            //SqlCommand command = new SqlCommand("insert into TblProduct(ProductName,ProductPrice,ProductStatus) values (@productName,@ProductPrice,@ProductStatus)",connection);
            //command.Parameters.AddWithValue("@productName", productName);
            //command.Parameters.AddWithValue("@productPrice", productPrice);
            //command.Parameters.AddWithValue("@productStatus", true);
            //command.ExecuteNonQuery();
            //connection.Close();
            //Console.Write("ürün ekleme başarılı!");

            #endregion

            #region Ürün listeleme İşlemi

            //SqlConnection connection = new SqlConnection("Data source=GÖKHAN;initial Catalog=EğitimKampiDb;integrated security=true");

            //connection.Open();
            //SqlCommand command= new SqlCommand("Select * From TblProduct", connection);
            //SqlDataAdapter adapter = new SqlDataAdapter(command);
            //DataTable dataTable = new DataTable();
            //adapter.Fill(dataTable);

            //foreach(DataRow row in dataTable.Rows)
            //{
            //    foreach(var item in row.ItemArray)
            //    {
            //        Console.Write(item.ToString() + " ");
            //    }
            //    Console.WriteLine();
            //}
            //connection.Close();


            #endregion

            #region Ürün silme işlemi

            //Console.Write("Silinecek ürün Id: ");
            //int productId =int.Parse(Console.ReadLine());

            //SqlConnection connection = new SqlConnection("Data source=GÖKHAN;initial Catalog=EğitimKampiDb;integrated security=true");

            //connection.Open();

            //SqlCommand command = new SqlCommand("Delete From TblProduct Where ProductId=@productId", connection);
            //command.Parameters.AddWithValue("@productId", productId);
            //command.ExecuteNonQuery();

            //connection.Close();

            //Console.WriteLine("Silme işlemi yapıldı! ");

            #endregion

            #region Ürün güncelleme İşlemi

            //Console.Write("Güncellenecek Ürün Id: ");
            //int productId=int.Parse(Console.ReadLine());

            //Console.Write("Güncellenecek Ürün Adı: ");
            //string productName = Console.ReadLine();

            //Console.Write("Güncellenecek Ürün Fiyatı: ");
            //decimal productPrice = decimal.Parse(Console.ReadLine());

           

            //SqlConnection connection = new SqlConnection("Data source=GÖKHAN;initial Catalog=EğitimKampiDb;integrated security=true");
            //connection.Open();

            //SqlCommand command = new SqlCommand("Update TblProduct Set ProductName=@productName, ProductPrice=@productPrice where ProductId=@productId " , connection);
            //command.Parameters.AddWithValue("@productName", productName);
            //command.Parameters.AddWithValue("@productPrice", productPrice);
            //command.Parameters.AddWithValue("@productId", productId);
            //command.ExecuteNonQuery();

            //connection.Close();

            //Console.WriteLine("Güncelleme Başarılı! ");


            #endregion




            Console.Read();
          

        }
    }
}
