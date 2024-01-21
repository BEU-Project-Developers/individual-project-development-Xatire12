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
using System.Threading;
using System.Diagnostics.Eventing.Reader;

namespace c__final_app
{
    public partial class Customers : Form
    {
        public Customers()
        {
            InitializeComponent();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\User\source\repos\c#_final_app\c#_final_app\Final.mdf;Integrated Security=True");

        private bool IsSeller()
        {
            // Check if the current user is a seller
            // You can use the Sellername or any other criteria to determine this
            // For example, you can check if the user exists in the SellersTbl
            return !string.IsNullOrEmpty(Login.Sellername);
        }
        //logout ucun
        private void Selling_form_logout_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            this.Hide();
            login.Show();
        }
        
        //selling formuna kecid ucun
        private void Seller_form_selling_Click(object sender, EventArgs e)
        {
            Selling_Form selling=new Selling_Form();
            this.Hide();
            selling.Show();
        }
        //product formuna kecid ucun
        private void Seller_form_products_Click(object sender, EventArgs e)
        {
            if (!IsSeller()) { 
            Product_Form product = new Product_Form();
            this.Hide();
            product.Show(); }
            else{
                MessageBox.Show("You do not have permission to access this form.");
            }
        }
       
   
        //category formuna kedic ucun
        private void Selling_Form_category_Click(object sender, EventArgs e)
        {
            if (!IsSeller())
            {
                Category_Form category = new Category_Form();
                this.Hide();
                category.Show();
            }
            else
            {
                MessageBox.Show("You do not have permission to access this form.");
            }
        }
        //seller formuna kecid ucun
        private void guna2Button7_Click(object sender, EventArgs e)
        {
            if (!IsSeller())
            {
                Seller_Form sell = new Seller_Form();
                this.Hide();
                sell.Show();
            }
            else
            {
                MessageBox.Show("You do not have permission to access this form.");
            }
        }

       //Customer table dan melumatlari cekir ve customerDGV ni hemin melumatlarla doldurur
            private void populate()
            {
                Con.Open();
                string query = "select * from CustomersTbl";
                SqlDataAdapter sda = new SqlDataAdapter(query, Con);
                SqlCommandBuilder builder = new SqlCommandBuilder(sda);
                var ds = new DataSet();
                sda.Fill(ds);
                customerDGV.DataSource = ds.Tables[0];
                Con.Close();
            }

        private void Customers_Load(object sender, EventArgs e)
        {
            populate();
        }
        //customer tablesin den melumatlri silmek ucun
        private void customerdelete_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (customeridtxt.Text == "")
                {
                    MessageBox.Show("Select Customer ID to Delete");
                }
                else
                {
                    Con.Open();
                    string query = "DELETE FROM CustomersTbl WHERE Id = @CustomerId";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.Parameters.AddWithValue("@CustomerId", customeridtxt.Text); // Use parameters to avoid SQL injection
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Customer has been deleted Successfully");
                    Con.Close();
                    populate();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }
        //customerDGV de setirlere click etdikde avtomatik labellerin doldurulmasi ucun
        private void customerDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //DGV dan select edende index of out erroru veresin deye bunu yaziriq
            if (e.RowIndex >= 0 && e.RowIndex < customerDGV.Rows.Count)
            {
                customeridtxt.Text = customerDGV.Rows[e.RowIndex].Cells[0].Value.ToString();
                customernametxt.Text = customerDGV.Rows[e.RowIndex].Cells[1].Value.ToString();
                customersurnametxt.Text = customerDGV.Rows[e.RowIndex].Cells[2].Value.ToString();
                customermobiletxt.Text = customerDGV.Rows[e.RowIndex].Cells[3].Value.ToString();
                customerbonuscard.Text = customerDGV.Rows[e.RowIndex].Cells[5].Value.ToString();

                // Parse the date from the cell and set it to the DateTimePicker
                if (DateTime.TryParse(customerDGV.Rows[e.RowIndex].Cells[4].Value.ToString(), out DateTime birthDate))
                {
                    customerdate.Value = birthDate;
                }
                else
                {
                    // Handle the case where the date parsing fails
                    MessageBox.Show("Invalid date format in the DataGridView cell");
                }
            }

        }
        //customer elave etmek ucun istifade olunan komanda
        private void customeradd_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (customeridtxt.Text == "" || customernametxt.Text == "" || customersurnametxt.Text == "" || customermobiletxt.Text == "" || customerdate.Text == "" || customerbonuscard.Text == "")
                {
                    MessageBox.Show("Missing Information");
                }
                else
                {
                    Con.Open();
                    string query = "INSERT INTO CustomersTbl VALUES (@CustomerId, @Name, @Surname, @Mobile, @BirthDate, @BonusCard)";
                    SqlCommand cmd = new SqlCommand(query, Con);

                    // Use parameters to avoid SQL injection and handle date format
                    cmd.Parameters.AddWithValue("@CustomerId", customeridtxt.Text);
                    cmd.Parameters.AddWithValue("@Name", customernametxt.Text);
                    cmd.Parameters.AddWithValue("@Surname", customersurnametxt.Text);
                    cmd.Parameters.AddWithValue("@Mobile", customermobiletxt.Text);
                    cmd.Parameters.AddWithValue("@BirthDate", customerdate.Value.Date.ToString("yyyy-MM-dd")); // Format the date
                    cmd.Parameters.AddWithValue("@BonusCard", customerbonuscard.Text);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Customer Added Successfully!");
                    Con.Close();
                    populate();

                    customeridtxt.Text = "";
                    customernametxt.Text = "";
                    customersurnametxt.Text = "";
                    customermobiletxt.Text = "";
                    customerbonuscard.Text = "";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        //customer i update etmek ucun 
        private void customerupdate_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (customeridtxt.Text == "" || customernametxt.Text == "" || customersurnametxt.Text == "" || customermobiletxt.Text == "" || customerbonuscard.Text == "")
                {
                    MessageBox.Show("Missing Information");
                }
                else
                {
                    Con.Open();
                    string query = "UPDATE CustomersTbl SET Name=@Name, Surname=@Surname, Mobile=@Mobile, BirthDate=@BirthDate, BonusCard=@BonusCard WHERE Id=@Id";
                    SqlCommand cmd = new SqlCommand(query, Con);

                    // Use parameters to avoid SQL injection and handle date format
                    cmd.Parameters.AddWithValue("@Name", customernametxt.Text);
                    cmd.Parameters.AddWithValue("@Surname", customersurnametxt.Text);
                    cmd.Parameters.AddWithValue("@Mobile", customermobiletxt.Text);
                    cmd.Parameters.AddWithValue("@BirthDate", customerdate.Value.Date);
                    cmd.Parameters.AddWithValue("@BonusCard", customerbonuscard.Text);
                    cmd.Parameters.AddWithValue("@Id", customeridtxt.Text);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Customer has been updated successfully");
                    Con.Close();
                    populate();

                    customeridtxt.Text = "";
                    customernametxt.Text = "";
                    customersurnametxt.Text = "";
                    customermobiletxt.Text = "";
                    customerbonuscard.Text = "";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        //reset i click etdikde labellerde yazilan butun melumatlarin sifilanmasi ucun
        private void customerreset_Click_1(object sender, EventArgs e)
        {
            customernametxt.Text = "";
            customeridtxt.Text = "";
            customersurnametxt.Text = "";
            customermobiletxt.Text = "";
            customerbonuscard.Text = "";
        }

        private void guna2ImageButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
    }

