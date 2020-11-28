using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Puzzle
{
    public partial class Puzzle : Form
    {

        private int TotalTime;
        private Position empty;
        private Button focused = null;
        private Button[] buttons;
        private int TabCounter = 0;



        public Puzzle()
        {
            InitializeComponent();
            buttons = new Button[] { button1, button2,button3,button4,
                                     button5,button6,button7,button8};

        }

        private void Puzzle_Load(object sender, EventArgs e)
        {
            this.end.Enabled = false;
            this.modeM.Checked = true;
            

        }

        private void start_Click(object sender, EventArgs e)
        {

            //update buttons
            start.Enabled = false;
            modes.Enabled = false;
            end.Enabled = true;


            //Place pieces randomly in the board
            board.Controls.Clear();
            List<Position> positions = new List<Position> { new Position( 0, 0 ), new Position(0, 1), new Position(0, 2), new Position(1, 0),
                                        new Position(1, 1), new Position(1, 2), new Position(2, 0), new Position(2, 1), new Position(2, 2) };
            Random random = new Random();
            for (int i = 0; i < 8; i++)
            {
                int p = random.Next(positions.Count - 1);
                this.board.Controls.Add(buttons[i], positions[p].Row, positions[p].Col);
                positions.RemoveAt(p);
            }
            // the empty cell
            empty = new Position(positions[0].Col, positions[0].Row);

            //set the time based on difficulty  and start the timer
            if (modeE.Checked)
                this.TotalTime = 600;
            else if (modeM.Checked)
                this.TotalTime = 300;
            else if (modeH.Checked)
                this.TotalTime = 180;

            this.timer.Enabled = true;


        }

        private void end_Click(object sender, EventArgs e)
        {


            end.Enabled = false;
            start.Enabled = true;
            modes.Enabled = true;
            if (timer.Enabled)
            {
                timer.Stop();
                clock.Text = "00:00";
            }
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            if (this.TotalTime > 0)
            {
                TotalTime--;
                int minutes = TotalTime / 60;
                int seconds = TotalTime - (minutes * 60);
                clock.Text = string.Format("{0:00}:{1:00}", minutes, seconds);
            }
            else
            {
                if (!IsWin())
                {
                    timer.Stop();
                    MessageBox.Show("time is up!\nGood luck next time :-)");
                    end.Enabled = false;
                    start.Enabled = true;
                    modes.Enabled = true;
                }
                
            }

        }


        private void Deplacer(Position newPos, Position oldPos, int op) {
            Button button = (Button)board.GetControlFromPosition(oldPos.Col, oldPos.Row);
                        board.Controls.Remove(button);
                        board.Controls.Add(button, newPos.Col, newPos.Row);
            switch (op)
            {
                case 1:
                    empty.Row--;
                    break;
                case 2:
                    empty.Row++;
                    break;
                case 3:
                    empty.Col--;
                    break;
                case 4:
                    empty.Col++;
                    break;  
                default:
                    break;
            }
            
            IsWin();
        }
        // arrows not detecting by (keypress/keyup/keydown ) events but ProcessCmdKey
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (timer.Enabled)
            {
                if (keyData == Keys.Down)
                {
                    if (empty.Row - 1 >= 0)
                    {
                        Deplacer(empty, new Position(empty.Row-1, empty.Col),1);
                    }
                    return true;
                }
                if (keyData == Keys.Up)
                {
                    if (empty.Row + 1 < 3)
                    {
                        Deplacer(empty, new Position(empty.Row + 1, empty.Col),2);
                    }
                    return true;
                }
                if (keyData == Keys.Right)
                {
                    if (empty.Col - 1 >= 0)
                    {
                        Deplacer(empty, new Position(empty.Row , empty.Col- 1),3);

                    }
                    return true;
                }
                if (keyData == Keys.Left)
                {

                    if (empty.Col + 1 < 3)
                    {
                        Deplacer(empty, new Position(empty.Row , empty.Col+ 1),4);

                    }
                    return true;
                }
                if (keyData == Keys.Tab)
                {
                    while (!tabpressed(++TabCounter)) ;
                    return true;

                }
                if (keyData == Keys.Enter && focused!= null)
                {
                    var pos = board.GetPositionFromControl(focused);
                    
                    if (pos.Row - empty.Row == -1 && pos.Column - empty.Col == 0)
                    {
                        Deplacer(empty, new Position(pos.Row, pos.Column), 1);
                        focused = null;
                    }
                    else if(pos.Row - empty.Row == 1 && pos.Column - empty.Col == 0)
                    {
                        Deplacer(empty, new Position(pos.Row, pos.Column), 2);
                        focused = null;

                    }
                    else if(pos.Column - empty.Col == -1 && pos.Row - empty.Row == 0)
                    {
                        Deplacer(empty, new Position(pos.Row, pos.Column), 3);
                        focused = null;

                    }
                    else if(pos.Column - empty.Col == 1 && pos.Row - empty.Row == 0)
                    {
                        Deplacer(empty, new Position(pos.Row, pos.Column), 4);
                        focused = null;

                    }

                    return true;

                }
            }

            return base.ProcessCmdKey(ref msg, keyData);
        }
        private bool tabpressed(int n)
        {
            if (TabCounter > 4)
            {
                TabCounter = n = 1;

            }

            switch (n)
            {
                case 1:
                    if (empty.Row + 1 < 3)
                    {
                        focused = (Button) board.GetControlFromPosition(empty.Col, empty.Row + 1);
                        focused.Focus();
                        return true;
                    }
                    break;
                case 2:
                    if (empty.Col - 1 >= 0)
                    {

                        focused = (Button)board.GetControlFromPosition(empty.Col - 1, empty.Row);
                        focused.Focus();
                        return true;
                    }
                    break;
                case 3:
                    if (empty.Row - 1 >= 0)
                    {
                        focused = (Button)board.GetControlFromPosition(empty.Col, empty.Row - 1);
                        focused.Focus();
                        return true;
                    }
                    break;
                case 4:
                    if (empty.Col + 1 < 3)
                    {
                        focused = (Button)board.GetControlFromPosition(empty.Col + 1, empty.Row);
                        focused.Focus();
                        return true;
                    }
                    break;

                default:
                    break;
            }
            return false;
        }
        private bool IsWin()
        {
            string r = "";
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (board.GetControlFromPosition(j, i) != null)
                    { 
                        if(board.GetControlFromPosition(j, i).Text=="")
                            break;
                    else
                        {
                            r += board.GetControlFromPosition(j, i).Text ;
                        }

                    }

                }

            }



            if (r.Equals("12345678") && empty.Row == 2 && empty.Col == 2)
            {
                clock.Text = "00:00";
                timer.Stop();
                start.Enabled = true;
                modes.Enabled = true;
                end.Enabled = false;
                MessageBox.Show("You Win!");
                return true;
            }
            return false;

        }
    }
}
