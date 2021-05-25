namespace TLvov_Connect4
{
    partial class Form1_Game
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
            this.pictureBoxDisplay = new System.Windows.Forms.PictureBox();
            this.grpBoxDifficulty = new System.Windows.Forms.GroupBox();
            this.radCmdGamePVP = new System.Windows.Forms.RadioButton();
            this.radCmdGame1 = new System.Windows.Forms.RadioButton();
            this.radCmdGame2 = new System.Windows.Forms.RadioButton();
            this.radCmdGame3 = new System.Windows.Forms.RadioButton();
            this.grpBoxThemeOptions = new System.Windows.Forms.GroupBox();
            this.radCmdThemeSystem = new System.Windows.Forms.RadioButton();
            this.radCmdThemePastel = new System.Windows.Forms.RadioButton();
            this.radCmdThemeWood = new System.Windows.Forms.RadioButton();
            this.radCmdThemeMetal = new System.Windows.Forms.RadioButton();
            this.radCmdPlayer1Red = new System.Windows.Forms.RadioButton();
            this.radCmdPlayer1Yellow = new System.Windows.Forms.RadioButton();
            this.grpBoxPlayer1Options = new System.Windows.Forms.GroupBox();
            this.txtBoxPlayer1Name = new System.Windows.Forms.TextBox();
            this.cmdStartGame = new System.Windows.Forms.Button();
            this.grpBoxPlayer2Options = new System.Windows.Forms.GroupBox();
            this.radCmdPlayer2Green = new System.Windows.Forms.RadioButton();
            this.radCmdPlayer2Blue = new System.Windows.Forms.RadioButton();
            this.txtBoxPlayer2Name = new System.Windows.Forms.TextBox();
            this.lblVS = new System.Windows.Forms.Label();
            this.txtBoxVersusPlayer1 = new System.Windows.Forms.TextBox();
            this.txtBoxVersusPlayer2 = new System.Windows.Forms.TextBox();
            this.rTxtBoxInfo = new System.Windows.Forms.RichTextBox();
            this.lblPlayer1Score = new System.Windows.Forms.Label();
            this.lblPlayer2Score = new System.Windows.Forms.Label();
            this.cmdResetGame = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDisplay)).BeginInit();
            this.grpBoxDifficulty.SuspendLayout();
            this.grpBoxThemeOptions.SuspendLayout();
            this.grpBoxPlayer1Options.SuspendLayout();
            this.grpBoxPlayer2Options.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBoxDisplay
            // 
            this.pictureBoxDisplay.BackColor = System.Drawing.Color.DarkGray;
            this.pictureBoxDisplay.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxDisplay.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxDisplay.Enabled = false;
            this.pictureBoxDisplay.Location = new System.Drawing.Point(62, 34);
            this.pictureBoxDisplay.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBoxDisplay.Name = "pictureBoxDisplay";
            this.pictureBoxDisplay.Size = new System.Drawing.Size(563, 483);
            this.pictureBoxDisplay.TabIndex = 0;
            this.pictureBoxDisplay.TabStop = false;
            this.pictureBoxDisplay.Click += new System.EventHandler(this.pictureBoxDisplay_Click);
            // 
            // grpBoxDifficulty
            // 
            this.grpBoxDifficulty.BackColor = System.Drawing.Color.Transparent;
            this.grpBoxDifficulty.Controls.Add(this.radCmdGamePVP);
            this.grpBoxDifficulty.Controls.Add(this.radCmdGame1);
            this.grpBoxDifficulty.Controls.Add(this.radCmdGame2);
            this.grpBoxDifficulty.Controls.Add(this.radCmdGame3);
            this.grpBoxDifficulty.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpBoxDifficulty.ForeColor = System.Drawing.Color.White;
            this.grpBoxDifficulty.Location = new System.Drawing.Point(892, 387);
            this.grpBoxDifficulty.Name = "grpBoxDifficulty";
            this.grpBoxDifficulty.Size = new System.Drawing.Size(173, 133);
            this.grpBoxDifficulty.TabIndex = 1;
            this.grpBoxDifficulty.TabStop = false;
            this.grpBoxDifficulty.Text = "Game Options";
            // 
            // radCmdGamePVP
            // 
            this.radCmdGamePVP.AutoSize = true;
            this.radCmdGamePVP.Checked = true;
            this.radCmdGamePVP.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radCmdGamePVP.Location = new System.Drawing.Point(6, 20);
            this.radCmdGamePVP.Name = "radCmdGamePVP";
            this.radCmdGamePVP.Size = new System.Drawing.Size(103, 17);
            this.radCmdGamePVP.TabIndex = 11;
            this.radCmdGamePVP.TabStop = true;
            this.radCmdGamePVP.Text = "Player VS Player";
            this.radCmdGamePVP.UseVisualStyleBackColor = true;
            this.radCmdGamePVP.CheckedChanged += new System.EventHandler(this.radCmdGamePVP_CheckedChanged);
            // 
            // radCmdGame1
            // 
            this.radCmdGame1.AutoSize = true;
            this.radCmdGame1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radCmdGame1.Location = new System.Drawing.Point(6, 43);
            this.radCmdGame1.Name = "radCmdGame1";
            this.radCmdGame1.Size = new System.Drawing.Size(116, 17);
            this.radCmdGame1.TabIndex = 12;
            this.radCmdGame1.Text = "Player VS Easy Bot";
            this.radCmdGame1.UseVisualStyleBackColor = true;
            // 
            // radCmdGame2
            // 
            this.radCmdGame2.AutoSize = true;
            this.radCmdGame2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radCmdGame2.Location = new System.Drawing.Point(6, 66);
            this.radCmdGame2.Name = "radCmdGame2";
            this.radCmdGame2.Size = new System.Drawing.Size(130, 17);
            this.radCmdGame2.TabIndex = 13;
            this.radCmdGame2.Text = "Player VS Medium Bot";
            this.radCmdGame2.UseVisualStyleBackColor = true;
            // 
            // radCmdGame3
            // 
            this.radCmdGame3.AutoSize = true;
            this.radCmdGame3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radCmdGame3.Location = new System.Drawing.Point(6, 89);
            this.radCmdGame3.Name = "radCmdGame3";
            this.radCmdGame3.Size = new System.Drawing.Size(116, 17);
            this.radCmdGame3.TabIndex = 14;
            this.radCmdGame3.Text = "Player VS Hard Bot";
            this.radCmdGame3.UseVisualStyleBackColor = true;
            // 
            // grpBoxThemeOptions
            // 
            this.grpBoxThemeOptions.BackColor = System.Drawing.Color.Transparent;
            this.grpBoxThemeOptions.Controls.Add(this.radCmdThemeSystem);
            this.grpBoxThemeOptions.Controls.Add(this.radCmdThemePastel);
            this.grpBoxThemeOptions.Controls.Add(this.radCmdThemeWood);
            this.grpBoxThemeOptions.Controls.Add(this.radCmdThemeMetal);
            this.grpBoxThemeOptions.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpBoxThemeOptions.ForeColor = System.Drawing.Color.White;
            this.grpBoxThemeOptions.Location = new System.Drawing.Point(671, 387);
            this.grpBoxThemeOptions.Name = "grpBoxThemeOptions";
            this.grpBoxThemeOptions.Size = new System.Drawing.Size(173, 133);
            this.grpBoxThemeOptions.TabIndex = 2;
            this.grpBoxThemeOptions.TabStop = false;
            this.grpBoxThemeOptions.Text = "Theme Options";
            // 
            // radCmdThemeSystem
            // 
            this.radCmdThemeSystem.AutoSize = true;
            this.radCmdThemeSystem.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radCmdThemeSystem.Location = new System.Drawing.Point(6, 89);
            this.radCmdThemeSystem.Name = "radCmdThemeSystem";
            this.radCmdThemeSystem.Size = new System.Drawing.Size(59, 17);
            this.radCmdThemeSystem.TabIndex = 3;
            this.radCmdThemeSystem.Text = "System";
            this.radCmdThemeSystem.UseVisualStyleBackColor = true;
            this.radCmdThemeSystem.CheckedChanged += new System.EventHandler(this.radCmdThemeSystem_CheckedChanged);
            // 
            // radCmdThemePastel
            // 
            this.radCmdThemePastel.AutoSize = true;
            this.radCmdThemePastel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radCmdThemePastel.Location = new System.Drawing.Point(6, 66);
            this.radCmdThemePastel.Name = "radCmdThemePastel";
            this.radCmdThemePastel.Size = new System.Drawing.Size(54, 17);
            this.radCmdThemePastel.TabIndex = 2;
            this.radCmdThemePastel.Text = "Pastel";
            this.radCmdThemePastel.UseVisualStyleBackColor = true;
            this.radCmdThemePastel.CheckedChanged += new System.EventHandler(this.radCmdThemePastel_CheckedChanged);
            // 
            // radCmdThemeWood
            // 
            this.radCmdThemeWood.AutoSize = true;
            this.radCmdThemeWood.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radCmdThemeWood.Location = new System.Drawing.Point(6, 43);
            this.radCmdThemeWood.Name = "radCmdThemeWood";
            this.radCmdThemeWood.Size = new System.Drawing.Size(66, 17);
            this.radCmdThemeWood.TabIndex = 1;
            this.radCmdThemeWood.Text = "Wooden";
            this.radCmdThemeWood.UseVisualStyleBackColor = true;
            this.radCmdThemeWood.CheckedChanged += new System.EventHandler(this.radCmdThemeWood_CheckedChanged);
            // 
            // radCmdThemeMetal
            // 
            this.radCmdThemeMetal.AutoSize = true;
            this.radCmdThemeMetal.Checked = true;
            this.radCmdThemeMetal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radCmdThemeMetal.Location = new System.Drawing.Point(6, 20);
            this.radCmdThemeMetal.Name = "radCmdThemeMetal";
            this.radCmdThemeMetal.Size = new System.Drawing.Size(61, 17);
            this.radCmdThemeMetal.TabIndex = 0;
            this.radCmdThemeMetal.TabStop = true;
            this.radCmdThemeMetal.Text = "Metallic";
            this.radCmdThemeMetal.UseVisualStyleBackColor = true;
            this.radCmdThemeMetal.CheckedChanged += new System.EventHandler(this.radCmdThemeMetal_CheckedChanged);
            // 
            // radCmdPlayer1Red
            // 
            this.radCmdPlayer1Red.AutoSize = true;
            this.radCmdPlayer1Red.Checked = true;
            this.radCmdPlayer1Red.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radCmdPlayer1Red.Location = new System.Drawing.Point(6, 46);
            this.radCmdPlayer1Red.Name = "radCmdPlayer1Red";
            this.radCmdPlayer1Red.Size = new System.Drawing.Size(45, 17);
            this.radCmdPlayer1Red.TabIndex = 6;
            this.radCmdPlayer1Red.TabStop = true;
            this.radCmdPlayer1Red.Text = "Red";
            this.radCmdPlayer1Red.UseVisualStyleBackColor = true;
            // 
            // radCmdPlayer1Yellow
            // 
            this.radCmdPlayer1Yellow.AutoSize = true;
            this.radCmdPlayer1Yellow.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radCmdPlayer1Yellow.Location = new System.Drawing.Point(6, 69);
            this.radCmdPlayer1Yellow.Name = "radCmdPlayer1Yellow";
            this.radCmdPlayer1Yellow.Size = new System.Drawing.Size(56, 17);
            this.radCmdPlayer1Yellow.TabIndex = 7;
            this.radCmdPlayer1Yellow.TabStop = true;
            this.radCmdPlayer1Yellow.Text = "Yellow";
            this.radCmdPlayer1Yellow.UseVisualStyleBackColor = true;
            // 
            // grpBoxPlayer1Options
            // 
            this.grpBoxPlayer1Options.BackColor = System.Drawing.Color.Transparent;
            this.grpBoxPlayer1Options.Controls.Add(this.radCmdPlayer1Yellow);
            this.grpBoxPlayer1Options.Controls.Add(this.radCmdPlayer1Red);
            this.grpBoxPlayer1Options.Controls.Add(this.txtBoxPlayer1Name);
            this.grpBoxPlayer1Options.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpBoxPlayer1Options.ForeColor = System.Drawing.Color.White;
            this.grpBoxPlayer1Options.Location = new System.Drawing.Point(671, 253);
            this.grpBoxPlayer1Options.Name = "grpBoxPlayer1Options";
            this.grpBoxPlayer1Options.Size = new System.Drawing.Size(173, 116);
            this.grpBoxPlayer1Options.TabIndex = 0;
            this.grpBoxPlayer1Options.TabStop = false;
            this.grpBoxPlayer1Options.Text = "Player 1 Options";
            // 
            // txtBoxPlayer1Name
            // 
            this.txtBoxPlayer1Name.BackColor = System.Drawing.Color.DarkGray;
            this.txtBoxPlayer1Name.Location = new System.Drawing.Point(6, 19);
            this.txtBoxPlayer1Name.Name = "txtBoxPlayer1Name";
            this.txtBoxPlayer1Name.Size = new System.Drawing.Size(100, 21);
            this.txtBoxPlayer1Name.TabIndex = 6;
            // 
            // cmdStartGame
            // 
            this.cmdStartGame.BackColor = System.Drawing.Color.DarkGray;
            this.cmdStartGame.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmdStartGame.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdStartGame.ForeColor = System.Drawing.Color.Black;
            this.cmdStartGame.Location = new System.Drawing.Point(962, 37);
            this.cmdStartGame.Name = "cmdStartGame";
            this.cmdStartGame.Size = new System.Drawing.Size(106, 47);
            this.cmdStartGame.TabIndex = 5;
            this.cmdStartGame.Text = "Start Game";
            this.cmdStartGame.UseVisualStyleBackColor = false;
            this.cmdStartGame.Click += new System.EventHandler(this.cmdStartGame_Click);
            // 
            // grpBoxPlayer2Options
            // 
            this.grpBoxPlayer2Options.BackColor = System.Drawing.Color.Transparent;
            this.grpBoxPlayer2Options.Controls.Add(this.radCmdPlayer2Green);
            this.grpBoxPlayer2Options.Controls.Add(this.radCmdPlayer2Blue);
            this.grpBoxPlayer2Options.Controls.Add(this.txtBoxPlayer2Name);
            this.grpBoxPlayer2Options.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpBoxPlayer2Options.ForeColor = System.Drawing.Color.White;
            this.grpBoxPlayer2Options.Location = new System.Drawing.Point(892, 253);
            this.grpBoxPlayer2Options.Name = "grpBoxPlayer2Options";
            this.grpBoxPlayer2Options.Size = new System.Drawing.Size(173, 116);
            this.grpBoxPlayer2Options.TabIndex = 10;
            this.grpBoxPlayer2Options.TabStop = false;
            this.grpBoxPlayer2Options.Text = "Player 2 Options";
            // 
            // radCmdPlayer2Green
            // 
            this.radCmdPlayer2Green.AutoSize = true;
            this.radCmdPlayer2Green.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radCmdPlayer2Green.Location = new System.Drawing.Point(6, 69);
            this.radCmdPlayer2Green.Name = "radCmdPlayer2Green";
            this.radCmdPlayer2Green.Size = new System.Drawing.Size(54, 17);
            this.radCmdPlayer2Green.TabIndex = 7;
            this.radCmdPlayer2Green.TabStop = true;
            this.radCmdPlayer2Green.Text = "Green";
            this.radCmdPlayer2Green.UseVisualStyleBackColor = true;
            // 
            // radCmdPlayer2Blue
            // 
            this.radCmdPlayer2Blue.AutoSize = true;
            this.radCmdPlayer2Blue.Checked = true;
            this.radCmdPlayer2Blue.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radCmdPlayer2Blue.Location = new System.Drawing.Point(6, 46);
            this.radCmdPlayer2Blue.Name = "radCmdPlayer2Blue";
            this.radCmdPlayer2Blue.Size = new System.Drawing.Size(46, 17);
            this.radCmdPlayer2Blue.TabIndex = 6;
            this.radCmdPlayer2Blue.TabStop = true;
            this.radCmdPlayer2Blue.Text = "Blue";
            this.radCmdPlayer2Blue.UseVisualStyleBackColor = true;
            // 
            // txtBoxPlayer2Name
            // 
            this.txtBoxPlayer2Name.BackColor = System.Drawing.Color.DarkGray;
            this.txtBoxPlayer2Name.Location = new System.Drawing.Point(6, 19);
            this.txtBoxPlayer2Name.Name = "txtBoxPlayer2Name";
            this.txtBoxPlayer2Name.Size = new System.Drawing.Size(100, 21);
            this.txtBoxPlayer2Name.TabIndex = 6;
            // 
            // lblVS
            // 
            this.lblVS.AutoSize = true;
            this.lblVS.BackColor = System.Drawing.Color.Transparent;
            this.lblVS.ForeColor = System.Drawing.Color.White;
            this.lblVS.Location = new System.Drawing.Point(777, 48);
            this.lblVS.Name = "lblVS";
            this.lblVS.Size = new System.Drawing.Size(39, 13);
            this.lblVS.TabIndex = 12;
            this.lblVS.Text = "Versus";
            // 
            // txtBoxVersusPlayer1
            // 
            this.txtBoxVersusPlayer1.BackColor = System.Drawing.Color.DarkGray;
            this.txtBoxVersusPlayer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBoxVersusPlayer1.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtBoxVersusPlayer1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxVersusPlayer1.ForeColor = System.Drawing.Color.Black;
            this.txtBoxVersusPlayer1.Location = new System.Drawing.Point(671, 40);
            this.txtBoxVersusPlayer1.Name = "txtBoxVersusPlayer1";
            this.txtBoxVersusPlayer1.ReadOnly = true;
            this.txtBoxVersusPlayer1.Size = new System.Drawing.Size(100, 26);
            this.txtBoxVersusPlayer1.TabIndex = 13;
            // 
            // txtBoxVersusPlayer2
            // 
            this.txtBoxVersusPlayer2.BackColor = System.Drawing.Color.DarkGray;
            this.txtBoxVersusPlayer2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBoxVersusPlayer2.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtBoxVersusPlayer2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxVersusPlayer2.ForeColor = System.Drawing.Color.White;
            this.txtBoxVersusPlayer2.Location = new System.Drawing.Point(822, 40);
            this.txtBoxVersusPlayer2.Name = "txtBoxVersusPlayer2";
            this.txtBoxVersusPlayer2.ReadOnly = true;
            this.txtBoxVersusPlayer2.Size = new System.Drawing.Size(100, 26);
            this.txtBoxVersusPlayer2.TabIndex = 14;
            // 
            // rTxtBoxInfo
            // 
            this.rTxtBoxInfo.BackColor = System.Drawing.Color.DarkGray;
            this.rTxtBoxInfo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rTxtBoxInfo.Cursor = System.Windows.Forms.Cursors.Default;
            this.rTxtBoxInfo.ForeColor = System.Drawing.Color.Black;
            this.rTxtBoxInfo.Location = new System.Drawing.Point(671, 96);
            this.rTxtBoxInfo.Name = "rTxtBoxInfo";
            this.rTxtBoxInfo.Size = new System.Drawing.Size(251, 70);
            this.rTxtBoxInfo.TabIndex = 15;
            this.rTxtBoxInfo.Text = "";
            // 
            // lblPlayer1Score
            // 
            this.lblPlayer1Score.AutoSize = true;
            this.lblPlayer1Score.BackColor = System.Drawing.Color.Transparent;
            this.lblPlayer1Score.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayer1Score.ForeColor = System.Drawing.Color.White;
            this.lblPlayer1Score.Location = new System.Drawing.Point(674, 184);
            this.lblPlayer1Score.Name = "lblPlayer1Score";
            this.lblPlayer1Score.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblPlayer1Score.Size = new System.Drawing.Size(109, 16);
            this.lblPlayer1Score.TabIndex = 16;
            this.lblPlayer1Score.Text = "Player 1 Score: 0";
            // 
            // lblPlayer2Score
            // 
            this.lblPlayer2Score.AutoSize = true;
            this.lblPlayer2Score.BackColor = System.Drawing.Color.Transparent;
            this.lblPlayer2Score.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayer2Score.ForeColor = System.Drawing.Color.White;
            this.lblPlayer2Score.Location = new System.Drawing.Point(674, 210);
            this.lblPlayer2Score.Name = "lblPlayer2Score";
            this.lblPlayer2Score.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblPlayer2Score.Size = new System.Drawing.Size(109, 16);
            this.lblPlayer2Score.TabIndex = 17;
            this.lblPlayer2Score.Text = "Player 2 Score: 0";
            // 
            // cmdResetGame
            // 
            this.cmdResetGame.BackColor = System.Drawing.Color.DarkGray;
            this.cmdResetGame.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmdResetGame.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdResetGame.ForeColor = System.Drawing.Color.Black;
            this.cmdResetGame.Location = new System.Drawing.Point(962, 96);
            this.cmdResetGame.Name = "cmdResetGame";
            this.cmdResetGame.Size = new System.Drawing.Size(106, 47);
            this.cmdResetGame.TabIndex = 18;
            this.cmdResetGame.Text = "Reset Game";
            this.cmdResetGame.UseVisualStyleBackColor = false;
            this.cmdResetGame.Click += new System.EventHandler(this.cmdResetGame_Click);
            // 
            // Form1_Game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(1138, 666);
            this.Controls.Add(this.cmdResetGame);
            this.Controls.Add(this.lblPlayer2Score);
            this.Controls.Add(this.lblPlayer1Score);
            this.Controls.Add(this.rTxtBoxInfo);
            this.Controls.Add(this.txtBoxVersusPlayer2);
            this.Controls.Add(this.txtBoxVersusPlayer1);
            this.Controls.Add(this.lblVS);
            this.Controls.Add(this.grpBoxPlayer2Options);
            this.Controls.Add(this.cmdStartGame);
            this.Controls.Add(this.grpBoxPlayer1Options);
            this.Controls.Add(this.grpBoxThemeOptions);
            this.Controls.Add(this.grpBoxDifficulty);
            this.Controls.Add(this.pictureBoxDisplay);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Form1_Game";
            this.Text = "CONNECT 4 - TLvov";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDisplay)).EndInit();
            this.grpBoxDifficulty.ResumeLayout(false);
            this.grpBoxDifficulty.PerformLayout();
            this.grpBoxThemeOptions.ResumeLayout(false);
            this.grpBoxThemeOptions.PerformLayout();
            this.grpBoxPlayer1Options.ResumeLayout(false);
            this.grpBoxPlayer1Options.PerformLayout();
            this.grpBoxPlayer2Options.ResumeLayout(false);
            this.grpBoxPlayer2Options.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxDisplay;
        private System.Windows.Forms.GroupBox grpBoxDifficulty;
        private System.Windows.Forms.GroupBox grpBoxThemeOptions;
        private System.Windows.Forms.RadioButton radCmdPlayer1Red;
        private System.Windows.Forms.RadioButton radCmdPlayer1Yellow;
        private System.Windows.Forms.GroupBox grpBoxPlayer1Options;
        private System.Windows.Forms.Button cmdStartGame;
        private System.Windows.Forms.TextBox txtBoxPlayer1Name;
        private System.Windows.Forms.GroupBox grpBoxPlayer2Options;
        private System.Windows.Forms.RadioButton radCmdPlayer2Green;
        private System.Windows.Forms.RadioButton radCmdPlayer2Blue;
        private System.Windows.Forms.TextBox txtBoxPlayer2Name;
        private System.Windows.Forms.RadioButton radCmdGamePVP;
        private System.Windows.Forms.RadioButton radCmdGame1;
        private System.Windows.Forms.RadioButton radCmdGame2;
        private System.Windows.Forms.RadioButton radCmdGame3;
        private System.Windows.Forms.Label lblVS;
        private System.Windows.Forms.TextBox txtBoxVersusPlayer1;
        private System.Windows.Forms.TextBox txtBoxVersusPlayer2;
        private System.Windows.Forms.RichTextBox rTxtBoxInfo;
        private System.Windows.Forms.RadioButton radCmdThemeSystem;
        private System.Windows.Forms.RadioButton radCmdThemePastel;
        private System.Windows.Forms.RadioButton radCmdThemeWood;
        private System.Windows.Forms.RadioButton radCmdThemeMetal;
        private System.Windows.Forms.Label lblPlayer1Score;
        private System.Windows.Forms.Label lblPlayer2Score;
        private System.Windows.Forms.Button cmdResetGame;
    }
}

