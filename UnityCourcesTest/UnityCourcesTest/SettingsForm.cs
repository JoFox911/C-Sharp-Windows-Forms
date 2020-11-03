using System;
using System.Windows.Forms;

namespace UnityCourcesTest
{
    public partial class SettingsForm : Form
    {
        private MainForm parentForm;
        public SettingsForm()
        {
            InitializeComponent();
        }

        public SettingsForm(MainForm form)
        {
            InitializeComponent();
            parentForm = form;

            (string xPlayerName, string oPlayerName) = parentForm.GetPlaayersNames();
            this.playerXNameTextBox.Text = xPlayerName;
            this.playerONameTextBox.Text = oPlayerName;

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            string PlayerXName = this.playerXNameTextBox.Text != String.Empty 
                                    ? this.playerXNameTextBox.Text
                                    : "PlayerX";
            string PlayerOName = this.playerONameTextBox.Text != String.Empty
                                    ? this.playerONameTextBox.Text
                                    : "PlayerO";
            parentForm.SetPlayersNames(PlayerXName, PlayerOName);
            Close();
        }
    }
}
