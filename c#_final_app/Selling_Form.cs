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
    public partial class Selling_Form : Form
    {
        public Selling_Form()
        {
            InitializeComponent();
        }
       
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\User\source\repos\c#_final_app\c#_final_app\Final.mdf;Integrated Security=True");
        private void populate()
        {
            try
            {
                Con.Open();
                string query = "select ProdName,ProdQty,ProdPrice from ProductsTbl";
                // SqlDataAdapter, SQL sorğusunu və bağlantıyı istifadə edərək məlumat əldə etmək üçün istifadə olunur
                SqlDataAdapter sda = new SqlDataAdapter(query, Con);
                // SqlCommandBuilder, SqlDataAdapter ilə birgə istifadə edilərək SQL sorğularını avtomatik olaraq yaratmağa imkan verir
                SqlCommandBuilder builder = new SqlCommandBuilder(sda);
                // Yeni bir DataSet yarat
                var ds = new DataSet();
                // SqlDataAdapter ilə məlumatı DataSet-ə yüklə
                sda.Fill(ds);
                // DataGridView nəzarətini DataSet-in birinci cədvəlinə bağla
                ProdDGV.DataSource = ds.Tables[0];
                Con.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void populatebills()
        {
            try
            {
                Con.Open();
                string query = "select * from BillsTbl";
                SqlDataAdapter sda = new SqlDataAdapter(query, Con);
                SqlCommandBuilder builder = new SqlCommandBuilder(sda);
                var ds = new DataSet();
                sda.Fill(ds);
                BillsDGV.DataSource = ds.Tables[0];
                Con.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        
        private void guna2ImageButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private bool IsSeller()
        {
            // Check if the current user is a seller
            // You can use the Sellername or any other criteria to determine this
            // For example, you can check if the user exists in the SellersTbl
            return !string.IsNullOrEmpty(Login.Sellername);
        }

        private void Selling_form_sellers_Click(object sender, EventArgs e)
        {
            if (!IsSeller())
            {
                Seller_Form seller_Form = new Seller_Form();
                seller_Form.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("You do not have permission to access this form.");
            }
        }

        private void Selling_form_products_Click(object sender, EventArgs e)
        {
            if (!IsSeller())
            {
                Product_Form product_Form = new Product_Form();
                product_Form.Show();
                this.Hide();
            }
            else
            {
             MessageBox.Show("You do not have permission to access this form.");
            }

                    
        }

        private void Selling_form_category_Click(object sender, EventArgs e)
        {
            if (!IsSeller())
            {
                Category_Form category_Form = new Category_Form();
                category_Form.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("You do not have permission to access this form.");
            }
        }

        private void Selling_form_logout_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }
        int Grdtotal = 0, n = 0;
        //Add product buttonu
        private void sellingadd_Click(object sender, EventArgs e)
        {
            if (billname.Text == "" || billqty.Text == "")
            {
                MessageBox.Show("Məlumat əksikdir!");
            }
            else
            {
                int total = Convert.ToInt32(billprice.Text) * Convert.ToInt32(billqty.Text);

                // Məhsulu veritabanında yenilə
                bool updateSuccessful = UpdateProductQuantityInDatabase(billname.Text, Convert.ToInt32(billqty.Text));

                // Yeni sətri ProductDGV cədvəlinə əlavə etmə
                if (updateSuccessful)
                {
                    DataGridViewRow newRow = new DataGridViewRow();
                    newRow.CreateCells(ProductDGV);

                    newRow.Cells[0].Value = n + 1;
                    newRow.Cells[1].Value = billname.Text;
                    newRow.Cells[2].Value = billqty.Text;
                    newRow.Cells[3].Value = billprice.Text;
                    newRow.Cells[4].Value = Convert.ToInt32(billprice.Text) * Convert.ToInt32(billqty.Text);

                    ProductDGV.Rows.Add(newRow);

                    n++;
                    Grdtotal = Grdtotal + total;
                    rs.Text = "" + Grdtotal;
                }
                else
                {
                    MessageBox.Show("Eroor: Məhsul miqdarı çoxdur və ya 0-dır!");
                }
            }
        }
        private bool UpdateProductQuantityInDatabase(string productName, int soldQuantity)
        {
            try
            {
                Con.Open();

                string updateQuery = "UPDATE ProductsTbl SET ProdQty = ProdQty - @SoldQuantity WHERE ProdName = @ProductName AND ProdQty >= @SoldQuantity";
                SqlCommand updateCommand = new SqlCommand(updateQuery, Con);

                updateCommand.Parameters.AddWithValue("@SoldQuantity", soldQuantity);
                updateCommand.Parameters.AddWithValue("@ProductName", productName);

                int affectedRows = updateCommand.ExecuteNonQuery();

                Con.Close();

                // Eğer 0 və ya daha az sıra əks etmişsə, yani miqdar çox olmuşsa və ya 0-a bərabər olmuşsa
                return affectedRows > 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }


        private void Selling_Form_Load(object sender, EventArgs e)
        {
            populate();
            populatebills();
            FillCategory();
            // Satıcı adını, giriş ekranından gələn satıcı adı ilə təyin et
            sellingsellername.Text = Login.Sellername;
       
        }

        private void ProdDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < ProductDGV.Rows.Count)
            {
                // Seçilen satırdaki belirli hücrelerden veri alınır

                billname.Text = ProductDGV.Rows[e.RowIndex].Cells[1].Value?.ToString();
                billqty.Text = ProductDGV.Rows[e.RowIndex].Cells[2].Value?.ToString();
                billprice.Text = ProductDGV.Rows[e.RowIndex].Cells[3].Value?.ToString();

            }//gridbox a click etdikde labellerin avtomatik doldurulmasi ucun 
        }

            private void panel1_Paint(object sender, PaintEventArgs e)
        {
            
            sellingdate.Text = DateTime.Today.ToString("dd/MM/yyyy");
        }

        private void PrintDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            if (BillsDGV.SelectedRows.Count > 0)
            {
                e.Graphics.DrawString("Pacify Supermarket", new Font("Century Gothic", 25, FontStyle.Bold), Brushes.Red, new Point(230));
                e.Graphics.DrawString("Bill ID:" + BillsDGV.SelectedRows[0].Cells[0].Value.ToString(), new Font("Century Gothic", 20, FontStyle.Bold), Brushes.Blue, new Point(100, 70));
                e.Graphics.DrawString("Seller Name:" + BillsDGV.SelectedRows[0].Cells[1].Value.ToString(), new Font("Century Gothic", 20, FontStyle.Bold), Brushes.Blue, new Point(100, 100));
                e.Graphics.DrawString("Bill Date:" + Convert.ToDateTime(BillsDGV.SelectedRows[0].Cells[2].Value).ToString("yyyy-MM-dd"), new Font("Century Gothic", 20, FontStyle.Bold), Brushes.Blue, new Point(100, 130));
                e.Graphics.DrawString("Total Amount:" + BillsDGV.SelectedRows[0].Cells[3].Value.ToString(), new Font("Century Gothic", 20, FontStyle.Bold), Brushes.Blue, new Point(100, 160));
                e.Graphics.DrawString("Pacify Supermarket", new Font("Century Gothic", 25, FontStyle.Bold), Brushes.Red, new Point(230, 230));
            }
            else
            {
                MessageBox.Show("No row selected");
            }
            }//print eleme hissesidi.Print buttonuna basdiqda bu hisse calisir

        private void sellingprint_Click(object sender, EventArgs e)
        {
            // Əgər istifadəçi çap önizləmə pəncərəsini təsdiqləyibsə
            if (PrintPreviewDialog1.ShowDialog()==DialogResult.OK)
            {
                // Sənəti çap etmək üçün müəyyən olunmuş PrintDocument obyektindən istifadə et
                PrintDocument1.Print();
            }
        }

        private void sellingrefresh_Click(object sender, EventArgs e)
        {
            populate();
        }

        private void sellingselect_SelectionChangeCommitted(object sender, EventArgs e)
        {
            try
            {
                Con.Open();
                string query = "select ProdName,ProdQty,ProdPrice from ProductsTbl where ProdCat='" + sellingselect.SelectedValue.ToString() + "'";
                SqlDataAdapter sda = new SqlDataAdapter(query, Con);
                SqlCommandBuilder builder = new SqlCommandBuilder();
                var ds = new DataSet();
                sda.Fill(ds);
                ProdDGV.DataSource = ds.Tables[0];
                Con.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void sellingadd2_Click(object sender, EventArgs e)
        {
            // Əgər fatura ID sahəsi boş və ya null-dir
            if (string.IsNullOrWhiteSpace(billid.Text))
            {
                MessageBox.Show("Missing Bill ID");
            }
            else
            {
                // Əgər fatura ID-si düzgün bir tam ədəd olmayıb
                if (!int.TryParse(billid.Text, out int billId) || billId <= 0)
                {
                    MessageBox.Show("Please enter a valid positive integer for Bill ID");
                }
                else
                {
                    try
                    {
                        Con.Open();
                        string query = "INSERT INTO BillsTbl VALUES (" + billId + ",'" + sellingsellername.Text + "','" + sellingdate.Text + "'," + rs.Text + ")";
                        SqlCommand cmd = new SqlCommand(query, Con);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Order Added Successfully!");
                        Con.Close();
                        populatebills();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }

        }

        private void ProductDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // DataGridViewCellEventArgs nesnesinin RowIndex'i kontrol edilir
            if (e.RowIndex >= 0 && e.RowIndex < ProductDGV.Rows.Count)
            {
                // Seçilen satırdaki belirli hücrelerden veri alınır
                billid.Text = ProductDGV.Rows[e.RowIndex].Cells[0].Value?.ToString();
                billname.Text = ProductDGV.Rows[e.RowIndex].Cells[1].Value?.ToString();
                billqty.Text = ProductDGV.Rows[e.RowIndex].Cells[2].Value?.ToString();
                billprice.Text = ProductDGV.Rows[e.RowIndex].Cells[3].Value?.ToString();
                
            }
        }

        private void sellingselect_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void guna2Button7_Click(object sender, EventArgs e)
        {
            Customers customers = new Customers();
            this.Hide();
            customers.Show();
        }

        private void FillCategory()
        {
            try
            {
                Con.Open();
                SqlCommand cmd = new SqlCommand("select CatName from CategoryTbl", Con);
                // SQL əmri üçün oxucunu təyin et
                SqlDataReader rdr;
                rdr = cmd.ExecuteReader();
                // Yeni bir DataTable yarat
                DataTable dt = new DataTable();
                // DataTable-a "CatName" adlı sütunu əlavə et, tipi string-dir
                dt.Columns.Add("CatName", typeof(string));
                // SqlDataReader-dan DataTable-a məlumatı yüklə
                dt.Load(rdr);
                // ComboBox-dan görmə qısa adı üçün "CatName" sütununu seç
                sellingselect.ValueMember = "CatName";
                // ComboBox-ı DataTable ilə əldə olunan məlumatla doldur
                sellingselect.DataSource = dt;
                Con.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
