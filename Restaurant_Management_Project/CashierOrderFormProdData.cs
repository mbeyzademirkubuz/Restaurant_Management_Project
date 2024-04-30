using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant_Management_Project
{
    internal class CashierOrderFormProdData
    {


        public int ID { set; get; }

        public string Sipariş_Adı { set; get; }

        public string Masa { set; get; }

        public string Sipariş_Durumu { set; get; }

        public int Kişi_Sayısı { set; get; }

        public int Toplam_Tutar { set; get; }

        public string Sipariş_Tarihi { set; get; }


        SqlConnection connect = new SqlConnection(@"Data Source=magnolia;Initial Catalog=Restaurant_Management;Integrated Security=True;Encrypt=False");


        public List<CashierOrderFormProdData> availableProductsData()
        {
            List<CashierOrderFormProdData> listData = new List<CashierOrderFormProdData>();

            if (connect.State == ConnectionState.Closed)
            {
                try
                {
                    connect.Open();

                    string selectData = "SELECT * FROM orders WHERE order_situation = @stats";

                    using (SqlCommand cmd = new SqlCommand(selectData, connect))
                    {
                        cmd.Parameters.AddWithValue("@stats", "Aktif");

                        SqlDataReader reader = cmd.ExecuteReader();

                        while (reader.Read())
                        {
                            CashierOrderFormProdData apd = new CashierOrderFormProdData();

                            apd.ID = (int)reader["order_id"];
                            apd.Sipariş_Adı = reader["order_name"].ToString();
                            apd.Masa = reader["order_table"].ToString();
                            apd.Sipariş_Durumu = reader["order_situation"].ToString();
                            apd.Kişi_Sayısı = (int)reader["order_people"];
                            apd.Toplam_Tutar = (int)reader["total_cost"];
                            apd.Sipariş_Tarihi = reader["order_date"].ToString();

                            listData.Add(apd);
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Failed Connection: " + ex);
                }
                finally
                {
                    connect.Close();
                }
            }
            return listData;
        }
    }
}
