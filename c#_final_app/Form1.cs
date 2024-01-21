using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace c__final_app
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void guna2ImageButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        int startpoint = 0;

        // Zamanlayıcı tətikləndikdə işlənən metod
        private void timer1_Tick(object sender, EventArgs e)
        {
            // ProgressBar'ın dəyərini artır
            startpoint += 1;
            // ProgressBar'ın dəyərini təyin et
            ProgressBar1.Value = startpoint;
            // ProgressBar'ın dəyəri 100-ə bərabər olduqda
            if (ProgressBar1.Value == 100)
            {
                // ProgressBar'ın dəyərini sıfırla
                ProgressBar1.Value = 0;
                // Zamanlayıcıyı dayandır
                timer1.Stop();
                // Yeni Login formunu yarat
                Login log =new Login();
                // Hal-hazırda açıq olan formu gizlət
                this.Hide();
                // Yeni Login formunu göstər 
                log.Show();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }
    }
}
