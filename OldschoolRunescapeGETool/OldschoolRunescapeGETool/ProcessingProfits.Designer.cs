namespace OldschoolRunescapeGETool
{
    partial class ProcessingProfits
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
            this.SearchBar = new System.Windows.Forms.TextBox();
            this.ProcessView = new System.Windows.Forms.ListBox();
            this.BaseItemIcon = new System.Windows.Forms.PictureBox();
            this.ProductItemIcon = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.BaseItemNameLabel = new System.Windows.Forms.Label();
            this.ProductItemNameLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.BaseItemPriceLabel = new System.Windows.Forms.Label();
            this.ProductItemPriceLabel = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.ResetProcessesButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.ProcessingCostLabel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.ProfitPerItemLabel = new System.Windows.Forms.Label();
            this.InvestmentCostLabel = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.ProfitPerInvLabel = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.BaseItemIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProductItemIcon)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // SearchBar
            // 
            this.SearchBar.Location = new System.Drawing.Point(13, 418);
            this.SearchBar.Name = "SearchBar";
            this.SearchBar.Size = new System.Drawing.Size(775, 20);
            this.SearchBar.TabIndex = 0;
            this.SearchBar.TextChanged += new System.EventHandler(this.SearchBar_TextChanged);
            // 
            // ProcessView
            // 
            this.ProcessView.FormattingEnabled = true;
            this.ProcessView.Location = new System.Drawing.Point(12, 12);
            this.ProcessView.Name = "ProcessView";
            this.ProcessView.Size = new System.Drawing.Size(337, 394);
            this.ProcessView.TabIndex = 8;
            this.ProcessView.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ProcessView_MouseClick);
            // 
            // BaseItemIcon
            // 
            this.BaseItemIcon.Location = new System.Drawing.Point(6, 36);
            this.BaseItemIcon.Name = "BaseItemIcon";
            this.BaseItemIcon.Size = new System.Drawing.Size(96, 96);
            this.BaseItemIcon.TabIndex = 9;
            this.BaseItemIcon.TabStop = false;
            // 
            // ProductItemIcon
            // 
            this.ProductItemIcon.Location = new System.Drawing.Point(6, 36);
            this.ProductItemIcon.Name = "ProductItemIcon";
            this.ProductItemIcon.Size = new System.Drawing.Size(96, 96);
            this.ProductItemIcon.TabIndex = 10;
            this.ProductItemIcon.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.BaseItemPriceLabel);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.BaseItemNameLabel);
            this.groupBox1.Controls.Add(this.BaseItemIcon);
            this.groupBox1.Location = new System.Drawing.Point(352, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(215, 163);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Base Item";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.ProductItemPriceLabel);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.ProductItemNameLabel);
            this.groupBox2.Controls.Add(this.ProductItemIcon);
            this.groupBox2.Location = new System.Drawing.Point(573, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(215, 163);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Product";
            // 
            // BaseItemNameLabel
            // 
            this.BaseItemNameLabel.AutoSize = true;
            this.BaseItemNameLabel.Location = new System.Drawing.Point(6, 16);
            this.BaseItemNameLabel.Name = "BaseItemNameLabel";
            this.BaseItemNameLabel.Size = new System.Drawing.Size(124, 13);
            this.BaseItemNameLabel.TabIndex = 10;
            this.BaseItemNameLabel.Text = "No process selected yet!";
            // 
            // ProductItemNameLabel
            // 
            this.ProductItemNameLabel.AutoSize = true;
            this.ProductItemNameLabel.Location = new System.Drawing.Point(6, 16);
            this.ProductItemNameLabel.Name = "ProductItemNameLabel";
            this.ProductItemNameLabel.Size = new System.Drawing.Size(124, 13);
            this.ProductItemNameLabel.TabIndex = 11;
            this.ProductItemNameLabel.Text = "No process selected yet!";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 139);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Price:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 139);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Price:";
            // 
            // BaseItemPriceLabel
            // 
            this.BaseItemPriceLabel.AutoSize = true;
            this.BaseItemPriceLabel.Location = new System.Drawing.Point(48, 139);
            this.BaseItemPriceLabel.Name = "BaseItemPriceLabel";
            this.BaseItemPriceLabel.Size = new System.Drawing.Size(0, 13);
            this.BaseItemPriceLabel.TabIndex = 12;
            // 
            // ProductItemPriceLabel
            // 
            this.ProductItemPriceLabel.AutoSize = true;
            this.ProductItemPriceLabel.Location = new System.Drawing.Point(50, 139);
            this.ProductItemPriceLabel.Name = "ProductItemPriceLabel";
            this.ProductItemPriceLabel.Size = new System.Drawing.Size(0, 13);
            this.ProductItemPriceLabel.TabIndex = 13;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.ProfitPerInvLabel);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.InvestmentCostLabel);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.ProfitPerItemLabel);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.ProcessingCostLabel);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Location = new System.Drawing.Point(352, 181);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(436, 196);
            this.groupBox3.TabIndex = 15;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Process";
            // 
            // ResetProcessesButton
            // 
            this.ResetProcessesButton.Location = new System.Drawing.Point(352, 383);
            this.ResetProcessesButton.Name = "ResetProcessesButton";
            this.ResetProcessesButton.Size = new System.Drawing.Size(436, 23);
            this.ResetProcessesButton.TabIndex = 16;
            this.ResetProcessesButton.Text = "Fetch current prices";
            this.ResetProcessesButton.UseVisualStyleBackColor = true;
            this.ResetProcessesButton.Click += new System.EventHandler(this.ResetProcessesButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(129, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Processing Cost:";
            // 
            // ProcessingCostLabel
            // 
            this.ProcessingCostLabel.AutoSize = true;
            this.ProcessingCostLabel.Location = new System.Drawing.Point(222, 36);
            this.ProcessingCostLabel.Name = "ProcessingCostLabel";
            this.ProcessingCostLabel.Size = new System.Drawing.Size(0, 13);
            this.ProcessingCostLabel.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(139, 134);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Profit Per Item:";
            // 
            // ProfitPerItemLabel
            // 
            this.ProfitPerItemLabel.AutoSize = true;
            this.ProfitPerItemLabel.Location = new System.Drawing.Point(221, 134);
            this.ProfitPerItemLabel.Name = "ProfitPerItemLabel";
            this.ProfitPerItemLabel.Size = new System.Drawing.Size(0, 13);
            this.ProfitPerItemLabel.TabIndex = 3;
            // 
            // InvestmentCostLabel
            // 
            this.InvestmentCostLabel.AutoSize = true;
            this.InvestmentCostLabel.Location = new System.Drawing.Point(222, 66);
            this.InvestmentCostLabel.Name = "InvestmentCostLabel";
            this.InvestmentCostLabel.Size = new System.Drawing.Size(0, 13);
            this.InvestmentCostLabel.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(84, 66);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(131, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "Initial Investment Per Item:";
            // 
            // ProfitPerInvLabel
            // 
            this.ProfitPerInvLabel.AutoSize = true;
            this.ProfitPerInvLabel.Location = new System.Drawing.Point(221, 157);
            this.ProfitPerInvLabel.Name = "ProfitPerInvLabel";
            this.ProfitPerInvLabel.Size = new System.Drawing.Size(0, 13);
            this.ProfitPerInvLabel.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(94, 157);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(121, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Profit Per Inventory (27):";
            // 
            // ProcessingProfits
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ResetProcessesButton);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.ProcessView);
            this.Controls.Add(this.SearchBar);
            this.Name = "ProcessingProfits";
            this.Text = "ProcessingProfits";
            this.Load += new System.EventHandler(this.ProcessingProfits_Load);
            ((System.ComponentModel.ISupportInitialize)(this.BaseItemIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProductItemIcon)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox SearchBar;
        private System.Windows.Forms.ListBox ProcessView;
        private System.Windows.Forms.PictureBox BaseItemIcon;
        private System.Windows.Forms.PictureBox ProductItemIcon;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label BaseItemNameLabel;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label ProductItemNameLabel;
        private System.Windows.Forms.Label BaseItemPriceLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label ProductItemPriceLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button ResetProcessesButton;
        private System.Windows.Forms.Label ProfitPerItemLabel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label ProcessingCostLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label InvestmentCostLabel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label ProfitPerInvLabel;
        private System.Windows.Forms.Label label7;
    }
}