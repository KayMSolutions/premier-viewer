namespace GUIPremier
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            listPremiers = new ListBox();
            lblName = new Label();
            lblLife = new Label();
            lblStartEnd = new Label();
            picPremier = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)picPremier).BeginInit();
            SuspendLayout();
            // 
            // listPremiers
            // 
            listPremiers.FormattingEnabled = true;
            listPremiers.ItemHeight = 15;
            listPremiers.Location = new Point(291, 9);
            listPremiers.Name = "listPremiers";
            listPremiers.Size = new Size(129, 214);
            listPremiers.TabIndex = 1;
            
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(12, 9);
            lblName.Name = "lblName";
            lblName.Size = new Size(42, 15);
            lblName.TabIndex = 0;
            lblName.Text = "Name:";
            // 
            // lblLife
            // 
            lblLife.AutoSize = true;
            lblLife.Location = new Point(12, 227);
            lblLife.Name = "lblLife";
            lblLife.Size = new Size(34, 15);
            lblLife.TabIndex = 0;
            lblLife.Text = "DOB:";
            // 
            // lblStartEnd
            // 
            lblStartEnd.AutoSize = true;
            lblStartEnd.Location = new Point(12, 248);
            lblStartEnd.Name = "lblStartEnd";
            lblStartEnd.Size = new Size(37, 15);
            lblStartEnd.TabIndex = 0;
            lblStartEnd.Text = "Term:";
            // 
            // picPremier
            // 
            picPremier.Location = new Point(12, 39);
            picPremier.Name = "picPremier";
            picPremier.Size = new Size(150, 174);
            picPremier.SizeMode = PictureBoxSizeMode.AutoSize;
            picPremier.TabIndex = 4;
            picPremier.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(444, 313);
            Controls.Add(picPremier);
            Controls.Add(lblStartEnd);
            Controls.Add(lblLife);
            Controls.Add(lblName);
            Controls.Add(listPremiers);
            Name = "Form1";
            Text = "Premier Viewer";
            ((System.ComponentModel.ISupportInitialize)picPremier).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox listPremiers;
        private Label lblName;
        private Label lblLife;
        private Label lblStartEnd;
        private PictureBox picPremier;
    }
}
