
namespace OnX
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.BR = new System.Windows.Forms.Button();
            this.BC = new System.Windows.Forms.Button();
            this.BL = new System.Windows.Forms.Button();
            this.MR = new System.Windows.Forms.Button();
            this.MC = new System.Windows.Forms.Button();
            this.ML = new System.Windows.Forms.Button();
            this.TR = new System.Windows.Forms.Button();
            this.TC = new System.Windows.Forms.Button();
            this.TL = new System.Windows.Forms.Button();
            this.Players = new System.Windows.Forms.Label();
            this.PlayerTurn = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel1.Controls.Add(this.BR, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.BC, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.BL, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.MR, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.MC, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.ML, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.TR, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.TC, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.TL, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(27, 170);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(301, 268);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // BR
            // 
            this.BR.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BR.Font = new System.Drawing.Font("Segoe UI Black", 27F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BR.Location = new System.Drawing.Point(203, 181);
            this.BR.Name = "BR";
            this.BR.Size = new System.Drawing.Size(95, 84);
            this.BR.TabIndex = 8;
            this.BR.UseVisualStyleBackColor = true;
            this.BR.Click += new System.EventHandler(this.Mark);
            // 
            // BC
            // 
            this.BC.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BC.Font = new System.Drawing.Font("Segoe UI Black", 27F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BC.Location = new System.Drawing.Point(103, 181);
            this.BC.Name = "BC";
            this.BC.Size = new System.Drawing.Size(94, 84);
            this.BC.TabIndex = 7;
            this.BC.UseVisualStyleBackColor = true;
            this.BC.Click += new System.EventHandler(this.Mark);
            // 
            // BL
            // 
            this.BL.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BL.Font = new System.Drawing.Font("Segoe UI Black", 27F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BL.Location = new System.Drawing.Point(3, 181);
            this.BL.Name = "BL";
            this.BL.Size = new System.Drawing.Size(94, 84);
            this.BL.TabIndex = 6;
            this.BL.UseVisualStyleBackColor = true;
            this.BL.Click += new System.EventHandler(this.Mark);
            // 
            // MR
            // 
            this.MR.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MR.Font = new System.Drawing.Font("Segoe UI Black", 27F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.MR.Location = new System.Drawing.Point(203, 92);
            this.MR.Name = "MR";
            this.MR.Size = new System.Drawing.Size(95, 83);
            this.MR.TabIndex = 5;
            this.MR.UseVisualStyleBackColor = true;
            this.MR.Click += new System.EventHandler(this.Mark);
            // 
            // MC
            // 
            this.MC.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MC.Font = new System.Drawing.Font("Segoe UI Black", 27F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.MC.Location = new System.Drawing.Point(103, 92);
            this.MC.Name = "MC";
            this.MC.Size = new System.Drawing.Size(94, 83);
            this.MC.TabIndex = 4;
            this.MC.UseVisualStyleBackColor = true;
            this.MC.Click += new System.EventHandler(this.Mark);
            // 
            // ML
            // 
            this.ML.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ML.Font = new System.Drawing.Font("Segoe UI Black", 27F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ML.Location = new System.Drawing.Point(3, 92);
            this.ML.Name = "ML";
            this.ML.Size = new System.Drawing.Size(94, 83);
            this.ML.TabIndex = 3;
            this.ML.UseVisualStyleBackColor = true;
            this.ML.Click += new System.EventHandler(this.Mark);
            // 
            // TR
            // 
            this.TR.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TR.Font = new System.Drawing.Font("Segoe UI Black", 27F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TR.Location = new System.Drawing.Point(203, 3);
            this.TR.Name = "TR";
            this.TR.Size = new System.Drawing.Size(95, 83);
            this.TR.TabIndex = 2;
            this.TR.UseVisualStyleBackColor = true;
            this.TR.Click += new System.EventHandler(this.Mark);
            // 
            // TC
            // 
            this.TC.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TC.Font = new System.Drawing.Font("Segoe UI Black", 27F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TC.Location = new System.Drawing.Point(103, 3);
            this.TC.Name = "TC";
            this.TC.Size = new System.Drawing.Size(94, 83);
            this.TC.TabIndex = 1;
            this.TC.UseVisualStyleBackColor = true;
            this.TC.Click += new System.EventHandler(this.Mark);
            // 
            // TL
            // 
            this.TL.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TL.Font = new System.Drawing.Font("Segoe UI Black", 27F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.TL.Location = new System.Drawing.Point(3, 3);
            this.TL.Name = "TL";
            this.TL.Size = new System.Drawing.Size(94, 83);
            this.TL.TabIndex = 0;
            this.TL.UseVisualStyleBackColor = true;
            this.TL.Click += new System.EventHandler(this.Mark);
            // 
            // Players
            // 
            this.Players.AutoSize = true;
            this.Players.Location = new System.Drawing.Point(12, 130);
            this.Players.Name = "Players";
            this.Players.Size = new System.Drawing.Size(70, 15);
            this.Players.TabIndex = 1;
            this.Players.Text = "Tura gracza:";
            // 
            // PlayerTurn
            // 
            this.PlayerTurn.AutoSize = true;
            this.PlayerTurn.Location = new System.Drawing.Point(89, 130);
            this.PlayerTurn.Name = "PlayerTurn";
            this.PlayerTurn.Size = new System.Drawing.Size(0, 15);
            this.PlayerTurn.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(346, 450);
            this.Controls.Add(this.PlayerTurn);
            this.Controls.Add(this.Players);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button BR;
        private System.Windows.Forms.Button BC;
        private System.Windows.Forms.Button BL;
        private System.Windows.Forms.Button MR;
        private System.Windows.Forms.Button MC;
        private System.Windows.Forms.Button ML;
        private System.Windows.Forms.Button TR;
        private System.Windows.Forms.Button TC;
        private System.Windows.Forms.Button TL;
        private System.Windows.Forms.Label Players;
        private System.Windows.Forms.Label PlayerTurn;
    }
}

