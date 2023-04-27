using System.Diagnostics;

namespace tic_tac_assignment
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            foreach (Control c in panel2.Controls)
            {
                if (c is Button)
                {
                    c.Click += new System.EventHandler(btn_click);

                }
            }
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
                        //getWinner();
                        curPlayer = 'X';

                        label1.Text = "O's Turn Now";
                    }
                    else
                    {
                        btn.Text = "O";
                        btn.ForeColor = Color.Blue;
                        curPlayer = 'O';

                        //getWinner();

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
            //check horizontal
            if ((button1.Text != "" && button1.Text == button2.Text && button2.Text == button3.Text)
                || (button4.Text != "" && button4.Text == button5.Text && button5.Text == button6.Text)
                || (button7.Text != "" && button7.Text == button8.Text && button8.Text == button9.Text)
                )
            {
                win = true;
                label1.Text = winText;

            } //check vertical
            else if ((button1.Text != "" && button1.Text == button4.Text && button4.Text == button7.Text)
                || (button2.Text != "" && button2.Text == button5.Text && button5.Text == button8.Text)
                || (button3.Text != "" && button3.Text == button6.Text && button6.Text == button9.Text)
                )
            {
                win = true;
                label1.Text = winText;


            }//check diagonal
            else if ((button1.Text != "" && button1.Text == button5.Text && button5.Text == button9.Text)
                || (button3.Text != "" && button3.Text == button5.Text && button5.Text == button7.Text)
                )
            {
                win = true;
                label1.Text = winText;

            }
            else if (button1.Text != "" && button2.Text != "" && button3.Text != ""
                  && button4.Text != "" && button5.Text != "" && button6.Text != ""
                  && button7.Text != "" && button8.Text != "" && button9.Text != "")
            {
                label1.Text = "Game Ended In Draw";

            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}