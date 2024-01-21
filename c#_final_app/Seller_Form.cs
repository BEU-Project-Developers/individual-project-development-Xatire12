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

namespace c__final_app
{
    public partial class Seller_Form : Form
    {
        public Seller_Form()
        {
            InitializeComponent();
        }
        SqlConnection Con=new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\User\source\repos\c#_final_app\c#_final_app\Final.mdf;Integrated Security=True");

        private void guna2ImageButton2_Click(object sender, EventArgs e)
        {

        }

        private void guna2ImageButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            Selling_Form selling_Form = new Selling_Form();
            selling_Form.Show();
            this.Hide();
        }

        private void Seller_form_products_Click(object sender, EventArgs e)
        {
            //seller formundan product a click etdikde Product formuna kecmek ucun
            Product_Form product_Form = new Product_Form();
            product_Form.Show();
            this.Hide();
        }

        private void Selling_Form_category_Click(object sender, EventArgs e)
        {
            //seller formundan category e click etdikde Category formuna kecmek ucun
            Category_Form category_Form = new Category_Form();
            category_Form.Show();
            this.Hide();
        }

        private void Selling_form_logout_Click(object sender, EventArgs e)
        {
        //seller formundan logout verdikde baslangic login sehifesine kecmek ucun
           Login login = new Login();
            login.Show();
            this.Hide();
        }

        private void sellerDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {   //DGV dan select edende index of out erroru veresin deye bunu yaziriq
            if (e.RowIndex >= 0 && e.RowIndex < sellerDGV.Rows.Count)
            {
                selleridtxt.Text = sellerDGV.Rows[e.RowIndex].Cells[0].Value.ToString();
                sellernametxt.Text = sellerDGV.Rows[e.RowIndex].Cells[1].Value.ToString();
                selleragetxt.Text = sellerDGV.Rows[e.RowIndex].Cells[2].Value.ToString();
                sellermobiletxt.Text = sellerDGV.Rows[e.RowIndex].Cells[3].Value.ToString();
                sellerpasswordtxt.Text = sellerDGV.Rows[e.RowIndex].Cells[4].Value.ToString();
            }
        }

        //Add button
        private void selleradd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(selleridtxt.Text) || string.IsNullOrWhiteSpace(sellernametxt.Text) || string.IsNullOrWhiteSpace(sellerpasswordtxt.Text))
            {
                MessageBox.Show("Seller ID, Name, and Password are required.");
            }
            else
            {
                // Check if selleridtxt is a valid integer
                if (!int.TryParse(selleridtxt.Text, out int sellerId) || sellerId <= 0)
                {
                    MessageBox.Show("Please enter a valid positive integer for Seller ID.");
                }
                // Check if sellernametxt has at least 2 characters
                else if (sellernametxt.Text.Length < 2)
                {
                    MessageBox.Show("Seller name should have at least 2 characters.");
                }
                // Password validation
                else if (sellerpasswordtxt.Text.Length < 6)
                {
                    MessageBox.Show("Password should have at least 6 characters.");
                }
                else if (!sellerpasswordtxt.Text.Any(char.IsLetter))
                {
                    MessageBox.Show("Password should contain at least one letter.");
                }
                else if (!sellerpasswordtxt.Text.Any(char.IsDigit))
                {
                    MessageBox.Show("Password should contain at least one digit.");
                }
                else
                {
                    try
                    {
                        Con.Open();
                        string query = "INSERT INTO SellersTbl VALUES (" + sellerId + ", '" + sellernametxt.Text + "', '" + selleragetxt.Text + "','" + sellermobiletxt.Text + "','" + sellerpasswordtxt.Text + "')";
                        SqlCommand cmd = new SqlCommand(query, Con);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Seller Added Successfully!");
                        Con.Close();
                        populate();
                        selleridtxt.Text = "";
                        sellernametxt.Text = "";
                        selleragetxt.Text = "";
                        sellermobiletxt.Text = "";
                        sellerpasswordtxt.Text = "";
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }


        }

        private void sellerupdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (selleridtxt.Text == "" || sellernametxt.Text == "" || selleragetxt.Text == "" || sellermobiletxt.Text == ""||sellerpasswordtxt.Text=="")
                {
                    MessageBox.Show("Missing Information");
                }
                else
                {
                    Con.Open();
                    string query = "update SellersTbl set SellerName=' " + sellernametxt.Text + " ',SellerAge=' " + selleragetxt.Text + "',SellerMobileNo=' " + sellermobiletxt.Text + " ',SellerPassword='" + sellerpasswordtxt.Text + " ',SellerPassword='" + sellerpasswordtxt.Text + "";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Seller has been update Succesfully");
                    Con.Close();
                    populate();
                    selleridtxt.Text = "";
                    sellernametxt.Text = "";
                    selleragetxt.Text = "";
                    sellermobiletxt.Text = "";
                    sellerpasswordtxt.Text = "";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void sellerdelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (selleridtxt.Text == "")
                {
                    MessageBox.Show("Select Seller ID to Delete");
                }
                else
                {
                    Con.Open();
                    string query = "delete from SellersTbl where SellerId=" + selleridtxt.Text + "";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Sellers has been deleted Succesfully");
                    Con.Close();
                    populate();
                    selleridtxt.Text = "";
                    sellernametxt.Text = "";
                    selleragetxt.Text = "";
                    sellermobiletxt.Text = "";
                    sellerpasswordtxt.Text = "";

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void populate()
        {
            Con.Open();
            string query = "select * from SellersTbl";
            SqlDataAdapter sda = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            sellerDGV.DataSource = ds.Tables[0];
            Con.Close();
        }

        private void Seller_Form_Load(object sender, EventArgs e)
        {
            populate();
        }

        private void sellerreset_Click(object sender, EventArgs e)
        {
            selleridtxt.Text = "";
            sellernametxt.Text = "";
            sellermobiletxt.Text = "";
            sellerpasswordtxt.Text = "";
            selleragetxt.Text = "";
        }

        private void guna2Button7_Click(object sender, EventArgs e)//customers sehifesine kecmek ucun
        {
            Customers customers = new Customers();
            this.Hide();
            customers.Show();
        }
    }
}
