namespace V_Shop.Presentation
{
    partial class AdminForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btCutomer = new Guna.UI2.WinForms.Guna2Button();
            this.btDashboard = new Guna.UI2.WinForms.Guna2Button();
            this.btAnalytics = new Guna.UI2.WinForms.Guna2Button();
            this.btProduct = new Guna.UI2.WinForms.Guna2Button();
            this.btOrder = new Guna.UI2.WinForms.Guna2Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btBack = new Guna.UI2.WinForms.Guna2Button();
            this.btMinimize = new Guna.UI2.WinForms.Guna2Button();
            this.btnExit = new Guna.UI2.WinForms.Guna2Button();
            this.guna2TextBox2 = new Guna.UI2.WinForms.Guna2TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.PanelComponemt = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btCutomer);
            this.panel1.Controls.Add(this.btDashboard);
            this.panel1.Controls.Add(this.btAnalytics);
            this.panel1.Controls.Add(this.btProduct);
            this.panel1.Controls.Add(this.btOrder);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 84);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(222, 719);
            this.panel1.TabIndex = 7;
            // 
            // btCutomer
            // 
            this.btCutomer.BorderRadius = 10;
            this.btCutomer.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btCutomer.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btCutomer.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btCutomer.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btCutomer.FillColor = System.Drawing.SystemColors.Control;
            this.btCutomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCutomer.ForeColor = System.Drawing.Color.Black;
            this.btCutomer.HoverState.BorderColor = System.Drawing.Color.Yellow;
            this.btCutomer.HoverState.CustomBorderColor = System.Drawing.Color.Yellow;
            this.btCutomer.HoverState.FillColor = System.Drawing.Color.Yellow;
            this.btCutomer.Image = ((System.Drawing.Image)(resources.GetObject("btCutomer.Image")));
            this.btCutomer.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btCutomer.ImageOffset = new System.Drawing.Point(12, 0);
            this.btCutomer.ImageSize = new System.Drawing.Size(36, 36);
            this.btCutomer.Location = new System.Drawing.Point(2, 154);
            this.btCutomer.Name = "btCutomer";
            this.btCutomer.Size = new System.Drawing.Size(201, 71);
            this.btCutomer.TabIndex = 7;
            this.btCutomer.Text = "Customers";
            this.btCutomer.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btCutomer.TextOffset = new System.Drawing.Point(14, 0);
            this.btCutomer.Click += new System.EventHandler(this.btCutomer_Click);
            // 
            // btDashboard
            // 
            this.btDashboard.BorderRadius = 10;
            this.btDashboard.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btDashboard.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btDashboard.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btDashboard.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btDashboard.FillColor = System.Drawing.SystemColors.Control;
            this.btDashboard.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btDashboard.ForeColor = System.Drawing.Color.Black;
            this.btDashboard.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btDashboard.HoverState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btDashboard.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btDashboard.Image = ((System.Drawing.Image)(resources.GetObject("btDashboard.Image")));
            this.btDashboard.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btDashboard.ImageOffset = new System.Drawing.Point(12, 0);
            this.btDashboard.ImageSize = new System.Drawing.Size(36, 36);
            this.btDashboard.Location = new System.Drawing.Point(3, 6);
            this.btDashboard.Name = "btDashboard";
            this.btDashboard.Size = new System.Drawing.Size(201, 71);
            this.btDashboard.TabIndex = 6;
            this.btDashboard.Text = "Dashboard";
            this.btDashboard.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btDashboard.TextOffset = new System.Drawing.Point(14, 0);
            this.btDashboard.Click += new System.EventHandler(this.btDashboard_Click);
            // 
            // btAnalytics
            // 
            this.btAnalytics.BorderRadius = 10;
            this.btAnalytics.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btAnalytics.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btAnalytics.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btAnalytics.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btAnalytics.FillColor = System.Drawing.SystemColors.Control;
            this.btAnalytics.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAnalytics.ForeColor = System.Drawing.Color.Black;
            this.btAnalytics.HoverState.BorderColor = System.Drawing.Color.Fuchsia;
            this.btAnalytics.HoverState.CustomBorderColor = System.Drawing.Color.Fuchsia;
            this.btAnalytics.HoverState.FillColor = System.Drawing.Color.Fuchsia;
            this.btAnalytics.Image = ((System.Drawing.Image)(resources.GetObject("btAnalytics.Image")));
            this.btAnalytics.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btAnalytics.ImageOffset = new System.Drawing.Point(12, 0);
            this.btAnalytics.ImageSize = new System.Drawing.Size(36, 36);
            this.btAnalytics.Location = new System.Drawing.Point(3, 302);
            this.btAnalytics.Name = "btAnalytics";
            this.btAnalytics.Size = new System.Drawing.Size(201, 71);
            this.btAnalytics.TabIndex = 5;
            this.btAnalytics.Text = "Analytics";
            this.btAnalytics.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btAnalytics.TextOffset = new System.Drawing.Point(14, 0);
            this.btAnalytics.Click += new System.EventHandler(this.btAnalytics_Click);
            // 
            // btProduct
            // 
            this.btProduct.BorderRadius = 10;
            this.btProduct.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btProduct.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btProduct.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btProduct.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btProduct.FillColor = System.Drawing.SystemColors.Control;
            this.btProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btProduct.ForeColor = System.Drawing.Color.Black;
            this.btProduct.HoverState.BorderColor = System.Drawing.Color.Cyan;
            this.btProduct.HoverState.CustomBorderColor = System.Drawing.Color.Cyan;
            this.btProduct.HoverState.FillColor = System.Drawing.Color.Cyan;
            this.btProduct.Image = ((System.Drawing.Image)(resources.GetObject("btProduct.Image")));
            this.btProduct.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btProduct.ImageOffset = new System.Drawing.Point(12, 0);
            this.btProduct.ImageSize = new System.Drawing.Size(36, 36);
            this.btProduct.Location = new System.Drawing.Point(3, 228);
            this.btProduct.Name = "btProduct";
            this.btProduct.Size = new System.Drawing.Size(201, 71);
            this.btProduct.TabIndex = 4;
            this.btProduct.Text = "Products";
            this.btProduct.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btProduct.TextOffset = new System.Drawing.Point(14, 0);
            this.btProduct.Click += new System.EventHandler(this.btProduct_Click);
            // 
            // btOrder
            // 
            this.btOrder.BorderRadius = 10;
            this.btOrder.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btOrder.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btOrder.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btOrder.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btOrder.FillColor = System.Drawing.SystemColors.Control;
            this.btOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btOrder.ForeColor = System.Drawing.Color.Black;
            this.btOrder.HoverState.BorderColor = System.Drawing.Color.Lime;
            this.btOrder.HoverState.CustomBorderColor = System.Drawing.Color.Lime;
            this.btOrder.HoverState.FillColor = System.Drawing.Color.Lime;
            this.btOrder.Image = ((System.Drawing.Image)(resources.GetObject("btOrder.Image")));
            this.btOrder.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btOrder.ImageOffset = new System.Drawing.Point(12, 0);
            this.btOrder.ImageSize = new System.Drawing.Size(36, 36);
            this.btOrder.Location = new System.Drawing.Point(3, 80);
            this.btOrder.Name = "btOrder";
            this.btOrder.Size = new System.Drawing.Size(201, 71);
            this.btOrder.TabIndex = 2;
            this.btOrder.Text = "Orders";
            this.btOrder.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btOrder.TextOffset = new System.Drawing.Point(14, 0);
            this.btOrder.Click += new System.EventHandler(this.btOrder_Click);
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.btBack);
            this.panel5.Controls.Add(this.btMinimize);
            this.panel5.Controls.Add(this.btnExit);
            this.panel5.Controls.Add(this.guna2TextBox2);
            this.panel5.Controls.Add(this.label1);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1432, 84);
            this.panel5.TabIndex = 6;
            // 
            // btBack
            // 
            this.btBack.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btBack.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btBack.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btBack.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btBack.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btBack.FillColor = System.Drawing.SystemColors.Control;
            this.btBack.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btBack.ForeColor = System.Drawing.Color.DimGray;
            this.btBack.Image = ((System.Drawing.Image)(resources.GetObject("btBack.Image")));
            this.btBack.ImageSize = new System.Drawing.Size(24, 24);
            this.btBack.Location = new System.Drawing.Point(1237, 9);
            this.btBack.Name = "btBack";
            this.btBack.Size = new System.Drawing.Size(57, 40);
            this.btBack.TabIndex = 4;
            this.btBack.Click += new System.EventHandler(this.btBack_Click);
            // 
            // btMinimize
            // 
            this.btMinimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btMinimize.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btMinimize.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btMinimize.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btMinimize.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btMinimize.FillColor = System.Drawing.SystemColors.Control;
            this.btMinimize.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btMinimize.ForeColor = System.Drawing.Color.DimGray;
            this.btMinimize.Image = ((System.Drawing.Image)(resources.GetObject("btMinimize.Image")));
            this.btMinimize.ImageSize = new System.Drawing.Size(24, 24);
            this.btMinimize.Location = new System.Drawing.Point(1300, 9);
            this.btMinimize.Name = "btMinimize";
            this.btMinimize.Size = new System.Drawing.Size(57, 40);
            this.btMinimize.TabIndex = 2;
            this.btMinimize.Click += new System.EventHandler(this.btMinimize_Click);
            // 
            // btnExit
            // 
            this.btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExit.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnExit.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnExit.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnExit.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnExit.FillColor = System.Drawing.SystemColors.Control;
            this.btnExit.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnExit.ForeColor = System.Drawing.Color.DimGray;
            this.btnExit.Image = ((System.Drawing.Image)(resources.GetObject("btnExit.Image")));
            this.btnExit.ImageSize = new System.Drawing.Size(24, 24);
            this.btnExit.Location = new System.Drawing.Point(1363, 9);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(57, 40);
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
            this.guna2TextBox2.Location = new System.Drawing.Point(303, 13);
            this.guna2TextBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.guna2TextBox2.Name = "guna2TextBox2";
            this.guna2TextBox2.PasswordChar = '\0';
            this.guna2TextBox2.PlaceholderText = "Search...";
            this.guna2TextBox2.SelectedText = "";
            this.guna2TextBox2.Size = new System.Drawing.Size(360, 40);
            this.guna2TextBox2.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(83, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "V-SHOP";
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(1412, 84);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(20, 719);
            this.panel2.TabIndex = 8;
            // 
            // panel3
            // 
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(222, 786);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1190, 17);
            this.panel3.TabIndex = 9;
            // 
            // PanelComponemt
            // 
            this.PanelComponemt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelComponemt.Location = new System.Drawing.Point(222, 84);
            this.PanelComponemt.Name = "PanelComponemt";
            this.PanelComponemt.Size = new System.Drawing.Size(1190, 702);
            this.PanelComponemt.TabIndex = 10;
            // 
            // AdminForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1432, 803);
            this.Controls.Add(this.PanelComponemt);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel5);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AdminForm";
            this.Text = "AdminForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.AdminForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2Button btAnalytics;
        private Guna.UI2.WinForms.Guna2Button btProduct;
        private Guna.UI2.WinForms.Guna2Button btOrder;
        private System.Windows.Forms.Panel panel5;
        private Guna.UI2.WinForms.Guna2Button btMinimize;
        private Guna.UI2.WinForms.Guna2Button btnExit;
        private Guna.UI2.WinForms.Guna2TextBox guna2TextBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private Guna.UI2.WinForms.Guna2Button btDashboard;
        private Guna.UI2.WinForms.Guna2Button btCutomer;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel PanelComponemt;
        private Guna.UI2.WinForms.Guna2Button btBack;
    }
}