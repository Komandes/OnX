
namespace OnX
{
    partial class Form2
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
            this.WinnerLabel = new System.Windows.Forms.Label();
            this.Nagroda = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Black", 33F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(56, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(558, 60);
            this.label1.TabIndex = 0;
            this.label1.Text = "Gratulacje urzytkowniku";
            // 
            // WinnerLabel
            // 
            this.WinnerLabel.AutoSize = true;
            this.WinnerLabel.Font = new System.Drawing.Font("Roboto Black", 27F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.WinnerLabel.Location = new System.Drawing.Point(79, 159);
            this.WinnerLabel.Name = "WinnerLabel";
            this.WinnerLabel.Size = new System.Drawing.Size(179, 43);
            this.WinnerLabel.TabIndex = 1;
            this.WinnerLabel.Text = "Wygrywa:";
            // 
            // Nagroda
            // 
            this.Nagroda.Location = new System.Drawing.Point(225, 309);
            this.Nagroda.Name = "Nagroda";
            this.Nagroda.Size = new System.Drawing.Size(212, 23);
            this.Nagroda.TabIndex = 2;
            this.Nagroda.Text = "Wygraj Nagrodę w postaci 10000zł";
            this.Nagroda.UseVisualStyleBackColor = true;
            this.Nagroda.Click += new System.EventHandler(this.Nagroda_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(692, 450);
            this.Controls.Add(this.Nagroda);
            this.Controls.Add(this.WinnerLabel);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Shown += new System.EventHandler(this.ShowWinner);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label WinnerLabel;
        private System.Windows.Forms.Button Nagroda;
    }
}