using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTacToe
{
    public partial class Form1 : Form
    {

        bool turn = true; // If true "X" turn : false "O" turn    -- later i will implement how will play turn first manually
        int turnCount = 0;
        //int x_win_count = 0;
        //int o_win_count = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void newGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            turn = true; // If true "X" turn : false "O" turn    -- later i will implement how will play turn first manually
            turnCount = 0;
        


           
                foreach (Control c in Controls)
                {
                    try 
                    {
                        Button b = (Button)c;
                                if (b.Name != "btnReset")
                            {
                                b.Text = "";
                                b.Enabled = true;
                            }
                            else
                            {
                                b.Text = "Reset ScoreBoard";
                                b.Enabled = true;
                            }
                    }

                catch { }
            }
            
            

        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This Tic Tac Toe Game is Proceduced for Education Purpose to learn Coding. \nThe Credit of this game is all given to The Real Tic Tac Toe Game Owner- Ronald Graham", "Tic Tac Toe - By Rohit Maharjan");
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_Player_Click(object sender, EventArgs e)
        {
            turnCount += 1;

            Button b =  (Button) sender;

            if (turn == true)
            {
                //  MessageBox.Show("X");
                b.Text = "X";
                b.BackColor = Color.Firebrick;
                turn = false; // or use turn =!turn;

                b.Enabled = false;
                //b.Disabled();
            }
            else
            {
                b.Text = "O";
                b.BackColor = Color.LightCyan;
                turn = true;
                b.Enabled = false;
            }

            CheckForWinner();
        }        
            private void CheckForWinner()
            {

            bool there_is_a_winner = false;

                /*if (turnCount > 4)
                     {*/

                // horizontal check
                        if ( (A1.Text == A2.Text) && (A2.Text == A3.Text) && (!A1.Enabled))
                                        {
                                            there_is_a_winner = true;
                                        }

                        else if ((B1.Text == B2.Text) && (B2.Text == B3.Text) && (!B1.Enabled) )
                                        {
                                            there_is_a_winner = true;
                                        }

                        else if ((C1.Text == C2.Text) && (C2.Text == C3.Text) && (!C1.Enabled) )
                                        {
                                            there_is_a_winner = true;
                                        }


            // vertical check
                        else if ((A1.Text == B1.Text) && (B1.Text == C1.Text) && (!A1.Enabled) )
                                        {
                                            there_is_a_winner = true;
                                        }
                        else if ((A2.Text == B2.Text) && (B2.Text == C2.Text) && (!A2.Enabled) )
                                        {
                                            there_is_a_winner = true;
                                        }
                        else if ((A3.Text == B3.Text) && (B3.Text == C3.Text) && (!A3.Enabled) )
                                        {
                                            there_is_a_winner = true;
                                        }


            // diagonal check
                        else if  ((A1.Text == B2.Text) && (B2.Text == C3.Text) && (!A1.Enabled) )
                                        {
                                            there_is_a_winner = true;
                                        }
                        else if ((C1.Text == B2.Text) && (B2.Text == A3.Text) && (!C1.Enabled))
                                        {
                                            there_is_a_winner = true;
                                        }



            // } // end if turn > 4

            if (there_is_a_winner)
            {
                DisableButtons();

                string winner = "";
                if (turn)                // turn ? "Player X" : "Player O";
                {
                    winner = "Player O";

                    OWinCount.Text = (Int32.Parse(OWinCount.Text) + 1).ToString();
                }
                else
                {
                    winner = "Player X";
                    XWinCount.Text = (Int32.Parse(XWinCount.Text) + 1).ToString();
                }

                MessageBox.Show("The Winner is " + winner + " !!!", "Winner !!!");
                newGameToolStripMenuItem_Click(null, null);

            }

            else
            {
                if (turnCount == 9)
                {
                    DrawWinCount.Text = (Int32.Parse(DrawWinCount.Text) + 1).ToString();
                    MessageBox.Show("The Game is Draw !!!", "Draw !!!");
                    newGameToolStripMenuItem_Click(null, null);
                }
            }

            // end if there is a winner
        } // end check for winner


        private void DisableButtons()
        {
            
                foreach (Control c in Controls)
                {
                    if (c.GetType() == typeof(Button))
                    {
                        Button b = (Button)c;
                        b.Enabled = false;
                    }
                }
            
        }

        private void Btn_Enter(object sender, EventArgs e)
        {

            Button b = (Button)sender;
            if (b.Enabled)
                if (turn)
                {
                    b.Text = "X";

                }
                else
                {
                    b.Text = "O";
                }
        }
        

        private void Btn_Leave(object sender, EventArgs e)
        {
        Button b = (Button)sender;
            if (b.Enabled)
            {
                b.Text = "";
            }
        }



        private void btnResetScoreBoard(object sender, EventArgs e)
        {
            XWinCount.Text = "0";
            OWinCount.Text = "0";
            DrawWinCount.Text = "0";
        }

        //THis is demo commit test 101
    }
}


