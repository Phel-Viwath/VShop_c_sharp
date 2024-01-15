namespace V_Shop.Presentation
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.panel5 = new System.Windows.Forms.Panel();
            this.BtMenu = new Guna.UI2.WinForms.Guna2Button();
            this.btMinimize = new Guna.UI2.WinForms.Guna2Button();
            this.btnExit = new Guna.UI2.WinForms.Guna2Button();
            this.guna2TextBox2 = new Guna.UI2.WinForms.Guna2TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btProfile = new Guna.UI2.WinForms.Guna2Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panelMenu = new System.Windows.Forms.Panel();
            this.btDashboard = new Guna.UI2.WinForms.Guna2Button();
            this.btSignOut = new Guna.UI2.WinForms.Guna2Button();
            this.btAccount = new Guna.UI2.WinForms.Guna2Button();
            this.panelOption = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.BtInCard = new Guna.UI2.WinForms.Guna2Button();
            this.panelCategory = new System.Windows.Forms.Panel();
            this.guna2CheckBox3 = new Guna.UI2.WinForms.Guna2CheckBox();
            this.guna2CheckBox2 = new Guna.UI2.WinForms.Guna2CheckBox();
            this.guna2CheckBox1 = new Guna.UI2.WinForms.Guna2CheckBox();
            this.BtCategory = new Guna.UI2.WinForms.Guna2Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.timer3 = new System.Windows.Forms.Timer(this.components);
            this.guna2AnimateWindow1 = new Guna.UI2.WinForms.Guna2AnimateWindow(this.components);
            this.panelComponent = new System.Windows.Forms.Panel();
            this.panelInCard = new System.Windows.Forms.Panel();
            this.BtCheckOut = new Guna.UI2.WinForms.Guna2Button();
            this.lbTotal = new System.Windows.Forms.Label();
            this.lbSubTotal = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dataGridViewProduct = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.panel5.SuspendLayout();
            this.panelMenu.SuspendLayout();
            this.panelOption.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panelCategory.SuspendLayout();
            this.panelComponent.SuspendLayout();
            this.panelInCard.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProduct)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel5.Controls.Add(this.BtMenu);
            this.panel5.Controls.Add(this.btMinimize);
            this.panel5.Controls.Add(this.btnExit);
            this.panel5.Controls.Add(this.guna2TextBox2);
            this.panel5.Controls.Add(this.label1);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1432, 55);
            this.panel5.TabIndex = 8;
            // 
            // BtMenu
            // 
            this.BtMenu.BorderRadius = 6;
            this.BtMenu.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BtMenu.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BtMenu.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BtMenu.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BtMenu.FillColor = System.Drawing.Color.Transparent;
            this.BtMenu.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.BtMenu.ForeColor = System.Drawing.Color.DimGray;
            this.BtMenu.Image = ((System.Drawing.Image)(resources.GetObject("BtMenu.Image")));
            this.BtMenu.ImageSize = new System.Drawing.Size(24, 24);
            this.BtMenu.Location = new System.Drawing.Point(12, 9);
            this.BtMenu.Name = "BtMenu";
            this.BtMenu.Size = new System.Drawing.Size(38, 30);
            this.BtMenu.TabIndex = 4;
            this.BtMenu.Click += new System.EventHandler(this.BtMenu_Click);
            // 
            // btMinimize
            // 
            this.btMinimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btMinimize.BorderRadius = 6;
            this.btMinimize.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btMinimize.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btMinimize.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btMinimize.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btMinimize.FillColor = System.Drawing.Color.Transparent;
            this.btMinimize.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btMinimize.ForeColor = System.Drawing.Color.DimGray;
            this.btMinimize.Image = ((System.Drawing.Image)(resources.GetObject("btMinimize.Image")));
            this.btMinimize.ImageSize = new System.Drawing.Size(24, 24);
            this.btMinimize.Location = new System.Drawing.Point(1334, 9);
            this.btMinimize.Name = "btMinimize";
            this.btMinimize.Size = new System.Drawing.Size(38, 30);
            this.btMinimize.TabIndex = 2;
            this.btMinimize.Click += new System.EventHandler(this.btMinimize_Click);
            // 
            // btnExit
            // 
            this.btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExit.BorderRadius = 6;
            this.btnExit.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnExit.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnExit.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnExit.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnExit.FillColor = System.Drawing.Color.Transparent;
            this.btnExit.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnExit.ForeColor = System.Drawing.Color.DimGray;
            this.btnExit.Image = ((System.Drawing.Image)(resources.GetObject("btnExit.Image")));
            this.btnExit.ImageSize = new System.Drawing.Size(24, 24);
            this.btnExit.Location = new System.Drawing.Point(1380, 9);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(38, 30);
            this.btnExit.TabIndex = 1;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // guna2TextBox2
            // 
            this.guna2TextBox2.BorderRadius = 18;
            this.guna2TextBox2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.guna2TextBox2.DefaultText = "";
            this.guna2TextBox2.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.guna2TextBox2.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.guna2TextBox2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox2.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox2.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBox2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2TextBox2.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBox2.IconLeft = ((System.Drawing.Image)(resources.GetObject("guna2TextBox2.IconLeft")));
            this.guna2TextBox2.IconLeftOffset = new System.Drawing.Point(10, 0);
            this.guna2TextBox2.Location = new System.Drawing.Point(294, 9);
            this.guna2TextBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.guna2TextBox2.Name = "guna2TextBox2";
            this.guna2TextBox2.PasswordChar = '\0';
            this.guna2TextBox2.PlaceholderText = "Search...";
            this.guna2TextBox2.SelectedText = "";
            this.guna2TextBox2.Size = new System.Drawing.Size(360, 39);
            this.guna2TextBox2.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(91, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "V-SHOP";
            // 
            // btProfile
            // 
            this.btProfile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btProfile.BorderColor = System.Drawing.Color.White;
            this.btProfile.BorderRadius = 12;
            this.btProfile.BorderThickness = 1;
            this.btProfile.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btProfile.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btProfile.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btProfile.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btProfile.FillColor = System.Drawing.Color.Transparent;
            this.btProfile.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btProfile.ForeColor = System.Drawing.Color.DimGray;
            this.btProfile.HoverState.BorderColor = System.Drawing.Color.Fuchsia;
            this.btProfile.HoverState.CustomBorderColor = System.Drawing.Color.Fuchsia;
            this.btProfile.HoverState.FillColor = System.Drawing.Color.Fuchsia;
            this.btProfile.Image = ((System.Drawing.Image)(resources.GetObject("btProfile.Image")));
            this.btProfile.ImageSize = new System.Drawing.Size(36, 36);
            this.btProfile.Location = new System.Drawing.Point(2, 3);
            this.btProfile.Name = "btProfile";
            this.btProfile.Size = new System.Drawing.Size(194, 60);
            this.btProfile.TabIndex = 4;
            this.btProfile.Click += new System.EventHandler(this.btProfile_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.Transparent;
            this.panelMenu.Controls.Add(this.btDashboard);
            this.panelMenu.Controls.Add(this.btProfile);
            this.panelMenu.Controls.Add(this.btSignOut);
            this.panelMenu.Controls.Add(this.btAccount);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.MaximumSize = new System.Drawing.Size(200, 230);
            this.panelMenu.MinimumSize = new System.Drawing.Size(200, 63);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(200, 63);
            this.panelMenu.TabIndex = 3;
            // 
            // btDashboard
            // 
            this.btDashboard.BackColor = System.Drawing.Color.Transparent;
            this.btDashboard.BorderColor = System.Drawing.Color.White;
            this.btDashboard.BorderRadius = 12;
            this.btDashboard.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btDashboard.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btDashboard.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btDashboard.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btDashboard.FillColor = System.Drawing.Color.Transparent;
            this.btDashboard.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btDashboard.ForeColor = System.Drawing.Color.White;
            this.btDashboard.HoverState.BorderColor = System.Drawing.Color.DeepSkyBlue;
            this.btDashboard.HoverState.CustomBorderColor = System.Drawing.Color.DeepSkyBlue;
            this.btDashboard.HoverState.FillColor = System.Drawing.Color.DeepSkyBlue;
            this.btDashboard.Location = new System.Drawing.Point(3, 174);
            this.btDashboard.Name = "btDashboard";
            this.btDashboard.Size = new System.Drawing.Size(194, 53);
            this.btDashboard.TabIndex = 2;
            this.btDashboard.Text = "Dashboard";
            this.btDashboard.Click += new System.EventHandler(this.btDashboard_Click);
            // 
            // btSignOut
            // 
            this.btSignOut.BorderColor = System.Drawing.Color.White;
            this.btSignOut.BorderRadius = 12;
            this.btSignOut.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btSignOut.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btSignOut.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btSignOut.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btSignOut.FillColor = System.Drawing.Color.Transparent;
            this.btSignOut.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSignOut.ForeColor = System.Drawing.Color.White;
            this.btSignOut.HoverState.BorderColor = System.Drawing.Color.DeepSkyBlue;
            this.btSignOut.HoverState.CustomBorderColor = System.Drawing.Color.DeepSkyBlue;
            this.btSignOut.HoverState.FillColor = System.Drawing.Color.DeepSkyBlue;
            this.btSignOut.Location = new System.Drawing.Point(3, 120);
            this.btSignOut.Name = "btSignOut";
            this.btSignOut.Size = new System.Drawing.Size(194, 53);
            this.btSignOut.TabIndex = 1;
            this.btSignOut.Text = "Sign Out";
            this.btSignOut.Click += new System.EventHandler(this.btSignOut_Click);
            // 
            // btAccount
            // 
            this.btAccount.BorderColor = System.Drawing.Color.White;
            this.btAccount.BorderRadius = 12;
            this.btAccount.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btAccount.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btAccount.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btAccount.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btAccount.FillColor = System.Drawing.Color.Transparent;
            this.btAccount.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAccount.ForeColor = System.Drawing.Color.White;
            this.btAccount.HoverState.BorderColor = System.Drawing.Color.DeepSkyBlue;
            this.btAccount.HoverState.CustomBorderColor = System.Drawing.Color.DeepSkyBlue;
            this.btAccount.HoverState.FillColor = System.Drawing.Color.DeepSkyBlue;
            this.btAccount.Location = new System.Drawing.Point(3, 66);
            this.btAccount.Name = "btAccount";
            this.btAccount.Size = new System.Drawing.Size(194, 53);
            this.btAccount.TabIndex = 0;
            this.btAccount.Text = "Account";
            this.btAccount.Click += new System.EventHandler(this.btAccount_Click);
            // 
            // panelOption
            // 
            this.panelOption.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panelOption.Controls.Add(this.panel4);
            this.panelOption.Controls.Add(this.panelCategory);
            this.panelOption.Controls.Add(this.panelMenu);
            this.panelOption.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelOption.Location = new System.Drawing.Point(0, 55);
            this.panelOption.MaximumSize = new System.Drawing.Size(200, 850);
            this.panelOption.Name = "panelOption";
            this.panelOption.Size = new System.Drawing.Size(200, 748);
            this.panelOption.TabIndex = 9;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.BtInCard);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 126);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(200, 63);
            this.panel4.TabIndex = 5;
            // 
            // BtInCard
            // 
            this.BtInCard.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtInCard.BorderColor = System.Drawing.Color.White;
            this.BtInCard.BorderRadius = 12;
            this.BtInCard.BorderThickness = 1;
            this.BtInCard.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BtInCard.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BtInCard.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BtInCard.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BtInCard.FillColor = System.Drawing.Color.Transparent;
            this.BtInCard.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtInCard.ForeColor = System.Drawing.Color.White;
            this.BtInCard.HoverState.BorderColor = System.Drawing.Color.Fuchsia;
            this.BtInCard.HoverState.CustomBorderColor = System.Drawing.Color.Fuchsia;
            this.BtInCard.HoverState.FillColor = System.Drawing.Color.Fuchsia;
            this.BtInCard.ImageSize = new System.Drawing.Size(36, 36);
            this.BtInCard.Location = new System.Drawing.Point(2, 4);
            this.BtInCard.Name = "BtInCard";
            this.BtInCard.Size = new System.Drawing.Size(194, 55);
            this.BtInCard.TabIndex = 6;
            this.BtInCard.Text = "In Card";
            this.BtInCard.Click += new System.EventHandler(this.BtInCard_Click);
            // 
            // panelCategory
            // 
            this.panelCategory.BackColor = System.Drawing.Color.Transparent;
            this.panelCategory.Controls.Add(this.guna2CheckBox3);
            this.panelCategory.Controls.Add(this.guna2CheckBox2);
            this.panelCategory.Controls.Add(this.guna2CheckBox1);
            this.panelCategory.Controls.Add(this.BtCategory);
            this.panelCategory.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelCategory.Location = new System.Drawing.Point(0, 63);
            this.panelCategory.MaximumSize = new System.Drawing.Size(200, 179);
            this.panelCategory.MinimumSize = new System.Drawing.Size(200, 63);
            this.panelCategory.Name = "panelCategory";
            this.panelCategory.Size = new System.Drawing.Size(200, 63);
            this.panelCategory.TabIndex = 4;
            // 
            // guna2CheckBox3
            // 
            this.guna2CheckBox3.AutoSize = true;
            this.guna2CheckBox3.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2CheckBox3.CheckedState.BorderRadius = 0;
            this.guna2CheckBox3.CheckedState.BorderThickness = 0;
            this.guna2CheckBox3.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2CheckBox3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2CheckBox3.ForeColor = System.Drawing.Color.White;
            this.guna2CheckBox3.Location = new System.Drawing.Point(12, 103);
            this.guna2CheckBox3.Name = "guna2CheckBox3";
            this.guna2CheckBox3.Size = new System.Drawing.Size(182, 32);
            this.guna2CheckBox3.TabIndex = 8;
            this.guna2CheckBox3.Text = "Electronic Device";
            this.guna2CheckBox3.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.guna2CheckBox3.UncheckedState.BorderRadius = 0;
            this.guna2CheckBox3.UncheckedState.BorderThickness = 0;
            this.guna2CheckBox3.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            // 
            // guna2CheckBox2
            // 
            this.guna2CheckBox2.AutoSize = true;
            this.guna2CheckBox2.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2CheckBox2.CheckedState.BorderRadius = 0;
            this.guna2CheckBox2.CheckedState.BorderThickness = 0;
            this.guna2CheckBox2.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2CheckBox2.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.guna2CheckBox2.ForeColor = System.Drawing.Color.White;
            this.guna2CheckBox2.Location = new System.Drawing.Point(12, 141);
            this.guna2CheckBox2.Name = "guna2CheckBox2";
            this.guna2CheckBox2.Size = new System.Drawing.Size(109, 32);
            this.guna2CheckBox2.TabIndex = 7;
            this.guna2CheckBox2.Text = "Clothing";
            this.guna2CheckBox2.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.guna2CheckBox2.UncheckedState.BorderRadius = 0;
            this.guna2CheckBox2.UncheckedState.BorderThickness = 0;
            this.guna2CheckBox2.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            // 
            // guna2CheckBox1
            // 
            this.guna2CheckBox1.AutoSize = true;
            this.guna2CheckBox1.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2CheckBox1.CheckedState.BorderRadius = 0;
            this.guna2CheckBox1.CheckedState.BorderThickness = 0;
            this.guna2CheckBox1.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2CheckBox1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2CheckBox1.ForeColor = System.Drawing.Color.White;
            this.guna2CheckBox1.Location = new System.Drawing.Point(12, 65);
            this.guna2CheckBox1.Name = "guna2CheckBox1";
            this.guna2CheckBox1.Size = new System.Drawing.Size(109, 32);
            this.guna2CheckBox1.TabIndex = 6;
            this.guna2CheckBox1.Text = "Drinking";
            this.guna2CheckBox1.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.guna2CheckBox1.UncheckedState.BorderRadius = 0;
            this.guna2CheckBox1.UncheckedState.BorderThickness = 0;
            this.guna2CheckBox1.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            // 
            // BtCategory
            // 
            this.BtCategory.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtCategory.BorderColor = System.Drawing.Color.White;
            this.BtCategory.BorderRadius = 12;
            this.BtCategory.BorderThickness = 1;
            this.BtCategory.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BtCategory.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BtCategory.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BtCategory.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BtCategory.FillColor = System.Drawing.Color.Transparent;
            this.BtCategory.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtCategory.ForeColor = System.Drawing.Color.White;
            this.BtCategory.HoverState.BorderColor = System.Drawing.Color.Fuchsia;
            this.BtCategory.HoverState.CustomBorderColor = System.Drawing.Color.Fuchsia;
            this.BtCategory.HoverState.FillColor = System.Drawing.Color.Fuchsia;
            this.BtCategory.ImageSize = new System.Drawing.Size(36, 36);
            this.BtCategory.Location = new System.Drawing.Point(2, 4);
            this.BtCategory.Name = "BtCategory";
            this.BtCategory.Size = new System.Drawing.Size(194, 55);
            this.BtCategory.TabIndex = 5;
            this.BtCategory.Text = "Categories";
            this.BtCategory.Click += new System.EventHandler(this.BtCategory_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 243);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Padding = new System.Windows.Forms.Padding(40, 0, 0, 0);
            this.flowLayoutPanel1.Size = new System.Drawing.Size(27, 381);
            this.flowLayoutPanel1.TabIndex = 12;
            // 
            // timer2
            // 
            this.timer2.Interval = 1;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // timer3
            // 
            this.timer3.Interval = 1;
            this.timer3.Tick += new System.EventHandler(this.timer3_Tick);
            // 
            // panelComponent
            // 
            this.panelComponent.Controls.Add(this.flowLayoutPanel1);
            this.panelComponent.Controls.Add(this.panelInCard);
            this.panelComponent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelComponent.Location = new System.Drawing.Point(200, 55);
            this.panelComponent.Name = "panelComponent";
            this.panelComponent.Size = new System.Drawing.Size(1232, 748);
            this.panelComponent.TabIndex = 13;
            // 
            // panelInCard
            // 
            this.panelInCard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panelInCard.Controls.Add(this.BtCheckOut);
            this.panelInCard.Controls.Add(this.lbTotal);
            this.panelInCard.Controls.Add(this.lbSubTotal);
            this.panelInCard.Controls.Add(this.label6);
            this.panelInCard.Controls.Add(this.label5);
            this.panelInCard.Controls.Add(this.label4);
            this.panelInCard.Controls.Add(this.panel2);
            this.panelInCard.Location = new System.Drawing.Point(36, 0);
            this.panelInCard.Name = "panelInCard";
            this.panelInCard.Size = new System.Drawing.Size(1196, 748);
            this.panelInCard.TabIndex = 0;
            // 
            // BtCheckOut
            // 
            this.BtCheckOut.BorderRadius = 8;
            this.BtCheckOut.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BtCheckOut.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BtCheckOut.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BtCheckOut.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BtCheckOut.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtCheckOut.ForeColor = System.Drawing.Color.White;
            this.BtCheckOut.Location = new System.Drawing.Point(948, 313);
            this.BtCheckOut.Name = "BtCheckOut";
            this.BtCheckOut.Size = new System.Drawing.Size(133, 45);
            this.BtCheckOut.TabIndex = 10;
            this.BtCheckOut.Text = "Checkout";
            this.BtCheckOut.Click += new System.EventHandler(this.BtCheckOut_Click);
            // 
            // lbTotal
            // 
            this.lbTotal.AutoSize = true;
            this.lbTotal.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTotal.ForeColor = System.Drawing.Color.White;
            this.lbTotal.Location = new System.Drawing.Point(1018, 204);
            this.lbTotal.Name = "lbTotal";
            this.lbTotal.Size = new System.Drawing.Size(118, 31);
            this.lbTotal.TabIndex = 7;
            this.lbTotal.Text = "total price";
            // 
            // lbSubTotal
            // 
            this.lbSubTotal.AutoSize = true;
            this.lbSubTotal.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSubTotal.ForeColor = System.Drawing.Color.White;
            this.lbSubTotal.Location = new System.Drawing.Point(1018, 126);
            this.lbSubTotal.Name = "lbSubTotal";
            this.lbSubTotal.Size = new System.Drawing.Size(157, 31);
            this.lbSubTotal.TabIndex = 6;
            this.lbSubTotal.Text = "Subtotal price";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(909, 204);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 31);
            this.label6.TabIndex = 5;
            this.label6.Text = "Total:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(941, 20);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(138, 38);
            this.label5.TabIndex = 4;
            this.label5.Text = "Summary";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(909, 126);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 31);
            this.label4.TabIndex = 4;
            this.label4.Text = "Subtotal:";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dataGridViewProduct);
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(826, 748);
            this.panel2.TabIndex = 1;
            // 
            // dataGridViewProduct
            // 
            this.dataGridViewProduct.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dataGridViewProduct.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewProduct.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGridViewProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewProduct.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Description});
            this.dataGridViewProduct.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewProduct.Location = new System.Drawing.Point(0, 81);
            this.dataGridViewProduct.Name = "dataGridViewProduct";
            this.dataGridViewProduct.RowHeadersWidth = 51;
            this.dataGridViewProduct.RowTemplate.Height = 24;
            this.dataGridViewProduct.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewProduct.Size = new System.Drawing.Size(826, 667);
            this.dataGridViewProduct.TabIndex = 2;
            this.dataGridViewProduct.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewProduct_CellClick);
            this.dataGridViewProduct.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewProduct_CellValueChanged);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Product ID";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.Width = 150;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Name";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.Width = 150;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Price";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.Width = 125;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Qty";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.Width = 125;
            // 
            // Description
            // 
            this.Description.DataPropertyName = "Description";
            this.Description.HeaderText = "Description";
            this.Description.MinimumWidth = 6;
            this.Description.Name = "Description";
            this.Description.Width = 200;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(826, 81);
            this.panel1.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(397, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(141, 38);
            this.label3.TabIndex = 3;
            this.label3.Text = "Your Card";
            // 
            // MainForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1432, 803);
            this.Controls.Add(this.panelComponent);
            this.Controls.Add(this.panelOption);
            this.Controls.Add(this.panel5);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panelMenu.ResumeLayout(false);
            this.panelOption.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panelCategory.ResumeLayout(false);
            this.panelCategory.PerformLayout();
            this.panelComponent.ResumeLayout(false);
            this.panelInCard.ResumeLayout(false);
            this.panelInCard.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProduct)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel5;
        private Guna.UI2.WinForms.Guna2Button btMinimize;
        private Guna.UI2.WinForms.Guna2Button btnExit;
        private Guna.UI2.WinForms.Guna2TextBox guna2TextBox2;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Button btProfile;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel panelMenu;
        private Guna.UI2.WinForms.Guna2Button btDashboard;
        private Guna.UI2.WinForms.Guna2Button btSignOut;
        private Guna.UI2.WinForms.Guna2Button btAccount;
        private System.Windows.Forms.Panel panelOption;
        private Guna.UI2.WinForms.Guna2Button BtMenu;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Panel panelCategory;
        private Guna.UI2.WinForms.Guna2Button BtCategory;
        private Guna.UI2.WinForms.Guna2CheckBox guna2CheckBox1;
        private Guna.UI2.WinForms.Guna2CheckBox guna2CheckBox3;
        private Guna.UI2.WinForms.Guna2CheckBox guna2CheckBox2;
        private System.Windows.Forms.Timer timer3;
        private Guna.UI2.WinForms.Guna2AnimateWindow guna2AnimateWindow1;
        private System.Windows.Forms.Panel panel4;
        private Guna.UI2.WinForms.Guna2Button BtInCard;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel panelComponent;
        private System.Windows.Forms.Panel panelInCard;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dataGridViewProduct;
        private System.Windows.Forms.Label lbTotal;
        private System.Windows.Forms.Label lbSubTotal;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2Button BtCheckOut;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Description;
    }
}