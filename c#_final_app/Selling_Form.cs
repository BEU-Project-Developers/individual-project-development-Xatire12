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
            Con.Open();
            string query = "select ProdName,ProdQty,ProdPrice from ProductsTbl";
            SqlDataAdapter sda = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            ProdDGV.DataSource = ds.Tables[0];
            Con.Close();
        }
        private void populatebills()
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
        
        private void guna2ImageButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Selling_form_sellers_Click(object sender, EventArgs e)
        {
            Seller_Form seller_Form = new Seller_Form();
            seller_Form.Show();
            this.Hide();
        }

        private void Selling_form_products_Click(object sender, EventArgs e)
        {
            Product_Form product_Form = new Product_Form();
            product_Form.Show();
            this.Hide();
        }

        private void Selling_form_category_Click(object sender, EventArgs e)
        {
            Category_Form category_Form = new Category_Form();
            category_Form.Show();
            this.Hide();
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
           if(billname.Text==""|| billqty.Text == "")
            {
                MessageBox.Show("Missing Information!");

            }
            else
            {
                int total=Convert.ToInt32(billprice.Text) * Convert.ToInt32(billqty.Text);
                DataGridViewRow newRow=new DataGridViewRow();
                newRow.CreateCells(ProductDGV);
                newRow.Cells[0].Value = n + 1;
                newRow.Cells[1].Value = billname.Text;
                newRow.Cells[2].Value = billqty.Text;
                newRow.Cells[3].Value = billprice.Text;
                newRow.Cells[4].Value = Convert.ToInt32(billprice.Text)*Convert.ToInt32(billqty.Text);
                ProductDGV.Rows.Add(newRow);
                n++;
                Grdtotal=Grdtotal+total;
                rs.Text = "" + Grdtotal;
            }
            
        }
       
        private void Selling_Form_Load(object sender, EventArgs e)
        {
            populate();
            populatebills();
            FillCategory();
            sellingsellername.Text = Login.Sellername;
            ProductDGV.CellFormatting += ProductDGV_CellFormatting;
            
        }

        private void ProdDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < ProductDGV.Rows.Count)
            {
                // Seçilen satırdaki belirli hücrelerden veri alınır

                billname.Text = ProductDGV.Rows[e.RowIndex].Cells[1].Value?.ToString();
                billqty.Text = ProductDGV.Rows[e.RowIndex].Cells[2].Value?.ToString();
                billprice.Text = ProductDGV.Rows[e.RowIndex].Cells[3].Value?.ToString();

            }
        }

            private void panel1_Paint(object sender, PaintEventArgs e)
        {
            //sellingdate.Text=DataTime.Today.ToString()+"/"+DataTime.Today.Month.ToString()+"/"+DataTime.Today.Year.ToString();
            sellingdate.Text = DateTime.Today.ToString("dd/MM/yyyy");
        }

        private void PrintDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString("Pacify Supermarket", new Font("Century Gothic", 25, FontStyle.Bold), Brushes.Red, new Point(230));
            e.Graphics.DrawString("Bill ID:" + BillsDGV.SelectedRows[0].Cells[0].Value.ToString(), new Font("Century Gothic", 20, FontStyle.Bold), Brushes.Blue, new Point(100,70));
            e.Graphics.DrawString("Seller Name:" + BillsDGV.SelectedRows[0].Cells[1].Value.ToString(), new Font("Century Gothic", 20, FontStyle.Bold), Brushes.Blue, new Point(100,100));
            e.Graphics.DrawString("Bill Date:" + BillsDGV.SelectedRows[0].Cells[2].Value.ToString(), new Font("Century Gothic", 20, FontStyle.Bold), Brushes.Blue, new Point(100,130));
            e.Graphics.DrawString("Total Amount:" + BillsDGV.SelectedRows[0].Cells[3].Value.ToString(), new Font("Century Gothic", 20, FontStyle.Bold), Brushes.Blue, new Point(100,160));
            e.Graphics.DrawString("Pacify Supermarket", new Font("Century Gothic", 25, FontStyle.Bold), Brushes.Red, new Point(230,230));
        }

        private void sellingprint_Click(object sender, EventArgs e)
        {
         if(PrintPreviewDialog1.ShowDialog()==DialogResult.OK)
            {
                PrintDocument1.Print();
            }
        }

        private void sellingrefresh_Click(object sender, EventArgs e)
        {
            populate();
        }

        private void sellingselect_SelectionChangeCommitted(object sender, EventArgs e)
        {
            Con.Open();
            string query = "select ProdName,ProdQty from ProductsTbl where ProdCat='" + sellingselect.SelectedValue.ToString() + "'";
            SqlDataAdapter sda = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder=new SqlCommandBuilder();
            var ds = new DataSet();
            sda.Fill(ds);
            ProdDGV.DataSource = ds.Tables[0];
            Con.Close();
        }

        private void sellingadd2_Click(object sender, EventArgs e)
        {
            if (billid.Text == "")
            {
                MessageBox.Show("Missing Bill ID");
            }
            else
            {
                try
                {

                    Con.Open();
                    string query = "insert into BillsTbl values(" + billid.Text + ",'" + sellingsellername.Text + "','" + sellingdate.Text + "'," + rs.Text + ")";
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

        /* private void ProductDGV_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
         {
             ProductDGV.Columns[0].HeaderCell.Style.ForeColor=Color.White;
             ProductDGV.Columns[1].HeaderCell.Style.ForeColor = Color.White;
             ProductDGV.Columns[2].HeaderCell.Style.ForeColor = Color.White;
             ProductDGV.Columns[3].HeaderCell.Style.ForeColor = Color.White;
             ProductDGV.Columns[4].HeaderCell.Style.ForeColor = Color.White;

             ProductDGV.Columns[0].HeaderCell.Style.BackColor = Color.Chocolate;
             ProductDGV.Columns[1].HeaderCell.Style.BackColor = Color.Chocolate;
             ProductDGV.Columns[2].HeaderCell.Style.BackColor = Color.Chocolate;
             ProductDGV.Columns[3].HeaderCell.Style.BackColor = Color.Chocolate;
             ProductDGV.Columns[4].HeaderCell.Style.BackColor = Color.Chocolate;

         }*/
        private void ProductDGV_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex == -1) // Check if it's a header cell
            {
                DataGridViewColumn column = ProductDGV.Columns[e.ColumnIndex];

                // Style header cells
                column.HeaderCell.Style.ForeColor = Color.White;
                column.HeaderCell.Style.BackColor = Color.Chocolate;
            }
        }

        private void ProductDGV_ColumnAdded(object sender, DataGridViewColumnEventArgs e)
        {
            e.Column.HeaderCell.Style.ForeColor = Color.White;
            e.Column.HeaderCell.Style.BackColor = Color.Chocolate;
        }

        private void FillCategory()
        {
            Con.Open();
            SqlCommand cmd = new SqlCommand("select CatName from CategoryTbl", Con);
            SqlDataReader rdr;
            rdr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("CatName", typeof(string));
            dt.Load(rdr);
            //categorycb_search.ValueMember = "CatName";
            //categorycb_search.DataSource = dt;
            sellingselect.ValueMember = "CatName";
            sellingselect.DataSource = dt;
            Con.Close();
        }
    }
}
