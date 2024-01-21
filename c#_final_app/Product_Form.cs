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
    public partial class Product_Form : Form
    {
        public Product_Form()
        {
            InitializeComponent();
        }
        SqlConnection Con=new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\User\source\repos\c#_final_app\c#_final_app\Final.mdf;Integrated Security=True");
        private void guna2ImageButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            Seller_Form seller= new Seller_Form();
            seller.Show();
            this.Hide();
        }

        private void guna2Button5_Click(object sender, EventArgs e)
        {
            Category_Form category_Form = new Category_Form();
            category_Form.Show();
            this.Hide();
        }

        private void guna2Button6_Click(object sender, EventArgs e)
        {
            Selling_Form seller= new Selling_Form();
            seller.Show();
            this.Hide();
        }

        private void guna2Button8_Click(object sender, EventArgs e)
        {
            Login login= new Login();
            login.Show();
            this.Hide();
        }

        private void Product_add_Click(object sender, EventArgs e)
        {
            try
            {
                // Check if ProdIdtxt is a valid integer
                if (!int.TryParse(ProdIdtxt.Text, out int prodId) || prodId <= 0)
                {
                    MessageBox.Show("Please enter a valid positive integer for Product ID");
                    return;
                }

                // Check if ProdNametxt has at least 2 characters
                if (ProdNametxt.Text.Length < 2)
                {
                    MessageBox.Show("Product name should have at least 2 characters");
                    return;
                }

                if (ProdQtytxt.Text == "" || ProdPricetxt.Text == "")
                {
                    MessageBox.Show("Missing Information for adding");
                }
                else
                {
                    Con.Open();
                    string query = "INSERT INTO ProductsTbl VALUES (" + prodId + ", '" + ProdNametxt.Text + "', " + ProdQtytxt.Text + "," + ProdPricetxt.Text + ",'" + categorycb.SelectedValue.ToString() + "')";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Product Added Successfully!");
                    Con.Close();
                    populate();
                    ProdIdtxt.Text = "";
                    ProdNametxt.Text = "";
                    ProdQtytxt.Text = "";
                    ProdPricetxt.Text = "";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void FillCategory()
        {
            try
            {
                Con.Open();
                SqlCommand cmd = new SqlCommand("select CatName from CategoryTbl", Con);
                SqlDataReader rdr;
                rdr = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Columns.Add("CatName", typeof(string));
                dt.Load(rdr);
                categorycb_search.ValueMember = "CatName";
                categorycb_search.DataSource = dt;
                categorycb.ValueMember = "CatName";
                categorycb.DataSource = dt;
                Con.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void populate()
        {
            try
            {
                Con.Open();
                string query = "select * from ProductsTbl";
                SqlDataAdapter sda = new SqlDataAdapter(query, Con);
                SqlCommandBuilder builder = new SqlCommandBuilder(sda);
                var ds = new DataSet();
                sda.Fill(ds);
                ProductsDGV.DataSource = ds.Tables[0];
                Con.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Product_Form_Load(object sender, EventArgs e)
        {
            FillCategory();
            populate();
        }

        private void ProductsDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // DataGridViewCellEventArgs nesnesinin RowIndex'i kontrol edilir
            if (e.RowIndex >= 0 && e.RowIndex < ProductsDGV.Rows.Count)
            {
                // Seçilen satırdaki belirli hücrelerden veri alınır
                ProdIdtxt.Text = ProductsDGV.Rows[e.RowIndex].Cells[0].Value?.ToString();
                ProdNametxt.Text = ProductsDGV.Rows[e.RowIndex].Cells[1].Value?.ToString();
                ProdQtytxt.Text = ProductsDGV.Rows[e.RowIndex].Cells[2].Value?.ToString();
                ProdPricetxt.Text = ProductsDGV.Rows[e.RowIndex].Cells[3].Value?.ToString();
                categorycb.SelectedValue = ProductsDGV.Rows[e.RowIndex].Cells[4].Value?.ToString();
            }
        }

        private void product_update_Click(object sender, EventArgs e)
        {
            try
            {
                if (ProdIdtxt.Text == "" || ProdNametxt.Text == "" || ProdQtytxt.Text == "" || ProdPricetxt.Text=="")
                {
                    MessageBox.Show("Missing Information");
                }
                else
                {
                    Con.Open();
                    string query = "update ProductsTbl set ProdName=' " + ProdNametxt.Text + " ',ProdQty=' " + ProdQtytxt.Text + "',ProdPrice=' "+ProdPricetxt.Text +" ',ProdCat='"+categorycb.SelectedValue.ToString()+"' where ProdId=" + ProdIdtxt.Text + "";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Product has been uptadet Succesfully");
                    Con.Close();
                    populate();
                    ProdIdtxt.Text = "";
                    ProdNametxt.Text = "";
                    ProdQtytxt.Text = "";
                    ProdPricetxt.Text = "";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void product_delete_Click(object sender, EventArgs e)
        {
            try
            {
                if (ProdIdtxt.Text == "")
                {
                    MessageBox.Show("Select Product ID to Delete");
                }
                else
                {
                    Con.Open();
                    string query = "delete from ProductsTbl where ProdId=" + ProdIdtxt.Text + "";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Product has been deleted Succesfully");
                    Con.Close();
                    populate();
                    ProdIdtxt.Text = "";
                    ProdNametxt.Text = "";
                    ProdQtytxt.Text = "";
                    ProdPricetxt.Text = "";

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void categorycb_search_SelectionChangeCommitted(object sender, EventArgs e)
        {
            try
            {
                Con.Open();
                string query = "select * from ProductsTbl where ProdCat='" + categorycb_search.SelectedValue.ToString() + "'";
                SqlDataAdapter sda = new SqlDataAdapter(query, Con);
                SqlCommandBuilder builder = new SqlCommandBuilder(sda);
                var ds = new DataSet();
                sda.Fill(ds);
                ProductsDGV.DataSource = ds.Tables[0];
                Con.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message );
            }
        }

        private void prodrefresh_Click(object sender, EventArgs e)
        {
            populate();
        }

        private void productreset_Click(object sender, EventArgs e)//reset atmaq ucun
        {
            ProdIdtxt.Text = "";
            ProdNametxt.Text = "";
            ProdPricetxt.Text = "";
            ProdQtytxt.Text = "";
        }

        private void guna2Button7_Click(object sender, EventArgs e)
        {
            Customers customers = new Customers();
            this.Hide();
            this.Show();
        }
    }
}
