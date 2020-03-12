namespace OldschoolRunescapeGETool
{
    partial class GEInfo
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
            this.ItemView = new System.Windows.Forms.ListBox();
            this.SearchBar = new System.Windows.Forms.TextBox();
            this.ItemIcon = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ItemNameLabel = new System.Windows.Forms.Label();
            this.ItemDescriptionLabel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.PriceLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.CurrentPriceLabel = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.CurrentTrendLabel = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.Prices = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.label14 = new System.Windows.Forms.Label();
            this.Day180TrendLabel = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.Day180ChangeLabel = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.Day90TrendLabel = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.Day90ChangeLabel = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Day30TrendLabel = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.Day30ChangeLabel = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.TodayTrendLabel = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.TodayPriceLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ItemIcon)).BeginInit();
            this.Prices.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ItemView
            // 
            this.ItemView.FormattingEnabled = true;
            this.ItemView.Location = new System.Drawing.Point(12, 12);
            this.ItemView.Name = "ItemView";
            this.ItemView.Size = new System.Drawing.Size(337, 394);
            this.ItemView.TabIndex = 7;
            this.ItemView.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ItemView_MouseClick);
            this.ItemView.SelectedIndexChanged += new System.EventHandler(this.ItemView_SelectedIndexChanged);
            // 
            // SearchBar
            // 
            this.SearchBar.Location = new System.Drawing.Point(12, 418);
            this.SearchBar.Name = "SearchBar";
            this.SearchBar.Size = new System.Drawing.Size(776, 20);
            this.SearchBar.TabIndex = 6;
            this.SearchBar.TextChanged += new System.EventHandler(this.SearchBar_TextChanged);
            // 
            // ItemIcon
            // 
            this.ItemIcon.Location = new System.Drawing.Point(355, 12);
            this.ItemIcon.Name = "ItemIcon";
            this.ItemIcon.Size = new System.Drawing.Size(96, 96);
            this.ItemIcon.TabIndex = 5;
            this.ItemIcon.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(458, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Item Name:";
            // 
            // ItemNameLabel
            // 
            this.ItemNameLabel.AutoSize = true;
            this.ItemNameLabel.Location = new System.Drawing.Point(523, 13);
            this.ItemNameLabel.Name = "ItemNameLabel";
            this.ItemNameLabel.Size = new System.Drawing.Size(103, 13);
            this.ItemNameLabel.TabIndex = 9;
            this.ItemNameLabel.Text = "No item selected yet";
            // 
            // ItemDescriptionLabel
            // 
            this.ItemDescriptionLabel.AutoSize = true;
            this.ItemDescriptionLabel.Location = new System.Drawing.Point(523, 43);
            this.ItemDescriptionLabel.Name = "ItemDescriptionLabel";
            this.ItemDescriptionLabel.Size = new System.Drawing.Size(0, 13);
            this.ItemDescriptionLabel.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(456, 43);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Description:";
            // 
            // PriceLabel
            // 
            this.PriceLabel.AutoSize = true;
            this.PriceLabel.Location = new System.Drawing.Point(523, 70);
            this.PriceLabel.Name = "PriceLabel";
            this.PriceLabel.Size = new System.Drawing.Size(0, 13);
            this.PriceLabel.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(456, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Price:";
            // 
            // CurrentPriceLabel
            // 
            this.CurrentPriceLabel.AutoSize = true;
            this.CurrentPriceLabel.Location = new System.Drawing.Point(67, 16);
            this.CurrentPriceLabel.Name = "CurrentPriceLabel";
            this.CurrentPriceLabel.Size = new System.Drawing.Size(0, 13);
            this.CurrentPriceLabel.TabIndex = 15;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Price:";
            // 
            // CurrentTrendLabel
            // 
            this.CurrentTrendLabel.AutoSize = true;
            this.CurrentTrendLabel.Location = new System.Drawing.Point(242, 16);
            this.CurrentTrendLabel.Name = "CurrentTrendLabel";
            this.CurrentTrendLabel.Size = new System.Drawing.Size(0, 13);
            this.CurrentTrendLabel.TabIndex = 17;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(198, 16);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "Trend:";
            // 
            // Prices
            // 
            this.Prices.Controls.Add(this.groupBox1);
            this.Prices.Controls.Add(this.groupBox5);
            this.Prices.Controls.Add(this.groupBox4);
            this.Prices.Controls.Add(this.groupBox3);
            this.Prices.Controls.Add(this.groupBox2);
            this.Prices.Location = new System.Drawing.Point(355, 114);
            this.Prices.Name = "Prices";
            this.Prices.Size = new System.Drawing.Size(433, 292);
            this.Prices.TabIndex = 18;
            this.Prices.TabStop = false;
            this.Prices.Text = "Prices and Trends";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.label14);
            this.groupBox5.Controls.Add(this.Day180TrendLabel);
            this.groupBox5.Controls.Add(this.label16);
            this.groupBox5.Controls.Add(this.Day180ChangeLabel);
            this.groupBox5.Location = new System.Drawing.Point(6, 205);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(421, 42);
            this.groupBox5.TabIndex = 19;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "180 Days";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(12, 16);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(47, 13);
            this.label14.TabIndex = 14;
            this.label14.Text = "Change:";
            // 
            // Day180TrendLabel
            // 
            this.Day180TrendLabel.AutoSize = true;
            this.Day180TrendLabel.Location = new System.Drawing.Point(242, 16);
            this.Day180TrendLabel.Name = "Day180TrendLabel";
            this.Day180TrendLabel.Size = new System.Drawing.Size(0, 13);
            this.Day180TrendLabel.TabIndex = 17;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(198, 16);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(38, 13);
            this.label16.TabIndex = 16;
            this.label16.Text = "Trend:";
            // 
            // Day180ChangeLabel
            // 
            this.Day180ChangeLabel.AutoSize = true;
            this.Day180ChangeLabel.Location = new System.Drawing.Point(67, 16);
            this.Day180ChangeLabel.Name = "Day180ChangeLabel";
            this.Day180ChangeLabel.Size = new System.Drawing.Size(0, 13);
            this.Day180ChangeLabel.TabIndex = 15;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label10);
            this.groupBox4.Controls.Add(this.Day90TrendLabel);
            this.groupBox4.Controls.Add(this.label12);
            this.groupBox4.Controls.Add(this.Day90ChangeLabel);
            this.groupBox4.Location = new System.Drawing.Point(6, 157);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(421, 42);
            this.groupBox4.TabIndex = 19;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "90 Days";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(12, 16);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(47, 13);
            this.label10.TabIndex = 14;
            this.label10.Text = "Change:";
            // 
            // Day90TrendLabel
            // 
            this.Day90TrendLabel.AutoSize = true;
            this.Day90TrendLabel.Location = new System.Drawing.Point(242, 16);
            this.Day90TrendLabel.Name = "Day90TrendLabel";
            this.Day90TrendLabel.Size = new System.Drawing.Size(0, 13);
            this.Day90TrendLabel.TabIndex = 17;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(198, 16);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(38, 13);
            this.label12.TabIndex = 16;
            this.label12.Text = "Trend:";
            // 
            // Day90ChangeLabel
            // 
            this.Day90ChangeLabel.AutoSize = true;
            this.Day90ChangeLabel.Location = new System.Drawing.Point(67, 16);
            this.Day90ChangeLabel.Name = "Day90ChangeLabel";
            this.Day90ChangeLabel.Size = new System.Drawing.Size(0, 13);
            this.Day90ChangeLabel.TabIndex = 15;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.Day30TrendLabel);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.Day30ChangeLabel);
            this.groupBox3.Location = new System.Drawing.Point(6, 109);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(421, 42);
            this.groupBox3.TabIndex = 19;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "30 Days";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Change:";
            // 
            // Day30TrendLabel
            // 
            this.Day30TrendLabel.AutoSize = true;
            this.Day30TrendLabel.Location = new System.Drawing.Point(242, 16);
            this.Day30TrendLabel.Name = "Day30TrendLabel";
            this.Day30TrendLabel.Size = new System.Drawing.Size(0, 13);
            this.Day30TrendLabel.TabIndex = 17;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(198, 16);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(38, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "Trend:";
            // 
            // Day30ChangeLabel
            // 
            this.Day30ChangeLabel.AutoSize = true;
            this.Day30ChangeLabel.Location = new System.Drawing.Point(67, 16);
            this.Day30ChangeLabel.Name = "Day30ChangeLabel";
            this.Day30ChangeLabel.Size = new System.Drawing.Size(0, 13);
            this.Day30ChangeLabel.TabIndex = 15;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.CurrentTrendLabel);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.CurrentPriceLabel);
            this.groupBox2.Location = new System.Drawing.Point(6, 13);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(421, 42);
            this.groupBox2.TabIndex = 18;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Current";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.TodayTrendLabel);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.TodayPriceLabel);
            this.groupBox1.Location = new System.Drawing.Point(0, 61);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(421, 42);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Today";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(18, 16);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(34, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Price:";
            // 
            // TodayTrendLabel
            // 
            this.TodayTrendLabel.AutoSize = true;
            this.TodayTrendLabel.Location = new System.Drawing.Point(248, 16);
            this.TodayTrendLabel.Name = "TodayTrendLabel";
            this.TodayTrendLabel.Size = new System.Drawing.Size(0, 13);
            this.TodayTrendLabel.TabIndex = 17;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(204, 16);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(38, 13);
            this.label11.TabIndex = 16;
            this.label11.Text = "Trend:";
            // 
            // TodayPriceLabel
            // 
            this.TodayPriceLabel.AutoSize = true;
            this.TodayPriceLabel.Location = new System.Drawing.Point(73, 16);
            this.TodayPriceLabel.Name = "TodayPriceLabel";
            this.TodayPriceLabel.Size = new System.Drawing.Size(0, 13);
            this.TodayPriceLabel.TabIndex = 15;
            // 
            // GEInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Prices);
            this.Controls.Add(this.PriceLabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ItemDescriptionLabel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ItemNameLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ItemView);
            this.Controls.Add(this.SearchBar);
            this.Controls.Add(this.ItemIcon);
            this.Name = "GEInfo";
            this.Text = "GEInfo";
            this.Load += new System.EventHandler(this.GEInfo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ItemIcon)).EndInit();
            this.Prices.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox ItemView;
        private System.Windows.Forms.TextBox SearchBar;
        private System.Windows.Forms.PictureBox ItemIcon;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label ItemNameLabel;
        private System.Windows.Forms.Label ItemDescriptionLabel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label PriceLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label CurrentPriceLabel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label CurrentTrendLabel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox Prices;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label Day180TrendLabel;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label Day180ChangeLabel;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label Day90TrendLabel;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label Day90ChangeLabel;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Day30TrendLabel;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label Day30ChangeLabel;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label TodayTrendLabel;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label TodayPriceLabel;
    }
}