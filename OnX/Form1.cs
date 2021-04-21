using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OnX
{
    enum CurrentPlayer
    {
        Cross,
        Circle
    }
    public partial class Form1 : Form
    {
        CurrentPlayer currentPlayer;
        public Form1()
        {
            InitializeComponent();
            currentPlayer = CurrentPlayer.Cross;
            ChangeLabel();


        }

        private void Mark(object sender, EventArgs e)
        {
            Button senderButton = (Button)sender;
            if (currentPlayer == CurrentPlayer.Cross)
            {
                senderButton.Text = "X";
                currentPlayer = CurrentPlayer.Circle;
            }
            else
            {
                senderButton.Text = "O";
                currentPlayer = CurrentPlayer.Cross;
            }
            victoryCondition();
            ChangeLabel();
        }
        public void ChangeLabel()
            {
                if (currentPlayer == CurrentPlayer.Cross)
                {
                    PlayerTurn.Text = "Krzyżyk";
                }
                else
                {
                    PlayerTurn.Text = "Kółko";
                }
            }
        public void victoryCondition()
        {
            if (String.Compare(TL.Text, ML.Text) == 0 && String.Compare(ML.Text, BL.Text) == 0)
            {
                Form2 victoryScreen = new Form2();
                victoryScreen.winner = TL.Text;
                victoryScreen.Show();
            }
        }

        public void ClearBoard()
        {
            TableLayoutControlCollection[] buttons = tableLayoutPanel1.Controls;

            for(int i = 0; i < buttons.Count; i++)
            {
                if(buttons[i] is Button)
                    buttons[i].Text = ""
            }
        }
    }
}

