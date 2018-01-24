namespace CoinsquareBTCalc
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.uxQuantityCAD = new System.Windows.Forms.TextBox();
            this.uxPriceBTC = new System.Windows.Forms.TextBox();
            this.uxBTCquantity = new System.Windows.Forms.TextBox();
            this.uxBTCcurrPrice = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label8 = new System.Windows.Forms.Label();
            this.uxBTCaSale = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.uxQuantityAmount = new System.Windows.Forms.TextBox();
            this.uxPriceBTC2 = new System.Windows.Forms.TextBox();
            this.uxPrice = new System.Windows.Forms.TextBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(404, 183);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.uxQuantityCAD);
            this.tabPage1.Controls.Add(this.uxPriceBTC);
            this.tabPage1.Controls.Add(this.uxBTCquantity);
            this.tabPage1.Controls.Add(this.uxBTCcurrPrice);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(396, 157);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Buy";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(23, 104);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Quantity (CAD):";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(23, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Price (BTC):";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "BTC Quantity to sell:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Target BTC Price:";
            // 
            // uxQuantityCAD
            // 
            this.uxQuantityCAD.Location = new System.Drawing.Point(132, 101);
            this.uxQuantityCAD.Name = "uxQuantityCAD";
            this.uxQuantityCAD.ReadOnly = true;
            this.uxQuantityCAD.Size = new System.Drawing.Size(162, 20);
            this.uxQuantityCAD.TabIndex = 3;
            // 
            // uxPriceBTC
            // 
            this.uxPriceBTC.Location = new System.Drawing.Point(132, 75);
            this.uxPriceBTC.Name = "uxPriceBTC";
            this.uxPriceBTC.ReadOnly = true;
            this.uxPriceBTC.Size = new System.Drawing.Size(162, 20);
            this.uxPriceBTC.TabIndex = 2;
            // 
            // uxBTCquantity
            // 
            this.uxBTCquantity.Location = new System.Drawing.Point(132, 49);
            this.uxBTCquantity.Name = "uxBTCquantity";
            this.uxBTCquantity.Size = new System.Drawing.Size(162, 20);
            this.uxBTCquantity.TabIndex = 1;
            this.uxBTCquantity.Leave += new System.EventHandler(this.uxBTCquantity_Leave);
            // 
            // uxBTCcurrPrice
            // 
            this.uxBTCcurrPrice.Location = new System.Drawing.Point(132, 23);
            this.uxBTCcurrPrice.Name = "uxBTCcurrPrice";
            this.uxBTCcurrPrice.Size = new System.Drawing.Size(162, 20);
            this.uxBTCcurrPrice.TabIndex = 0;
            this.uxBTCcurrPrice.Leave += new System.EventHandler(this.uxBTCcurrPrice_Leave);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.uxBTCaSale);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.uxQuantityAmount);
            this.tabPage2.Controls.Add(this.uxPriceBTC2);
            this.tabPage2.Controls.Add(this.uxPrice);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(396, 157);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Sell";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label8.Location = new System.Drawing.Point(24, 104);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(77, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "BTC after sale:";
            // 
            // uxBTCaSale
            // 
            this.uxBTCaSale.Location = new System.Drawing.Point(132, 101);
            this.uxBTCaSale.Name = "uxBTCaSale";
            this.uxBTCaSale.ReadOnly = true;
            this.uxBTCaSale.Size = new System.Drawing.Size(162, 20);
            this.uxBTCaSale.TabIndex = 3;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.Red;
            this.label7.Location = new System.Drawing.Point(24, 78);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(80, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Quantity (CAD):";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.Red;
            this.label6.Location = new System.Drawing.Point(24, 52);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Price (BTC)";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(24, 26);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Desired Price:";
            // 
            // uxQuantityAmount
            // 
            this.uxQuantityAmount.Location = new System.Drawing.Point(132, 75);
            this.uxQuantityAmount.Name = "uxQuantityAmount";
            this.uxQuantityAmount.Size = new System.Drawing.Size(162, 20);
            this.uxQuantityAmount.TabIndex = 2;
            this.uxQuantityAmount.Leave += new System.EventHandler(this.uxQuantityAmount_Leave);
            // 
            // uxPriceBTC2
            // 
            this.uxPriceBTC2.Location = new System.Drawing.Point(132, 49);
            this.uxPriceBTC2.Name = "uxPriceBTC2";
            this.uxPriceBTC2.ReadOnly = true;
            this.uxPriceBTC2.Size = new System.Drawing.Size(162, 20);
            this.uxPriceBTC2.TabIndex = 1;
            // 
            // uxPrice
            // 
            this.uxPrice.Location = new System.Drawing.Point(132, 23);
            this.uxPrice.Name = "uxPrice";
            this.uxPrice.Size = new System.Drawing.Size(162, 20);
            this.uxPrice.TabIndex = 0;
            this.uxPrice.Leave += new System.EventHandler(this.uxPrice_Leave);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 186);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(403, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(118, 17);
            this.toolStripStatusLabel1.Text = "toolStripStatusLabel1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(403, 208);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Coinsquare BTCalc";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox uxQuantityCAD;
        private System.Windows.Forms.TextBox uxPriceBTC;
        private System.Windows.Forms.TextBox uxBTCquantity;
        private System.Windows.Forms.TextBox uxBTCcurrPrice;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox uxQuantityAmount;
        private System.Windows.Forms.TextBox uxPriceBTC2;
        private System.Windows.Forms.TextBox uxPrice;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox uxBTCaSale;
    }
}

