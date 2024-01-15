namespace V_Shop.UI
{
    partial class PaymentForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PaymentForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btContinue = new Guna.UI2.WinForms.Guna2Button();
            this.panelPayWithCashier = new Guna.UI2.WinForms.Guna2Panel();
            this.chBoxDirectPay = new System.Windows.Forms.CheckBox();
            this.panelPayWithCreditCard = new Guna.UI2.WinForms.Guna2Panel();
            this.chBoxPayWithBank = new System.Windows.Forms.CheckBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnExit = new Guna.UI2.WinForms.Guna2Button();
            this.panel1.SuspendLayout();
            this.panelPayWithCashier.SuspendLayout();
            this.panelPayWithCreditCard.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btContinue);
            this.panel1.Controls.Add(this.panelPayWithCashier);
            this.panel1.Controls.Add(this.panelPayWithCreditCard);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(662, 381);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(240, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(183, 31);
            this.label1.TabIndex = 4;
            this.label1.Text = "Payment Option";
            // 
            // btContinue
            // 
            this.btContinue.BorderRadius = 8;
            this.btContinue.BorderThickness = 1;
            this.btContinue.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btContinue.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btContinue.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btContinue.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btContinue.FillColor = System.Drawing.Color.Transparent;
            this.btContinue.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btContinue.ForeColor = System.Drawing.Color.Black;
            this.btContinue.HoverState.BorderColor = System.Drawing.Color.LightSkyBlue;
            this.btContinue.HoverState.CustomBorderColor = System.Drawing.Color.LightSkyBlue;
            this.btContinue.HoverState.FillColor = System.Drawing.Color.LightSkyBlue;
            this.btContinue.Location = new System.Drawing.Point(243, 324);
            this.btContinue.Name = "btContinue";
            this.btContinue.Size = new System.Drawing.Size(180, 45);
            this.btContinue.TabIndex = 3;
            this.btContinue.Text = "Continue";
            this.btContinue.Click += new System.EventHandler(this.btContinue_Click);
            // 
            // panelPayWithCashier
            // 
            this.panelPayWithCashier.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelPayWithCashier.BorderColor = System.Drawing.Color.Black;
            this.panelPayWithCashier.BorderRadius = 10;
            this.panelPayWithCashier.BorderThickness = 1;
            this.panelPayWithCashier.Controls.Add(this.chBoxDirectPay);
            this.panelPayWithCashier.FillColor = System.Drawing.Color.Transparent;
            this.panelPayWithCashier.Location = new System.Drawing.Point(104, 211);
            this.panelPayWithCashier.Name = "panelPayWithCashier";
            this.panelPayWithCashier.Size = new System.Drawing.Size(455, 91);
            this.panelPayWithCashier.TabIndex = 2;
            this.panelPayWithCashier.Click += new System.EventHandler(this.panelPayWithCashier_Click);
            // 
            // chBoxDirectPay
            // 
            this.chBoxDirectPay.AutoSize = true;
            this.chBoxDirectPay.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chBoxDirectPay.Location = new System.Drawing.Point(30, 28);
            this.chBoxDirectPay.Name = "chBoxDirectPay";
            this.chBoxDirectPay.Size = new System.Drawing.Size(193, 35);
            this.chBoxDirectPay.TabIndex = 0;
            this.chBoxDirectPay.Text = "Direct payment";
            this.chBoxDirectPay.UseVisualStyleBackColor = true;
            this.chBoxDirectPay.CheckedChanged += new System.EventHandler(this.chBoxDirectPay_CheckedChanged);
            // 
            // panelPayWithCreditCard
            // 
            this.panelPayWithCreditCard.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelPayWithCreditCard.BorderColor = System.Drawing.Color.Black;
            this.panelPayWithCreditCard.BorderRadius = 10;
            this.panelPayWithCreditCard.BorderThickness = 1;
            this.panelPayWithCreditCard.Controls.Add(this.chBoxPayWithBank);
            this.panelPayWithCreditCard.FillColor = System.Drawing.Color.Transparent;
            this.panelPayWithCreditCard.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelPayWithCreditCard.Location = new System.Drawing.Point(104, 95);
            this.panelPayWithCreditCard.Name = "panelPayWithCreditCard";
            this.panelPayWithCreditCard.Size = new System.Drawing.Size(455, 91);
            this.panelPayWithCreditCard.TabIndex = 1;
            this.panelPayWithCreditCard.Click += new System.EventHandler(this.panelPayWithCreditCard_Click);
            // 
            // chBoxPayWithBank
            // 
            this.chBoxPayWithBank.AutoSize = true;
            this.chBoxPayWithBank.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chBoxPayWithBank.Location = new System.Drawing.Point(30, 29);
            this.chBoxPayWithBank.Name = "chBoxPayWithBank";
            this.chBoxPayWithBank.Size = new System.Drawing.Size(175, 35);
            this.chBoxPayWithBank.TabIndex = 0;
            this.chBoxPayWithBank.Text = "Pay with Card";
            this.chBoxPayWithBank.UseVisualStyleBackColor = true;
            this.chBoxPayWithBank.CheckedChanged += new System.EventHandler(this.chBoxPayWithBank_CheckedChanged);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnExit);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(662, 41);
            this.panel2.TabIndex = 0;
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
            this.btnExit.Location = new System.Drawing.Point(622, 0);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(40, 35);
            this.btnExit.TabIndex = 3;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // PaymentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(662, 381);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PaymentForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PaymentForm";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.PaymentForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panelPayWithCashier.ResumeLayout(false);
            this.panelPayWithCashier.PerformLayout();
            this.panelPayWithCreditCard.ResumeLayout(false);
            this.panelPayWithCreditCard.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private Guna.UI2.WinForms.Guna2Button btnExit;
        private Guna.UI2.WinForms.Guna2Panel panelPayWithCreditCard;
        private Guna.UI2.WinForms.Guna2Panel panelPayWithCashier;
        private Guna.UI2.WinForms.Guna2Button btContinue;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox chBoxDirectPay;
        private System.Windows.Forms.CheckBox chBoxPayWithBank;
    }
}