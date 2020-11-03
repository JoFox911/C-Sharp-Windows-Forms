using System;
using System.Windows.Forms;
using System.Drawing;

namespace UnityCourcesTest.Classes
{
    class GameController
    {
        public const int OffsetHorizontal = 20;
        public const int OffsetTop = 100;

        protected Button[,] Board;
        protected Player XPlayer;
        protected Player OPlayer;
        protected Player CurrentPlayer;
        protected MainForm ParentForm;

        public bool IsGameFinished { get; set; }
        public int BoardSize { get; set; }
        public int BtnSize { get; set; }


        public GameController(MainForm parent, int boardSize) {
            this.BoardSize = boardSize;
            ParentForm = parent;

            BtnSize = (parent.Width - (2 * OffsetHorizontal)) / boardSize;
            IsGameFinished = false;

            Board = new Button[boardSize, boardSize];
            XPlayer = new Player("X");
            OPlayer = new Player("O");
            SetCurrentPlayer(XPlayer);
        }

        public void GenerateBoard()
        {
            for (int row = 0; row < BoardSize; row++)
            {
                for (int column = 0; column < BoardSize; column++)
                {
                    Button btn = new Button();
                    btn.Text = String.Empty;
                    btn.Location = new Point(OffsetHorizontal + row * BtnSize, OffsetTop + column * BtnSize);
                    btn.Size = new Size(BtnSize, BtnSize);
                    btn.FlatStyle = FlatStyle.Flat;
                    btn.Click += new EventHandler(ClickOnCell);

                    ParentForm.Controls.Add(btn);
                    Board[row, column] = btn;
                }
            }
        }

        public void SetCurrentPlayer(Player player)
        {
            CurrentPlayer = player;
            UpdatePlayerTurnMessage();
        }

        private void ClickOnCell(object sender, EventArgs e)
        {
            if (!IsGameFinished)
            {
                Button btn = sender as Button;
                if (btn.Text == String.Empty)
                {
                    btn.Text = CurrentPlayer.Mark;

                    ChechGameState();
                    if (!IsGameFinished)
                    {
                        SwitchPlayer();
                    }
                }
            }
        }

        public void SwitchPlayer()
        {
            if (CurrentPlayer == XPlayer)
            {
                SetCurrentPlayer(OPlayer);
            }
            else
            {
                SetCurrentPlayer(XPlayer);
            }
        }


        public void ChechGameState()
        {
            if (FindAndColorizeWinCombination())
            {
                IsGameFinished = true;
                string message = $" Player {CurrentPlayer.Name} won the game!!";
                ParentForm.SetGameStateMessage(message);
            }
            else if (!IsEmptyCellExists()) 
            {
                IsGameFinished = true;
                string message = $"Oh noooo! Draw!! Let's play again!";
                ParentForm.SetGameStateMessage(message);
            }

        }

        public bool IsEmptyCellExists()
        {
            for (int i = 0; i < BoardSize; i++)
            {
                for (int j = 0; j < BoardSize; j++)
                {
                    if (Board[i, j].Text == String.Empty) 
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        public bool FindAndColorizeWinCombination() {
            bool isLeftToRightDiagonal = true;
            bool isRightToLeftDiagonal = true;

            for (int i = 0; i < BoardSize; i++) 
            {
                bool isHorizontalExists = true;
                bool isVerticalExists = true;
                for (int j = 0; j < BoardSize; j++) {
                    if (Board[i, j].Text != CurrentPlayer.Mark) 
                    {
                        isHorizontalExists = false;
                    }
                    if (Board[j, i].Text != CurrentPlayer.Mark) 
                    {
                        isVerticalExists = false;
                    }
                    if (i == j && Board[i, j].Text != CurrentPlayer.Mark) 
                    {
                        isLeftToRightDiagonal = false;
                    }

                    if (i == (BoardSize -1) - j && Board[i, j].Text != CurrentPlayer.Mark) 
                    {
                        isRightToLeftDiagonal = false;
                    }
                }
                if (isHorizontalExists || isVerticalExists) 
                {
                    if (isHorizontalExists) {
                        for(int j = 0; j < BoardSize; j++) 
                        {
                            Board[i, j].BackColor = Color.Green;
                        }   
                    }
                    if (isVerticalExists){
                        for (int j = 0; j < BoardSize; j++)
                        {
                            Board[j, i].BackColor = Color.Green;
                        }
                    }
                    return true;
                }
            }
            if (isLeftToRightDiagonal) 
            {
                for (int i = 0; i < BoardSize; i++)
                {
                    Board[i, i].BackColor = Color.Green;
                }
            }
            if (isRightToLeftDiagonal)
            {
                for (int i = 0; i < BoardSize; i++)
                {
                    Board[i, (BoardSize - 1) - i].BackColor = Color.Green;
                }
            }
            return isLeftToRightDiagonal || isRightToLeftDiagonal;
        }

        public void Restart()
        {
            SetCurrentPlayer(XPlayer);
            IsGameFinished = false;

            for (int row = 0; row < BoardSize; row++)
            {
                for (int column = 0; column < BoardSize; column++)
                {
                    Board[row, column].Text = String.Empty;
                    Board[row, column].BackColor = Color.Empty;
                }
            }            
        }

        public void SetPlayersNames(string PlayerXName, string PlayerOName)
        {
            XPlayer.Name = PlayerXName;
            OPlayer.Name = PlayerOName;
            UpdatePlayerTurnMessage();
        }

        public (string, string) GetPlayersNames()
        {
            return (XPlayer.Name, OPlayer.Name);
        }

        private void UpdatePlayerTurnMessage()
        {
            if (!IsGameFinished)
            {
                string message = $"Player {CurrentPlayer.Name} ({CurrentPlayer.Mark}) turn!";
                ParentForm.SetGameStateMessage(message);
            }
        }
    }
}
