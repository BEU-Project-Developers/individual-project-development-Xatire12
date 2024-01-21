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
using System.Drawing.Design;

namespace c__final_app
{
    public partial class Category_Form : Form
    {
        public Category_Form()
        {
            InitializeComponent();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\User\source\repos\c#_final_app\c#_final_app\Final.mdf;Integrated Security=True");


        private void guna2ImageButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Category_Form_Load(object sender, EventArgs e)
        {
            populate();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(CatIdtxt.Text))
            {
                MessageBox.Show("Missing Category ID");
            }
            else
            {
                // Check if CatIdtxt is a valid integer
                if (!int.TryParse(CatIdtxt.Text, out int catId) || catId <= 0)
                {
                    MessageBox.Show("Please enter a valid positive integer for Category ID");
                }
                else
                {
                    try
                    {
                        Con.Open();
                        string query = "INSERT INTO CategoryTbl VALUES (" + catId + ", '" + CatNametxt.Text + "', '" + CatDesctxt.Text + "')";
                        SqlCommand cmd = new SqlCommand(query, Con);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Category Added Successfully!");
                        Con.Close();
                        populate();
                        CatIdtxt.Text = "";
                        CatNametxt.Text = "";
                        CatDesctxt.Text = "";
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }

        }
        private void populate()//Category table dan melumatlari cekib DataSet obyekti yaradaraq DataGridView a baglayir
        {
            Con.Open();//baglantini acir database ile
            string query = "select * from CategoryTbl";//category tableden butun sutunlari cekir
            SqlDataAdapter sda=new SqlDataAdapter(query,Con);//databaseden data cekmek ve DataSet e doldurmaq ucun istifade edilir
            SqlCommandBuilder builder=new SqlCommandBuilder(sda);//SqlCommandBuilder sinfini istifade ederek SqlDataAdapter obyekti uzerinde add ve delete islemlerini avtomatiklesdirmek ucun istifade olunur
            var ds = new DataSet();//data elde etmek ve islemek ucun
            sda.Fill(ds);//SqlDataAdapter obyektini istifade ederek elde olunan melumatlari DataSete doldurur
            CategoriesDGV.DataSource = ds.Tables[0];//Bu sıra, DataSet içindəki ilk cədvəli (Tables[0]) bir DataGridView nəzarətinə bağlayır. CategoriesDGV ehtimal ki, bir DataGridView nəzarətini təmsil edir.
            Con.Close();//database ile baglanti close edilir
        }
        
        private void CategoriesDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < CategoriesDGV.Rows.Count)
            {
                // Seçilen satırdaki belirli hücrelerden veri alınır
                CatIdtxt.Text = CategoriesDGV.Rows[e.RowIndex].Cells[0].Value.ToString();
                CatNametxt.Text = CategoriesDGV.Rows[e.RowIndex].Cells[1].Value.ToString();
                CatDesctxt.Text = CategoriesDGV.Rows[e.RowIndex].Cells[2].Value.ToString();
            }

        }

        private void CatUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (CatIdtxt.Text == "" || CatNametxt.Text == "" || CatDesctxt.Text == "")
                {
                    MessageBox.Show("Missing Information");
                }
                else
                {
                    Con.Open();
                    string query = "update CategoryTbl set CatName=' " + CatNametxt.Text + " ',CatDesc=' " + CatDesctxt.Text + "' where CatId=" + CatIdtxt.Text + "";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Category has been uptadet Succesfully");
                    Con.Close();
                    populate();
                    CatIdtxt.Text = "";
                    CatNametxt.Text = "";
                    CatDesctxt.Text = "";
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void CatDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (CatIdtxt.Text == "")
                {
                    MessageBox.Show("Select Category ID to Delete");
                }
                else
                {
                    Con.Open();
                    string query = "delete from CategoryTbl where CatId=" + CatIdtxt.Text + "";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Category has been deleted Succesfully");
                    Con.Close();
                    populate();
                    CatIdtxt.Text = "";
                    CatNametxt.Text = "";
                    CatDesctxt.Text = "";

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnSellers_Click(object sender, EventArgs e)
        {
            Seller_Form Sell=new Seller_Form();
            Sell.Show();
            this.Hide();
        }

        private void btnProducts_Click(object sender, EventArgs e)
        {
            Product_Form product=new Product_Form();
            product.Show();
            this.Hide();
        }

        private void btnSelling_Click(object sender, EventArgs e)
        {
            Selling_Form sell=new Selling_Form();
            sell.Show();
            this.Hide();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login login = new Login();
            login.Show();
        }

        private void categoryreset_Click(object sender, EventArgs e)
        {
            
            CatNametxt.Text = "";
            CatDesctxt.Text = "";

            }

        private void btnCustomers_Click(object sender, EventArgs e)
        {
            Customers customers = new Customers();
            customers.Show();
            this.Hide();
        }
    }

}
