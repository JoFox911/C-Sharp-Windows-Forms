using System.Windows.Forms;

namespace UnityCourcesTest
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;


        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.GameTitle = new System.Windows.Forms.Label();
            this.buttonRestart = new System.Windows.Forms.Button();
            this.GameStateLabel = new System.Windows.Forms.Label();
            this.buttonSettings = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // GameTitle
            // 
            this.GameTitle.AutoSize = true;
            this.GameTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GameTitle.Location = new System.Drawing.Point(114, 33);
            this.GameTitle.Name = "GameTitle";
            this.GameTitle.Size = new System.Drawing.Size(212, 39);
            this.GameTitle.TabIndex = 0;
            this.GameTitle.Text = "Tic-Tac-Toe";
            // 
            // buttonRestart
            // 
            this.buttonRestart.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRestart.Location = new System.Drawing.Point(100, 518);
            this.buttonRestart.Name = "buttonRestart";
            this.buttonRestart.Size = new System.Drawing.Size(250, 63);
            this.buttonRestart.TabIndex = 2;
            this.buttonRestart.Text = "Restart";
            this.buttonRestart.UseVisualStyleBackColor = true;
            this.buttonRestart.Click += new System.EventHandler(this.ButtonRestart_Click);
            // 
            // GameStateLabel
            // 
            this.GameStateLabel.AutoSize = true;
            this.GameStateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GameStateLabel.Location = new System.Drawing.Point(22, 81);
            this.GameStateLabel.Name = "GameStateLabel";
            this.GameStateLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.GameStateLabel.Size = new System.Drawing.Size(0, 25);
            this.GameStateLabel.TabIndex = 3;
            // 
            // buttonSettings
            // 
            this.buttonSettings.Location = new System.Drawing.Point(357, 17);
            this.buttonSettings.Name = "buttonSettings";
            this.buttonSettings.Size = new System.Drawing.Size(73, 32);
            this.buttonSettings.TabIndex = 4;
            this.buttonSettings.Text = "Settings";
            this.buttonSettings.UseVisualStyleBackColor = true;
            this.buttonSettings.Click += new System.EventHandler(this.ButtonSettings_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(442, 593);
            this.Controls.Add(this.buttonSettings);
            this.Controls.Add(this.GameStateLabel);
            this.Controls.Add(this.buttonRestart);
            this.Controls.Add(this.GameTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.Text = "Tic-Tac-Toe";
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        private System.Windows.Forms.Label GameTitle;
        private Button buttonRestart;
        private Label GameStateLabel;
        private Button buttonSettings;
    }
}

