﻿namespace UnityCourcesTest
{
    partial class SettingsForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.playerXNameTextBox = new System.Windows.Forms.TextBox();
            this.playerONameTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // playerXNameTextBox
            // 
            this.playerXNameTextBox.Location = new System.Drawing.Point(170, 43);
            this.playerXNameTextBox.MaxLength = 40;
            this.playerXNameTextBox.Name = "playerXNameTextBox";
            this.playerXNameTextBox.Size = new System.Drawing.Size(305, 22);
            this.playerXNameTextBox.TabIndex = 0;
            // 
            // playerONameTextBox
            // 
            this.playerONameTextBox.Location = new System.Drawing.Point(170, 92);
            this.playerONameTextBox.MaxLength = 40;
            this.playerONameTextBox.Name = "playerONameTextBox";
            this.playerONameTextBox.Size = new System.Drawing.Size(305, 22);
            this.playerONameTextBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "\"X\" Player name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "\"O\" Player name";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(181, 140);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(136, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Confirm";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(496, 175);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.playerONameTextBox);
            this.Controls.Add(this.playerXNameTextBox);
            this.Name = "SettingsForm";
            this.Text = "UserLabels";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox playerXNameTextBox;
        private System.Windows.Forms.TextBox playerONameTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
    }
}