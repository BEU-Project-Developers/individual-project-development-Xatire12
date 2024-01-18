namespace c__final_app
{
    partial class Category_Form
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Category_Form));
            this.panel1 = new System.Windows.Forms.Panel();
            this.CategoriesDGV = new System.Windows.Forms.DataGridView();
            this.CatDelete = new Guna.UI2.WinForms.Guna2Button();
            this.CatUpdate = new Guna.UI2.WinForms.Guna2Button();
            this.CatAdd = new Guna.UI2.WinForms.Guna2Button();
            this.label8 = new System.Windows.Forms.Label();
            this.CatDesctxt = new Guna.UI2.WinForms.Guna2TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.CatNametxt = new Guna.UI2.WinForms.Guna2TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.CatIdtxt = new Guna.UI2.WinForms.Guna2TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.guna2ImageButton1 = new Guna.UI2.WinForms.Guna2ImageButton();
            this.guna2ImageButton2 = new Guna.UI2.WinForms.Guna2ImageButton();
            this.btnSellers = new Guna.UI2.WinForms.Guna2Button();
            this.btnProducts = new Guna.UI2.WinForms.Guna2Button();
            this.btnSelling = new Guna.UI2.WinForms.Guna2Button();
            this.btnCustomers = new Guna.UI2.WinForms.Guna2Button();
            this.btnLogout = new Guna.UI2.WinForms.Guna2Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CategoriesDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkOrange;
            this.panel1.Controls.Add(this.CategoriesDGV);
            this.panel1.Controls.Add(this.CatDelete);
            this.panel1.Controls.Add(this.CatUpdate);
            this.panel1.Controls.Add(this.CatAdd);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.CatDesctxt);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.CatNametxt);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.CatIdtxt);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(138, 55);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(866, 598);
            this.panel1.TabIndex = 0;
            // 
            // CategoriesDGV
            // 
            this.CategoriesDGV.BackgroundColor = System.Drawing.SystemColors.Control;
            this.CategoriesDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CategoriesDGV.Location = new System.Drawing.Point(351, 70);
            this.CategoriesDGV.Name = "CategoriesDGV";
            this.CategoriesDGV.RowHeadersWidth = 51;
            this.CategoriesDGV.RowTemplate.Height = 24;
            this.CategoriesDGV.Size = new System.Drawing.Size(506, 509);
            this.CategoriesDGV.TabIndex = 16;
            this.CategoriesDGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.CategoriesDGV_CellContentClick);
            // 
            // CatDelete
            // 
            this.CatDelete.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.CatDelete.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.CatDelete.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.CatDelete.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.CatDelete.FillColor = System.Drawing.Color.White;
            this.CatDelete.Font = new System.Drawing.Font("Century", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CatDelete.ForeColor = System.Drawing.Color.DarkOrange;
            this.CatDelete.HoverState.FillColor = System.Drawing.Color.Red;
            this.CatDelete.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.CatDelete.Location = new System.Drawing.Point(235, 239);
            this.CatDelete.Name = "CatDelete";
            this.CatDelete.Size = new System.Drawing.Size(110, 33);
            this.CatDelete.TabIndex = 15;
            this.CatDelete.Text = "Delete";
            this.CatDelete.Click += new System.EventHandler(this.CatDelete_Click);
            // 
            // CatUpdate
            // 
            this.CatUpdate.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.CatUpdate.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.CatUpdate.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.CatUpdate.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.CatUpdate.FillColor = System.Drawing.Color.White;
            this.CatUpdate.Font = new System.Drawing.Font("Century", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CatUpdate.ForeColor = System.Drawing.Color.DarkOrange;
            this.CatUpdate.HoverState.FillColor = System.Drawing.Color.Red;
            this.CatUpdate.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.CatUpdate.Location = new System.Drawing.Point(121, 239);
            this.CatUpdate.Name = "CatUpdate";
            this.CatUpdate.Size = new System.Drawing.Size(108, 33);
            this.CatUpdate.TabIndex = 14;
            this.CatUpdate.Text = "Update";
            this.CatUpdate.Click += new System.EventHandler(this.CatUpdate_Click);
            // 
            // CatAdd
            // 
            this.CatAdd.BackColor = System.Drawing.Color.White;
            this.CatAdd.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.CatAdd.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.CatAdd.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.CatAdd.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.CatAdd.FillColor = System.Drawing.Color.White;
            this.CatAdd.Font = new System.Drawing.Font("Century", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CatAdd.ForeColor = System.Drawing.Color.DarkOrange;
            this.CatAdd.HoverState.FillColor = System.Drawing.Color.Red;
            this.CatAdd.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.CatAdd.Location = new System.Drawing.Point(3, 239);
            this.CatAdd.Name = "CatAdd";
            this.CatAdd.Size = new System.Drawing.Size(112, 33);
            this.CatAdd.TabIndex = 13;
            this.CatAdd.Text = "Add";
            this.CatAdd.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Schoolbook", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(9, 125);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(60, 21);
            this.label8.TabIndex = 12;
            this.label8.Text = "Name";
            // 
            // CatDesctxt
            // 
            this.CatDesctxt.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.CatDesctxt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.CatDesctxt.CustomizableEdges.BottomLeft = false;
            this.CatDesctxt.CustomizableEdges.BottomRight = false;
            this.CatDesctxt.CustomizableEdges.TopLeft = false;
            this.CatDesctxt.DefaultText = "";
            this.CatDesctxt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.CatDesctxt.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.CatDesctxt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.CatDesctxt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.CatDesctxt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.CatDesctxt.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.CatDesctxt.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.CatDesctxt.Location = new System.Drawing.Point(147, 169);
            this.CatDesctxt.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.CatDesctxt.Name = "CatDesctxt";
            this.CatDesctxt.PasswordChar = '\0';
            this.CatDesctxt.PlaceholderText = "";
            this.CatDesctxt.SelectedText = "";
            this.CatDesctxt.Size = new System.Drawing.Size(166, 28);
            this.CatDesctxt.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Schoolbook", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(9, 176);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(112, 21);
            this.label7.TabIndex = 10;
            this.label7.Text = "Description";
            // 
            // CatNametxt
            // 
            this.CatNametxt.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.CatNametxt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.CatNametxt.CustomizableEdges.BottomLeft = false;
            this.CatNametxt.CustomizableEdges.BottomRight = false;
            this.CatNametxt.CustomizableEdges.TopLeft = false;
            this.CatNametxt.DefaultText = "";
            this.CatNametxt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.CatNametxt.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.CatNametxt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.CatNametxt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.CatNametxt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.CatNametxt.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.CatNametxt.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.CatNametxt.Location = new System.Drawing.Point(147, 119);
            this.CatNametxt.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.CatNametxt.Name = "CatNametxt";
            this.CatNametxt.PasswordChar = '\0';
            this.CatNametxt.PlaceholderText = "";
            this.CatNametxt.SelectedText = "";
            this.CatNametxt.Size = new System.Drawing.Size(166, 28);
            this.CatNametxt.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Schoolbook", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(20, 126);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 21);
            this.label6.TabIndex = 8;
            // 
            // CatIdtxt
            // 
            this.CatIdtxt.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.CatIdtxt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.CatIdtxt.CustomizableEdges.BottomLeft = false;
            this.CatIdtxt.CustomizableEdges.BottomRight = false;
            this.CatIdtxt.CustomizableEdges.TopLeft = false;
            this.CatIdtxt.DefaultText = "";
            this.CatIdtxt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.CatIdtxt.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.CatIdtxt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.CatIdtxt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.CatIdtxt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.CatIdtxt.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.CatIdtxt.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.CatIdtxt.IconRightSize = new System.Drawing.Size(0, 0);
            this.CatIdtxt.Location = new System.Drawing.Point(147, 70);
            this.CatIdtxt.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.CatIdtxt.Name = "CatIdtxt";
            this.CatIdtxt.PasswordChar = '\0';
            this.CatIdtxt.PlaceholderText = "";
            this.CatIdtxt.SelectedText = "";
            this.CatIdtxt.Size = new System.Drawing.Size(166, 28);
            this.CatIdtxt.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Schoolbook", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(9, 77);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 21);
            this.label5.TabIndex = 6;
            this.label5.Text = "ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Schoolbook", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(313, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(209, 25);
            this.label2.TabIndex = 5;
            this.label2.Text = "Manage Categories";
            // 
            // guna2ImageButton1
            // 
            this.guna2ImageButton1.BackColor = System.Drawing.Color.Transparent;
            this.guna2ImageButton1.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.guna2ImageButton1.HoverState.ImageSize = new System.Drawing.Size(64, 64);
            this.guna2ImageButton1.Image = ((System.Drawing.Image)(resources.GetObject("guna2ImageButton1.Image")));
            this.guna2ImageButton1.ImageOffset = new System.Drawing.Point(0, 0);
            this.guna2ImageButton1.ImageRotate = 0F;
            this.guna2ImageButton1.ImageSize = new System.Drawing.Size(50, 50);
            this.guna2ImageButton1.Location = new System.Drawing.Point(957, 0);
            this.guna2ImageButton1.Name = "guna2ImageButton1";
            this.guna2ImageButton1.PressedState.ImageSize = new System.Drawing.Size(64, 64);
            this.guna2ImageButton1.Size = new System.Drawing.Size(47, 40);
            this.guna2ImageButton1.TabIndex = 5;
            this.guna2ImageButton1.Click += new System.EventHandler(this.guna2ImageButton1_Click);
            // 
            // guna2ImageButton2
            // 
            this.guna2ImageButton2.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.guna2ImageButton2.HoverState.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image")));
            this.guna2ImageButton2.HoverState.ImageSize = new System.Drawing.Size(64, 64);
            this.guna2ImageButton2.Image = ((System.Drawing.Image)(resources.GetObject("guna2ImageButton2.Image")));
            this.guna2ImageButton2.ImageOffset = new System.Drawing.Point(0, 0);
            this.guna2ImageButton2.ImageRotate = 0F;
            this.guna2ImageButton2.ImageSize = new System.Drawing.Size(68, 68);
            this.guna2ImageButton2.Location = new System.Drawing.Point(-13, 55);
            this.guna2ImageButton2.Name = "guna2ImageButton2";
            this.guna2ImageButton2.PressedState.ImageSize = new System.Drawing.Size(64, 64);
            this.guna2ImageButton2.Size = new System.Drawing.Size(145, 66);
            this.guna2ImageButton2.TabIndex = 7;
            // 
            // btnSellers
            // 
            this.btnSellers.BackColor = System.Drawing.SystemColors.Control;
            this.btnSellers.BorderColor = System.Drawing.Color.Transparent;
            this.btnSellers.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            this.btnSellers.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSellers.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSellers.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSellers.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSellers.FillColor = System.Drawing.Color.White;
            this.btnSellers.Font = new System.Drawing.Font("Century", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSellers.ForeColor = System.Drawing.Color.DarkOrange;
            this.btnSellers.HoverState.ForeColor = System.Drawing.Color.Red;
            this.btnSellers.Location = new System.Drawing.Point(2, 152);
            this.btnSellers.Name = "btnSellers";
            this.btnSellers.Size = new System.Drawing.Size(130, 30);
            this.btnSellers.TabIndex = 8;
            this.btnSellers.Text = "Sellers";
            this.btnSellers.Click += new System.EventHandler(this.btnSellers_Click);
            // 
            // btnProducts
            // 
            this.btnProducts.BackColor = System.Drawing.SystemColors.Control;
            this.btnProducts.BorderColor = System.Drawing.Color.Transparent;
            this.btnProducts.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            this.btnProducts.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnProducts.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnProducts.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnProducts.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnProducts.FillColor = System.Drawing.Color.White;
            this.btnProducts.Font = new System.Drawing.Font("Century", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProducts.ForeColor = System.Drawing.Color.DarkOrange;
            this.btnProducts.HoverState.ForeColor = System.Drawing.Color.Red;
            this.btnProducts.Location = new System.Drawing.Point(2, 188);
            this.btnProducts.Name = "btnProducts";
            this.btnProducts.Size = new System.Drawing.Size(130, 30);
            this.btnProducts.TabIndex = 9;
            this.btnProducts.Text = "Products";
            this.btnProducts.Click += new System.EventHandler(this.btnProducts_Click);
            // 
            // btnSelling
            // 
            this.btnSelling.BackColor = System.Drawing.SystemColors.Control;
            this.btnSelling.BorderColor = System.Drawing.Color.Transparent;
            this.btnSelling.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            this.btnSelling.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSelling.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSelling.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSelling.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSelling.FillColor = System.Drawing.Color.White;
            this.btnSelling.Font = new System.Drawing.Font("Century", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelling.ForeColor = System.Drawing.Color.DarkOrange;
            this.btnSelling.HoverState.ForeColor = System.Drawing.Color.Red;
            this.btnSelling.Location = new System.Drawing.Point(2, 224);
            this.btnSelling.Name = "btnSelling";
            this.btnSelling.Size = new System.Drawing.Size(130, 30);
            this.btnSelling.TabIndex = 10;
            this.btnSelling.Text = "Selling";
            this.btnSelling.Click += new System.EventHandler(this.btnSelling_Click);
            // 
            // btnCustomers
            // 
            this.btnCustomers.BackColor = System.Drawing.SystemColors.Control;
            this.btnCustomers.BorderColor = System.Drawing.Color.Transparent;
            this.btnCustomers.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            this.btnCustomers.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnCustomers.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnCustomers.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnCustomers.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnCustomers.FillColor = System.Drawing.Color.White;
            this.btnCustomers.Font = new System.Drawing.Font("Century", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCustomers.ForeColor = System.Drawing.Color.DarkOrange;
            this.btnCustomers.HoverState.ForeColor = System.Drawing.Color.Red;
            this.btnCustomers.Location = new System.Drawing.Point(2, 260);
            this.btnCustomers.Name = "btnCustomers";
            this.btnCustomers.Size = new System.Drawing.Size(130, 30);
            this.btnCustomers.TabIndex = 11;
            this.btnCustomers.Text = "Customers";
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.SystemColors.Control;
            this.btnLogout.BorderColor = System.Drawing.Color.Transparent;
            this.btnLogout.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            this.btnLogout.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnLogout.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnLogout.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnLogout.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnLogout.FillColor = System.Drawing.Color.White;
            this.btnLogout.Font = new System.Drawing.Font("Century", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.ForeColor = System.Drawing.Color.DarkOrange;
            this.btnLogout.HoverState.ForeColor = System.Drawing.Color.Red;
            this.btnLogout.Location = new System.Drawing.Point(2, 623);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(130, 30);
            this.btnLogout.TabIndex = 12;
            this.btnLogout.Text = "Logout";
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // Category_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1007, 655);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.btnCustomers);
            this.Controls.Add(this.btnSelling);
            this.Controls.Add(this.btnProducts);
            this.Controls.Add(this.btnSellers);
            this.Controls.Add(this.guna2ImageButton2);
            this.Controls.Add(this.guna2ImageButton1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Category_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Category_Form";
            this.Load += new System.EventHandler(this.Category_Form_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CategoriesDGV)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2TextBox CatIdtxt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label8;
        private Guna.UI2.WinForms.Guna2TextBox CatDesctxt;
        private System.Windows.Forms.Label label7;
        private Guna.UI2.WinForms.Guna2TextBox CatNametxt;
        private System.Windows.Forms.Label label6;
        private Guna.UI2.WinForms.Guna2Button CatDelete;
        private Guna.UI2.WinForms.Guna2Button CatUpdate;
        private Guna.UI2.WinForms.Guna2Button CatAdd;
        private System.Windows.Forms.DataGridView CategoriesDGV;
        private Guna.UI2.WinForms.Guna2ImageButton guna2ImageButton1;
        private Guna.UI2.WinForms.Guna2ImageButton guna2ImageButton2;
        private Guna.UI2.WinForms.Guna2Button btnSellers;
        private Guna.UI2.WinForms.Guna2Button btnProducts;
        private Guna.UI2.WinForms.Guna2Button btnSelling;
        private Guna.UI2.WinForms.Guna2Button btnCustomers;
        private Guna.UI2.WinForms.Guna2Button btnLogout;
    }
}