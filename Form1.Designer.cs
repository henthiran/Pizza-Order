namespace Pizza
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.cmdDiscount = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdlarge = new System.Windows.Forms.RadioButton();
            this.rdmedium = new System.Windows.Forms.RadioButton();
            this.rdsmall = new System.Windows.Forms.RadioButton();
            this.lblunitprice = new System.Windows.Forms.Label();
            this.textUnitprice = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textPay = new System.Windows.Forms.TextBox();
            this.textTD = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnCalculateAmount = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(144, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Quantity";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(144, 62);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Discount";
            // 
            // txtQuantity
            // 
            this.txtQuantity.Location = new System.Drawing.Point(279, 2);
            this.txtQuantity.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(159, 20);
            this.txtQuantity.TabIndex = 3;
            // 
            // cmdDiscount
            // 
            this.cmdDiscount.FormattingEnabled = true;
            this.cmdDiscount.Items.AddRange(new object[] {
            "10",
            "20",
            "30"});
            this.cmdDiscount.Location = new System.Drawing.Point(279, 59);
            this.cmdDiscount.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cmdDiscount.Name = "cmdDiscount";
            this.cmdDiscount.Size = new System.Drawing.Size(159, 21);
            this.cmdDiscount.TabIndex = 4;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdlarge);
            this.groupBox1.Controls.Add(this.rdmedium);
            this.groupBox1.Controls.Add(this.rdsmall);
            this.groupBox1.Location = new System.Drawing.Point(147, 115);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox1.Size = new System.Drawing.Size(174, 135);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Size";
            // 
            // rdlarge
            // 
            this.rdlarge.AutoSize = true;
            this.rdlarge.Location = new System.Drawing.Point(40, 101);
            this.rdlarge.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.rdlarge.Name = "rdlarge";
            this.rdlarge.Size = new System.Drawing.Size(57, 17);
            this.rdlarge.TabIndex = 2;
            this.rdlarge.TabStop = true;
            this.rdlarge.Text = "Large";
            this.rdlarge.UseVisualStyleBackColor = true;
            this.rdlarge.CheckedChanged += new System.EventHandler(this.rdlarge_CheckedChanged);
            // 
            // rdmedium
            // 
            this.rdmedium.AutoSize = true;
            this.rdmedium.Location = new System.Drawing.Point(40, 62);
            this.rdmedium.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.rdmedium.Name = "rdmedium";
            this.rdmedium.Size = new System.Drawing.Size(68, 17);
            this.rdmedium.TabIndex = 1;
            this.rdmedium.TabStop = true;
            this.rdmedium.Text = "Medium";
            this.rdmedium.UseVisualStyleBackColor = true;
            this.rdmedium.CheckedChanged += new System.EventHandler(this.rdmedium_CheckedChanged);
            // 
            // rdsmall
            // 
            this.rdsmall.AutoSize = true;
            this.rdsmall.Location = new System.Drawing.Point(40, 20);
            this.rdsmall.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.rdsmall.Name = "rdsmall";
            this.rdsmall.Size = new System.Drawing.Size(55, 17);
            this.rdsmall.TabIndex = 0;
            this.rdsmall.TabStop = true;
            this.rdsmall.Text = "Small";
            this.rdsmall.UseVisualStyleBackColor = true;
            this.rdsmall.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // lblunitprice
            // 
            this.lblunitprice.AutoSize = true;
            this.lblunitprice.Location = new System.Drawing.Point(144, 292);
            this.lblunitprice.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblunitprice.Name = "lblunitprice";
            this.lblunitprice.Size = new System.Drawing.Size(63, 13);
            this.lblunitprice.TabIndex = 6;
            this.lblunitprice.Text = "Unit Price";
            this.lblunitprice.Click += new System.EventHandler(this.label3_Click);
            // 
            // textUnitprice
            // 
            this.textUnitprice.Location = new System.Drawing.Point(279, 289);
            this.textUnitprice.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textUnitprice.Name = "textUnitprice";
            this.textUnitprice.Size = new System.Drawing.Size(159, 20);
            this.textUnitprice.TabIndex = 7;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textPay);
            this.groupBox2.Controls.Add(this.textTD);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(147, 346);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox2.Size = new System.Drawing.Size(440, 100);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Amount to Pay";
            // 
            // textPay
            // 
            this.textPay.Location = new System.Drawing.Point(132, 56);
            this.textPay.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textPay.Name = "textPay";
            this.textPay.Size = new System.Drawing.Size(116, 20);
            this.textPay.TabIndex = 3;
            // 
            // textTD
            // 
            this.textTD.Location = new System.Drawing.Point(132, 21);
            this.textTD.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textTD.Name = "textTD";
            this.textTD.Size = new System.Drawing.Size(116, 20);
            this.textTD.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 63);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Amount to Pay";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 29);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Total Discount";
            // 
            // btnCalculateAmount
            // 
            this.btnCalculateAmount.Location = new System.Drawing.Point(147, 479);
            this.btnCalculateAmount.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnCalculateAmount.Name = "btnCalculateAmount";
            this.btnCalculateAmount.Size = new System.Drawing.Size(145, 32);
            this.btnCalculateAmount.TabIndex = 9;
            this.btnCalculateAmount.Text = "Calculate Amount";
            this.btnCalculateAmount.UseVisualStyleBackColor = true;
            this.btnCalculateAmount.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(482, 479);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(105, 32);
            this.button2.TabIndex = 10;
            this.button2.Text = "Clear ";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(1020, 534);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnCalculateAmount);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.textUnitprice);
            this.Controls.Add(this.lblunitprice);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.cmdDiscount);
            this.Controls.Add(this.txtQuantity);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Form1";
            this.Text = "PIZZA ORDER";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.ComboBox cmdDiscount;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdlarge;
        private System.Windows.Forms.RadioButton rdmedium;
        private System.Windows.Forms.RadioButton rdsmall;
        private System.Windows.Forms.Label lblunitprice;
        private System.Windows.Forms.TextBox textUnitprice;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox textPay;
        private System.Windows.Forms.TextBox textTD;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnCalculateAmount;
        private System.Windows.Forms.Button button2;
    }
}

