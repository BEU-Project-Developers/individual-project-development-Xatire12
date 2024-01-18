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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        public static string Sellername = "";
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\User\source\repos\c#_final_app\c#_final_app\Final.mdf;Integrated Security=True");


        private void guna2ImageButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void loginenterbtn_Click(object sender, EventArgs e)
        {
            if (username.Text == "" || userpassword.Text == "")
            {
                MessageBox.Show("Please enter the username and password");
            }
            else
            {
                if (loginselectrole.SelectedIndex > -1)
                {
                    if (loginselectrole.SelectedItem.ToString() == "Admin")
                    {
                        if(username.Text=="Admin" && userpassword.Text == "Admin")
                        {
                            Product_Form Prod= new Product_Form();
                            Prod.Show();
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("If you are admin  enter correct password and username!");
                        }
                    }
                    else
                    {
                        Con.Open();
                        SqlDataAdapter sda = new SqlDataAdapter("select count(*) from SellersTbl where SellerName='" + username.Text + "' and SellerPassword='" + userpassword.Text + "'", Con);
                        DataTable dt=new DataTable();
                        sda.Fill(dt);
                        if (dt.Rows[0][0].ToString() == "1") {
                            Sellername = username.Text;
                            Selling_Form sell=new Selling_Form();
                            sell.Show();
                            this.Hide();
                            Con.Close();
                        }
                        else
                        {
                            MessageBox.Show("Wrong Username and Password!");
                        }
                        Con.Close();
                    }
                }
                else
                {
                    MessageBox.Show("Select the role to Login");
                }
            }
        }

        private void loginresetbtn_Click(object sender, EventArgs e)
        {
            username.Text = "";
            userpassword.Text = "";
        }
    }
}
