using System;
using System.Windows.Forms;
using UnityCourcesTest.Classes;

namespace UnityCourcesTest
{
    public partial class MainForm : Form
    {
        public int boardSize = 3;
        private GameController GameController;

        public MainForm() {
            InitializeComponent();
            GameController = new GameController(this, boardSize);
            GameController.GenerateBoard();
        }

        public void SetPlayersNames(string PlayerXName, string PlayerOName) {
            GameController.SetPlayersNames(PlayerXName, PlayerOName);
        }


        public void SetGameStateMessage(string message)
        {
            GameStateLabel.Text = message;
        }

        public (string, string) GetPlaayersNames()
        {
            return GameController.GetPlayersNames();
        }

        private void ButtonRestart_Click(object sender, EventArgs e)
        {
            GameController.Restart();
        }

        private void ButtonSettings_Click(object sender, EventArgs e)
        {
            ShowSettingsForm();
        }

        private void ShowSettingsForm()
        {
            SettingsForm settingsForm = new SettingsForm(this);
            settingsForm.Show();
        }
    }
}
