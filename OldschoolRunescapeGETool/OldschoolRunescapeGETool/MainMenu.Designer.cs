namespace OldschoolRunescapeGETool
{
    partial class MainMenu
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
            this.GEInfoButton = new System.Windows.Forms.Button();
            this.ProcessingProfitsButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // GEInfoButton
            // 
            this.GEInfoButton.Location = new System.Drawing.Point(12, 12);
            this.GEInfoButton.Name = "GEInfoButton";
            this.GEInfoButton.Size = new System.Drawing.Size(776, 38);
            this.GEInfoButton.TabIndex = 0;
            this.GEInfoButton.Text = "Grand Exchange Market Values";
            this.GEInfoButton.UseVisualStyleBackColor = true;
            this.GEInfoButton.Click += new System.EventHandler(this.GEInfoButton_Click);
            // 
            // ProcessingProfitsButton
            // 
            this.ProcessingProfitsButton.Location = new System.Drawing.Point(12, 56);
            this.ProcessingProfitsButton.Name = "ProcessingProfitsButton";
            this.ProcessingProfitsButton.Size = new System.Drawing.Size(776, 38);
            this.ProcessingProfitsButton.TabIndex = 1;
            this.ProcessingProfitsButton.Text = "Current Market Processing Profits";
            this.ProcessingProfitsButton.UseVisualStyleBackColor = true;
            this.ProcessingProfitsButton.Click += new System.EventHandler(this.ProcessingProfitsButton_Click);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ProcessingProfitsButton);
            this.Controls.Add(this.GEInfoButton);
            this.Name = "MainMenu";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button GEInfoButton;
        private System.Windows.Forms.Button ProcessingProfitsButton;
    }
}

