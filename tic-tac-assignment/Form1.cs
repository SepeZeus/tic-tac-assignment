
namespace tic_tac_assignment
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            //Add buttons to list of buttons initially
            buttons.Add(button1); 
            buttons.Add(button2);
            buttons.Add(button3);
            buttons.Add(button4);
            buttons.Add(button5);
            buttons.Add(button6);
            buttons.Add(button7);
            buttons.Add(button8);
            buttons.Add(button9);
        }
        List<Button> buttons = new List<Button>(); //For CPU_Move
        int XorO = 0;
        char curPlayer = 'X';

        bool win = false;
        bool draw = false;
        bool gameStarted = false;
        bool CPUTurn = false;
        
        public enum Player
        {
            X, O
        }

        Player player = Player.X; //by default player is X

        //button action
        public void btn_click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            if (btn.Text.Equals(""))
            {

                if (!win && !draw && !CPUTurn)
                {
                    gameStarted = true;
                    if (XorO % 2 == 0)
                    {
                        btn.Text = "X";
                        btn.ForeColor = Color.Red;
                        curPlayer = 'X';
                        label1.Text = "O's Turn Now";
                        if (player == Player.X) //if player is X, then CPU is O
                            CPUTurn = true;
  
                        buttons.Remove(btn);
                    }
                    else
                    {
                        btn.Text = "O";
                        btn.ForeColor = Color.Blue;
                        curPlayer = 'O';
                        label1.Text = "X's Turn Now";
                        if (player == Player.O) //if player is O, then CPU is X
                            CPUTurn = true;
                        buttons.Remove(btn);
                    }
                    XorO++;
                    getWinner();

                    if (CPUTurn && !win && !draw)
                        CPU_Move();
                }

            }
        }
        //CPU moves randomly
        private async void CPU_Move()
        {
            await Task.Delay(427);
            Random random = new Random();
            int randInd = random.Next(0, buttons.Count);
            Button randBtn = buttons[randInd];
            CPUTurn = false;
            randBtn.PerformClick();
        }

        //check if we have a victor or a draw
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

            //check for draw
            if (!win && button1.Text != "" && button2.Text != "" && button3.Text != ""
                  && button4.Text != "" && button5.Text != "" && button6.Text != ""
                  && button7.Text != "" && button8.Text != "" && button9.Text != "")
            {
                label1.Text = "Draw";
                draw = true;
            }
        }

        //Change button colors to highlight winning combo
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

        //restart game/start a new game
        private async void newGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(CPUTurn) //wait for CPU turn to end
                await Task.Delay(427);
            win = false;
            draw = false;
            gameStarted = false;
            CPUTurn = false;
            label1.Text = "Play Now";

            if (player == Player.X)
                XorO = 0;
            else
                XorO = 1;

            //reset buttons to empty
            foreach (Control c in panel2.Controls) 
            {
                if (c is Button)
                {
                    c.Text = "";
                    c.BackColor = Color.AliceBlue;
                }
            }

            //Reset list of buttons for new game
            buttons = new List<Button>();
            buttons.Add(button1);
            buttons.Add(button2);
            buttons.Add(button3);
            buttons.Add(button4);
            buttons.Add(button5);
            buttons.Add(button6);
            buttons.Add(button7);
            buttons.Add(button8);
            buttons.Add(button9);

        }

        private void rulesToolStripMenuItem_Click(object sender, EventArgs e) //Show rules
        {
            MessageBox.Show("Get three of the same X or O in horizontal, vertical or diagonal to win");
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e) //Player has Exited the game (Application)
        {
            Application.Exit();
        }

        private void xToolStripMenuItem_Click(object sender, EventArgs e) //Player has chosen to play as X
        {
            if (!gameStarted)
            {
                player = Player.X;
                XorO = 0;
            }
            else
            {
                MessageBox.Show("Cannot change player type during active game");
            }
        }

        private void oToolStripMenuItem_Click(object sender, EventArgs e) //Player has chosen to play as O
        {
            if (!gameStarted)
            {
                player = Player.O;
                XorO = 1;
            }
            else
            {
                MessageBox.Show("Cannot change player type during active game");
            }
        }
    }
}