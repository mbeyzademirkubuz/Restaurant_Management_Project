using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient; 

namespace Restaurant_Management_Project
{
    public partial class formOrder : UserControl
    {

        SqlConnection connect = new SqlConnection(@"Data Source=magnolia;Initial Catalog=Restaurant_Management;Integrated Security=True;Encrypt=False");


        public formOrder()
        {
            InitializeComponent();

            displayAvailableProds();


        }



        public void displayAvailableProds()
        {
            CashierOrderFormProdData allProds = new CashierOrderFormProdData();

            List<CashierOrderFormProdData> listData = allProds.availableProductsData();

            datagridviewShowActiveOrder.DataSource = listData;
        }


        private void buttonExit_Click(object sender, EventArgs e)
        {
            DialogResult res;
            res = MessageBox.Show("Çıkış yapmak istiyor musunuz?", "Çıkış", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (res == DialogResult.Yes)
            {
                // Uygulamayı kapat
                Application.Exit();
            }
            else
            {
                this.Show();
            }
        }

        private void buttonOrderManagement_Click(object sender, EventArgs e)
        {
            formManageOrder manageOrderForm = new formManageOrder();
            manageOrderForm.Show();
            this.Hide();
        }

        private void buttonAddActiveOrder_Click(object sender, EventArgs e)
        {

        }

        private void listboxOrderDetail_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboboxActiveOrderFoodID.SelectedIndex = -1;
            comboboxActiveOrderFoodID.Items.Clear();
            labelActiveFoodName.Text = "";
            labelActiveOrderPrice.Text = "";



            string selectedValue = listboxOrderDetail.SelectedItem as string;

            if (selectedValue != null)
            {
                try
                {
                    using (SqlConnection connect = new SqlConnection(@"Data Source=magnolia;Initial Catalog=Restaurant_Management;Integrated Security=True;Encrypt=False"))
                    {
                        connect.Open();
                        string selectData = $"SELECT * FROM food WHERE food_type = '{selectedValue}' AND food_status = @status";

                        using (SqlCommand cmd = new SqlCommand(selectData, connect))
                        {
                            cmd.Parameters.AddWithValue("@status", "Available");

                            using (SqlDataReader reader = cmd.ExecuteReader())
                            {
                                while (reader.Read())
                                {
                                    string value = reader["food_id"].ToString();

                                    comboboxActiveOrderFoodID.Items.Add(value);
                                }
                            }
                        }
                    }
                }
                catch (Exception exx)
                {
                    MessageBox.Show("Error: " + exx, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void comboboxActiveOrderFoodID_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedValue = comboboxActiveOrderFoodID.SelectedItem as string;

            if (selectedValue != null)
            {
                try
                {
                    using (SqlConnection connect = new SqlConnection(@"Data Source=magnolia;Initial Catalog=Restaurant_Management;Integrated Security=True;Encrypt=False"))
                    {
                        connect.Open();
                        string selectData = $"SELECT * FROM food WHERE food_id = '{selectedValue}' AND food_status = @status";

                        using (SqlCommand cmd = new SqlCommand(selectData, connect))
                        {
                            cmd.Parameters.AddWithValue("@status", "Available");

                            using (SqlDataReader reader = cmd.ExecuteReader())
                            {
                                while (reader.Read())
                                {
                                    string prodName = reader["food_name"].ToString();
                                    string prodPrice = reader["food_price"].ToString();

                                    labelActiveFoodName.Text = prodName;
                                    labelActiveOrderPrice.Text = prodPrice;

                                }
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }
    }
}
