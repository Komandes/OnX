using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace OnX
{
    public partial class Form2 : Form
    {
        public string winner;
        private Form1 board;
        public Form2(Form1 b)
        {
            board = b;
            InitializeComponent();
        }

        private void ShowWinner(object sender, EventArgs e)
        {
            WinnerLabel.Text = "Wygrywa: " + winner;
        }

        private void Nagroda_Click(object sender, EventArgs e)
        {
            board.ClearBoard();
            this.Close();
        }
    }
}
