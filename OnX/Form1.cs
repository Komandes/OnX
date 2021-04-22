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

            if (victoryCondition())
                ShowWinner();
            ChangeLabel();



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
        public bool victoryCondition()
        {
            if (String.Compare(TL.Text, ML.Text) == 0 && String.Compare(ML.Text, BL.Text) == 0 && String.Compare(ML.Text, "") != 0)
            {
                return true;
            }

            if (String.Compare(TC.Text, MC.Text) == 0 && String.Compare(MC.Text, BC.Text) == 0 && String.Compare(MC.Text, "") != 0)
            {
                return true;
            }

            if (String.Compare(TR.Text, MR.Text) == 0 && String.Compare(MR.Text, BR.Text) == 0 && String.Compare(MR.Text, "") != 0)
            {
                return true;
            }

            if (String.Compare(TL.Text, TC.Text) == 0 && String.Compare(TC.Text, TR.Text) == 0 && String.Compare(TC.Text, "") != 0)
            {
                return true;
            }

            if (String.Compare(ML.Text, MC.Text) == 0 && String.Compare(MC.Text, MR.Text) == 0 && String.Compare(MC.Text, "") != 0)
            {
                return true;
            }
            if (String.Compare(BL.Text, BC.Text) == 0 && String.Compare(BC.Text, BR.Text) == 0 && String.Compare(BC.Text, "") != 0)
            {
                return true;
            }
            if (String.Compare(TL.Text, MC.Text) == 0 && String.Compare(MC.Text, BR.Text) == 0 && String.Compare(MC.Text, "") != 0)
            {
                return true;
            }
            if (String.Compare(TR.Text, MC.Text) == 0 && String.Compare(MC.Text, BL.Text) == 0 && String.Compare(MC.Text, "") != 0)
            {
                return true;
            }
            return false;

        }

        public void ShowWinner()
         {
            Form2 victoryScreen = new Form2(this);
            victoryScreen.winner = PlayerTurn.Text;
            victoryScreen.Show();
        }
        public void ClearBoard()
        {
            TableLayoutControlCollection buttons = tableLayoutPanel1.Controls;

            for(int i = 0; i < buttons.Count; i++)
            {
                if (buttons[i] is Button)
                    buttons[i].Text = "";
            }
            currentPlayer = CurrentPlayer.Cross;
        }
    }
}

