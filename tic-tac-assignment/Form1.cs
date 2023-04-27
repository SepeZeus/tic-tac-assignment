using System.Diagnostics;

namespace tic_tac_assignment
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int XorO = 0;
        char curPlayer = 'X';
        bool win = false;
        //button action
        public void btn_click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            Debug.WriteLine(btn.Name);
            if (btn.Text.Equals(""))
            {

                if (!win)
                {
                    if (XorO % 2 == 0)
                    {
                        btn.Text = "X";
                        btn.ForeColor = Color.Red;
                        curPlayer = 'X';
                        label1.Text = "O's Turn Now";
                    }
                    else
                    {
                        btn.Text = "O";
                        btn.ForeColor = Color.Blue;
                        curPlayer = 'O';
                        label1.Text = "X's Turn Now";

                    }
                    XorO++;

                }
                getWinner();

            }
        }

        public void getWinner()
        {
            string winText = curPlayer + " Is The Winner";
            //check horizontal (top to bottom)
            //first row
            if (button1.Text != "" && button1.Text == button2.Text && button2.Text == button3.Text)
            {
                win = true;
                label1.Text = winText;
                winEffect(button1, button2, button3);
            }
            //second row
            else if (button4.Text != "" && button4.Text == button5.Text && button5.Text == button6.Text)
            {
                win = true;
                label1.Text = winText;
                winEffect(button4, button5, button6);
            }
            //third row
            else if (button7.Text != "" && button7.Text == button8.Text && button8.Text == button9.Text)
            {
                win = true;
                label1.Text = winText;
                winEffect(button7, button8, button9);
            }

            //check vertical (left to right)
            //first column
            if (button1.Text != "" && button1.Text == button4.Text && button4.Text == button7.Text)
            {
                win = true;
                label1.Text = winText;
                winEffect(button1, button4, button7);
            }
            //second column
            else if (button2.Text != "" && button2.Text == button5.Text && button5.Text == button8.Text)
            {
                win = true;
                label1.Text = winText;
                winEffect(button2, button5, button8);
            }
            //third column
            else if (button3.Text != "" && button3.Text == button6.Text && button6.Text == button9.Text)
            {
                win = true;
                label1.Text = winText;
                winEffect(button3, button6, button9);
            }

            //check diagonal
            // \ of X
            if (button1.Text != "" && button1.Text == button5.Text && button5.Text == button9.Text)
            {
                win = true;
                label1.Text = winText;
                winEffect(button1, button5, button9);
            }
            // / of X
             else if (button3.Text != "" && button3.Text == button5.Text && button5.Text == button7.Text)
            {
                win = true;
                label1.Text = winText;
                winEffect(button3, button5, button7);
            }


            if (win) //disable buttons if victor
            {
                disableButtons();
            }
            //check for draw
            else if (button1.Text != "" && button2.Text != "" && button3.Text != ""
                  && button4.Text != "" && button5.Text != "" && button6.Text != ""
                  && button7.Text != "" && button8.Text != "" && button9.Text != "")
            {
                label1.Text = "Draw";
                disableButtons(); // disable buttons if no victor
            }
        }

        private void disableButtons()
        {
            foreach (Control c in panel2.Controls)
            {
                Button b = (Button)c;
                b.Enabled = false;
            }
        }
        public void winEffect(Button b1, Button b2, Button b3)
        {
            b1.BackColor = Color.Green;
            b2.BackColor = Color.Green;
            b3.BackColor = Color.Green;

            b1.ForeColor = Color.White;
            b2.ForeColor = Color.White;
            b3.ForeColor = Color.White;

        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}