using System;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TLvov_Connect4
{
    public partial class Form1_Game : Form
    {
        //Global variable assignment:
        int[,] grid = new int[6, 7] {       //Creates two dimensional array for the game board.
                { 0, 0, 0, 0, 0, 0, 0 },
                { 0, 0, 0, 0, 0, 0, 0 },
                { 0, 0, 0, 0, 0, 0, 0 },
                { 0, 0, 0, 0, 0, 0, 0 },
                { 0, 0, 0, 0, 0, 0, 0 },
                { 0, 0, 0, 0, 0, 0, 0 }
            };
        int[] xCounter = new int[7] { 6, 6, 6, 6, 6, 6, 6 };    //Creates one dimensional array for the game's columns.
        int column = 0, player1Score = 0, player2Score = 0;     //Creates integer values to track the desired column for token placement and both players' scores.
        string player1Name, player2Name;                        //Creates strings to track the players' names.
        SolidBrush[] p1 = new SolidBrush[2], p2 = new SolidBrush[2];        //Creates new brushes which will have their colours set layer.
        bool playerTurn = false, gameWon = false, gameActive = false, tickCPU = false;          //Creates bool values to track the current players' turns, whether or not the game has been won yet, whether or not the game is active, and a value to decide how the medium difficulty CPU should play on each turn.

        //Creates the grid on the picturebox for the game board:
        public void CreateBitmapAtRuntime()
        {
            Controls.Add(pictureBoxDisplay);
            Bitmap flag = new Bitmap(pictureBoxDisplay.Width, pictureBoxDisplay.Height);
            Graphics flagGraphics = Graphics.FromImage(flag);
            int numOfCellsX = 7, numOfCellsY = 6, cellSize = 80;
            Pen p = new Pen(Color.Black);
            for (int y = 0; y <= numOfCellsY; ++y)
            {
                flagGraphics.DrawLine(p, 0, y * cellSize, numOfCellsX * cellSize, y * cellSize);    //Draws all horizontal lines of grid.
            }
            for (int x = 0; x <= numOfCellsX; ++x)
            {
                flagGraphics.DrawLine(p, x * cellSize, 0, x * cellSize, numOfCellsY * cellSize);    //Draws all vertical lines of grid.
            }
            pictureBoxDisplay.Image = flag;
        }

        //Makes sure that after each turn, the token gets placed in the correct place in the right colour, the CheckWin subroutine is ran, and the game switches to the next player's turn.
        private void AfterEachTurn()
        {
            xCounter[column]--;         //Since only 6 tokens can fit in each column, the xCounter needs to keep track of this, so a value is taken away each time a column is played.
            if (playerTurn == false)    //If statement determines whether it is Player 1 or Player 2's turn.
            {
                grid[xCounter[column], column] = 1;
            }
            else
            {
                grid[xCounter[column], column] = 10;
            }
        //Drawing on the PictureBox to represent the game:
            var bmp = pictureBoxDisplay.Image;
            using (var flagGraphics = Graphics.FromImage(bmp))
            {
                int n = 0;
                if (playerTurn == true)
                {
                    n = 1;
                }
                flagGraphics.FillEllipse(p1[n], column * 80, xCounter[column] * 80, 80, 80);            
                flagGraphics.FillEllipse(p2[n], column * 80 + 8, xCounter[column] * 80 + 8, 64, 64);
                pictureBoxDisplay.Image = bmp;
            }
            playerTurn = !playerTurn;       //Sets playerTurn to the opposite value it currently is. 
        //For statements to split the board into multiple 4x4 grids:
            for (int y = 0; y <= 3; y++)    
            {
                for (int x = 0; x <= 2; x++)
                {
                    CheckWin(x, y); 
                }
            }
            if (playerTurn == false)
            {
                rTxtBoxInfo.Text = "It is currently " + player1Name + "'s turn!";
            }
            else
            {
                rTxtBoxInfo.Text = "It is currently " + player2Name + "'s turn!";
            }
        }

        //Checks for all possible win conditions, and runs the WinnerFound subroutine if that is the case.
        private void CheckWin(int x, int y)
        {
            int tempColumn, tempRow;
        //Checks for horizontal wins:
            for (tempRow = y; tempRow <= y + 3; tempRow++)
            {
                int total = 0;
                for (tempColumn = x; tempColumn <= x + 3; tempColumn++)
                {
                    total += grid[tempColumn, tempRow];
                }
                if (total == 4 || total == 40)
                {
                    gameWon = true;
                    WinnerFound(total, x, x + 3, y + 3, y);
                }
            }
            if (gameWon == false)
            {
            //Checks for vertical wins:
                for (tempColumn = x; tempColumn <= x + 3; tempColumn++)
                {
                    int total = 0;
                    for (tempRow = y; tempRow <= y + 3; tempRow++)
                    {
                        total += grid[tempColumn, tempRow];
                    }
                    if (total == 4 || total == 40)
                    {
                        gameWon = true;
                        WinnerFound(total, x, x + 3, y + 3, y);
                    }
                }
            }
        //Checks for diagonal wins in one direction:
            if (gameWon == false)
            {
                int total = grid[x, y + 3] + grid[x + 1, y + 2] + grid[x + 2, y + 1] + grid[x + 3, y];
                if (total == 4 || total == 40)
                {
                    gameWon = true;
                    WinnerFound(total, x, x + 3, y + 3, y);
                }
            }
        //Checks for diagonal wins in the other direction:
            if (gameWon == false)
            {
                int total = grid[x, y] + grid[x + 1, y + 1] + grid[x + 2, y + 2] + grid[x + 3, y + 3];
                if (total == 4 || total == 40)
                {
                    gameWon = true;
                    WinnerFound(total, x, x + 3, y, y + 3);
                }
            }
        }

        //Similar to the CheckWin subroutine, but is to help the CPU choose where to place its token, either blocking the player's win or ensuring its own if possible.
        private int CheckPossibleWin(int x, int y)
        {
            int tempColumn, tempRow, flagX = 0;
            for (tempRow = y; tempRow <= y + 3; tempRow++)
            {
                int total = 0;
                for (tempColumn = x; tempColumn <= x + 3; tempColumn++)
                {
                    if (grid[tempColumn, tempRow] == 0)
                    {
                        flagX = tempColumn; //"flagX" represents a black space in a potential four-in-a-row.
                    }
                    total += grid[tempColumn, tempRow];
                }
                if (total == 3 || total == 30)
                {
                    return flagX;           //If the total sums to 3 or 30 (a four-in-a-row with a token missing) it returns "flagX", which marks the column of the missing token.
                }
            }
            for (tempColumn = x; tempColumn <= x + 3; tempColumn++)
            {
                int total = 0;
                for (tempRow = y; tempRow <= y + 3; tempRow++)
                {
                    if (grid[tempColumn, tempRow] == 0)
                    {
                        flagX = tempColumn;
                    }
                    total += grid[tempColumn, tempRow];
                }
                if (total == 3 || total == 30)
                {
                    return flagX;
                }
            }
            return 8;   //Returns an impossible value if no move is already presented, this will cause the previous subroutine to generate a random valid move.
        }

        //Displays relevant MessageBox alerting the player of a win, and either closes the program or resets the game depending on the player's choice.
        private void WinnerFound(int total, int x1, int x2, int y1, int y2)
        {
            //var bmp = pictureBoxDisplay.Image;
            //using (var flagGraphics = Graphics.FromImage(bmp))
            //{
            //Pen p = new Pen(Color.Black);
            //flagGraphics.DrawLine(p, x1 * 80, y1 * 80, x2 * 80, y2 * 80);
            //pictureBoxDisplay.Image = bmp;
            //}
            if (playerTurn == true)
            {
                player1Score++;
                DialogResult theResponse = MessageBox.Show(player1Name + " Has won!!\nDo you want to play again?", "END", MessageBoxButtons.YesNo);
                if (theResponse == DialogResult.No)
                {
                    Close();
                }
                else
                {
                    ResetGame();
                }
                lblPlayer1Score.Text = player1Name + "'s score: " + player1Score;
            }
            else
            {
                player2Score++;
                DialogResult theResponse = MessageBox.Show(player2Name + " Has won!!\nDo you want to play again?", "END", MessageBoxButtons.YesNo);
                if (theResponse == DialogResult.No)
                {
                    Close();
                }
                else
                {
                    ResetGame();
                }
                lblPlayer2Score.Text = player2Name + "'s score: " + player2Score;
            }
        }

        //Subroutine that allows the CPU to decide where to place its token.
        private async void EnemyCPU()
        {
            if (gameActive == true)
            {
                //Easy CPU: Plays randomly every round.
                if (radCmdGame1.Checked == true)            
                {
                    pictureBoxDisplay.Enabled = false;
                    await Task.Delay(200);
                    Random random = new Random();
                    column = random.Next(0, 6);
                    while (xCounter[column] == 0)
                    {
                        column = random.Next(0, 6);
                    }
                    pictureBoxDisplay.Enabled = true;
                    AfterEachTurn();
                }

                //Medium CPU: Switches between Easy and Hard CPU behaviour each round.
                else if (radCmdGame2.Checked == true)
                {
                    pictureBoxDisplay.Enabled = false;
                    await Task.Delay(200);
                    if (tickCPU == false)
                    {
                        Random random = new Random();
                        column = random.Next(0, 6);
                        while (xCounter[column] == 0)
                        {
                            column = random.Next(0, 6);
                        }
                        AfterEachTurn();
                    }
                    else
                    {
                        for (int y = 0; y <= 2; y++)
                        {
                            for (int x = 0; x <= 2; x++)
                            {
                                column = CheckPossibleWin(x, y);
                            }
                        }
                        if (column == 8 || xCounter[column] == 0)
                        {
                            Random random = new Random();
                            column = random.Next(0, 6);
                            while (xCounter[column] == 0)
                            {
                                column = random.Next(0, 6);
                            }
                        }
                        AfterEachTurn();
                    }
                    pictureBoxDisplay.Enabled = true;
                    tickCPU = !tickCPU;
                }

                //Hard CPU: Looks for four-in-a-rows with a gap in them, and tries to fill in that gap, if not possible, plays randomly. (I've struggled to make this work consistently, the CPU will only occasionally successfully fill in a four-in-a-row, and usually resorts to playing randomly)
                else if (radCmdGame3.Checked == true)
                {
                    column = FindMove();
                    AfterEachTurn();
                }
            }
        }

        private int FindMove()
        {
            for (int i = 0; i < 7; i++)
            {
                int[,] newGrid = grid;
                int[] newXCounter = xCounter;
                bool newGameWon = false;
                newXCounter[i]--;
                newGrid[newXCounter[i], i] = 10;
                for (int y = 0; y <= 3; y++)
                {
                    for (int x = 0; x <= 2; x++)
                    {
                        int tempColumn, tempRow;
                        //Checks for horizontal wins:
                        for (tempRow = y; tempRow <= y + 3; tempRow++)
                        {
                            int total = 0;
                            for (tempColumn = x; tempColumn <= x + 3; tempColumn++)
                            {
                                total += newGrid[tempColumn, tempRow];
                            }
                            if (total == 4 || total == 40)
                            {
                                newGameWon = true;
                                return i;
                            }
                        }
                        if (newGameWon == false)
                        {
                            //Checks for vertical wins:
                            for (tempColumn = x; tempColumn <= x + 3; tempColumn++)
                            {
                                int total = 0;
                                for (tempRow = y; tempRow <= y + 3; tempRow++)
                                {
                                    total += newGrid[tempColumn, tempRow];
                                }
                                if (total == 4 || total == 40)
                                {
                                    newGameWon = true;
                                    return i;
                                }
                            }
                        }
                    }
                }
            }
            Random random = new Random();
            int m = random.Next(0, 6);
            while (xCounter[m] == 0)
            {
                m = random.Next(0, 6);
            }
            return m;
        }

        //Resets the board and all relevant values.
        private void ResetGame()
        {
            CreateBitmapAtRuntime();
            grid = new int[6, 7] {
                { 0, 0, 0, 0, 0, 0, 0 },
                { 0, 0, 0, 0, 0, 0, 0 },
                { 0, 0, 0, 0, 0, 0, 0 },
                { 0, 0, 0, 0, 0, 0, 0 },
                { 0, 0, 0, 0, 0, 0, 0 },
                { 0, 0, 0, 0, 0, 0, 0 }
            };
            xCounter = new int[7] { 6, 6, 6, 6, 6, 6, 6 };
            column = 0; playerTurn = false; gameWon = false;
            gameActive = false;
            cmdStartGame.Enabled = true;
            pictureBoxDisplay.Enabled = false;
            grpBoxPlayer1Options.Enabled = true;
            grpBoxPlayer2Options.Enabled = true;
            grpBoxThemeOptions.Enabled = true;
            grpBoxDifficulty.Enabled = true;
            rTxtBoxInfo.Text = "";
        }

        //Runs the ResetGame subroutine
        private void cmdResetGame_Click(object sender, EventArgs e)
        {
            ResetGame();
        }

        //Changes the theme to "Metallic".
        private void radCmdThemeMetal_CheckedChanged(object sender, EventArgs e)
        {
            BackColor = Color.DimGray;
            grpBoxDifficulty.ForeColor = Color.White;
            grpBoxPlayer1Options.ForeColor = Color.White;
            grpBoxPlayer2Options.ForeColor = Color.White;
            grpBoxThemeOptions.ForeColor = Color.White;
            lblPlayer1Score.ForeColor = Color.White;
            lblPlayer2Score.ForeColor = Color.White;
            lblVS.ForeColor = Color.White;
            pictureBoxDisplay.BackColor = Color.DarkGray;
            txtBoxVersusPlayer1.BackColor = Color.DarkGray;
            txtBoxVersusPlayer2.BackColor = Color.DarkGray;
            txtBoxPlayer1Name.BackColor = Color.DarkGray;
            txtBoxPlayer2Name.BackColor = Color.DarkGray;
            rTxtBoxInfo.BackColor = Color.DarkGray;
            cmdStartGame.BackColor = Color.DarkGray;
            cmdResetGame.BackColor = Color.DarkGray;
        }

        //Changes the theme to "Wooden".
        private void radCmdThemeWood_CheckedChanged(object sender, EventArgs e)
        {
            BackColor = Color.Sienna;
            grpBoxDifficulty.ForeColor = Color.White;
            grpBoxPlayer1Options.ForeColor = Color.White;
            grpBoxPlayer2Options.ForeColor = Color.White;
            grpBoxThemeOptions.ForeColor = Color.White;
            lblPlayer1Score.ForeColor = Color.White;
            lblPlayer2Score.ForeColor = Color.White;
            lblVS.ForeColor = Color.White;
            pictureBoxDisplay.BackColor = Color.Peru;
            txtBoxVersusPlayer1.BackColor = Color.Peru;
            txtBoxVersusPlayer2.BackColor = Color.Peru;
            txtBoxPlayer1Name.BackColor = Color.Peru;
            txtBoxPlayer2Name.BackColor = Color.Peru;
            rTxtBoxInfo.BackColor = Color.Peru;
            cmdStartGame.BackColor = Color.Peru;
            cmdResetGame.BackColor = Color.Peru;
        }

        //Changes the theme to "Pastel".
        private void radCmdThemePastel_CheckedChanged(object sender, EventArgs e)
        {
            BackColor = Color.Thistle;
            grpBoxDifficulty.ForeColor = DefaultForeColor;
            grpBoxPlayer1Options.ForeColor = DefaultForeColor;
            grpBoxPlayer2Options.ForeColor = DefaultForeColor;
            grpBoxThemeOptions.ForeColor = DefaultForeColor;
            lblPlayer1Score.ForeColor = DefaultForeColor;
            lblPlayer2Score.ForeColor = DefaultForeColor;
            lblVS.ForeColor = DefaultForeColor;
            pictureBoxDisplay.BackColor = Color.LavenderBlush;
            txtBoxVersusPlayer1.BackColor = Color.LavenderBlush;
            txtBoxVersusPlayer2.BackColor = Color.LavenderBlush;
            txtBoxPlayer1Name.BackColor = Color.LavenderBlush;
            txtBoxPlayer2Name.BackColor = Color.LavenderBlush;
            rTxtBoxInfo.BackColor = Color.LavenderBlush;
            cmdStartGame.BackColor = Color.LavenderBlush;
            cmdResetGame.BackColor = Color.LavenderBlush;
        }

        //Changes the theme to "System".
        private void radCmdThemeSystem_CheckedChanged(object sender, EventArgs e)
        {
            BackColor = DefaultBackColor;
            grpBoxDifficulty.ForeColor = DefaultForeColor;
            grpBoxPlayer1Options.ForeColor = DefaultForeColor;
            grpBoxPlayer2Options.ForeColor = DefaultForeColor;
            grpBoxThemeOptions.ForeColor = DefaultForeColor;
            lblPlayer1Score.ForeColor = DefaultForeColor;
            lblPlayer2Score.ForeColor = DefaultForeColor;
            lblVS.ForeColor = DefaultForeColor;
            pictureBoxDisplay.BackColor = DefaultBackColor;
            txtBoxVersusPlayer1.BackColor = DefaultBackColor;
            txtBoxVersusPlayer2.BackColor = DefaultBackColor;
            txtBoxPlayer1Name.BackColor = DefaultBackColor;
            txtBoxPlayer2Name.BackColor = DefaultBackColor;
            rTxtBoxInfo.BackColor = DefaultBackColor;
            cmdStartGame.BackColor = DefaultBackColor;
            cmdResetGame.BackColor = DefaultBackColor;
        }

        //Changes relevant values when radCmdGamePVP is either checked or unchecked.
        private void radCmdGamePVP_CheckedChanged(object sender, EventArgs e)
        {
            txtBoxPlayer2Name.Text = "Computer";
            txtBoxPlayer2Name.Enabled = radCmdGamePVP.Checked;
            if (radCmdGamePVP.Checked == true)
            {
                txtBoxPlayer2Name.Text = "";
            }
        }

        //Determines where the token should go depending on where in the PictureBox the player clicks, then runs the AfterEachTurn subroutine, if a CPU enemy is enabled, it will run that after the player's turn.
        private void pictureBoxDisplay_Click(object sender, EventArgs e)
        {
            MouseEventArgs me = (MouseEventArgs)e;
            int x = me.X;   //Finds the x co-ordinate of the mouseclick, in relation to the position of the PictureBox.
        //If statements determine which column is correct for the mouseclick.
            if (x <= 80)
            {
                column = 0;
            }
            else if (x <= 160)
            {
                column = 1;
            }
            else if (x <= 240)
            {
                column = 2;
            }
            else if (x <= 320)
            {
                column = 3;
            }
            else if (x <= 400)
            {
                column = 4;
            }
            else if (x <= 480)
            {
                column = 5;
            }
            else
            {
                column = 6;
            }
            if (xCounter[column] > 0)   //Ensures the click only achieves anything if the column is valid.
            {
                AfterEachTurn();
            }
            else                        //Lets the player know if the column is full.
            {
                rTxtBoxInfo.Text += "\nThis column is full, please try another one.";
            }
            if (radCmdGamePVP.Checked == false)
            {
                EnemyCPU();             //If an enemy CPU is enabled, it plays its turn.
            }
        }
        
        //Begins the game.
        private void cmdStartGame_Click(object sender, EventArgs e)
        {
            cmdStartGame.Enabled = false;
            gameActive = true;
            pictureBoxDisplay.Enabled = true;
            if (radCmdPlayer1Yellow.Checked == true)
            {
                p1[0] = new SolidBrush(Color.Yellow);
                p2[0] = new SolidBrush(Color.Gold);
                txtBoxVersusPlayer1.BackColor = Color.Yellow;
            }
            else
            {
                p1[0] = new SolidBrush(Color.Red);
                p2[0] = new SolidBrush(Color.Salmon);
                txtBoxVersusPlayer1.BackColor = Color.Red;
            }
            if (radCmdPlayer2Green.Checked == true)
            {
                p1[1] = new SolidBrush(Color.Green);
                p2[1] = new SolidBrush(Color.MediumSpringGreen);
                txtBoxVersusPlayer2.BackColor = Color.Green;
            }
            else
            {
                p1[1] = new SolidBrush(Color.Blue);
                p2[1] = new SolidBrush(Color.SteelBlue);
                txtBoxVersusPlayer2.BackColor = Color.Blue;
            }
            if (txtBoxPlayer1Name.Text != "")
            {
                player1Name = txtBoxPlayer1Name.Text;
            }
            else
            {
                player1Name = "Player 1";
            }
            if (txtBoxPlayer2Name.Text != "")
            {
                player2Name = txtBoxPlayer2Name.Text;
            }
            else
            {
                player2Name = "Player 2";
            }
            txtBoxVersusPlayer1.Text = player1Name;
            txtBoxVersusPlayer2.Text = player2Name;
            grpBoxPlayer1Options.Enabled = false;       //All groupboxes are disabled to prevent option-changing whilst a game is running.
            grpBoxPlayer2Options.Enabled = false;
            grpBoxThemeOptions.Enabled = false;
            grpBoxDifficulty.Enabled = false;
            rTxtBoxInfo.Text = "It is currently " + player1Name + "'s turn!";
            lblPlayer1Score.Text = player1Name + "'s score: " + player1Score;
            lblPlayer2Score.Text = player2Name + "'s score: " + player2Score;
        }

        public Form1_Game()
        {
            InitializeComponent();
            CreateBitmapAtRuntime();
        }
    }
}
