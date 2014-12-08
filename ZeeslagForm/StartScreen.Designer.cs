namespace ZeeslagForm
{
    partial class StartScreen
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
            this.buttonSettings = new System.Windows.Forms.Button();
            this.buttonSaveShip = new System.Windows.Forms.Button();
            this.HorizontaalRadio = new System.Windows.Forms.RadioButton();
            this.VerticaalRadio = new System.Windows.Forms.RadioButton();
            this.gameBoardUIHover1 = new ZeeslagForm.GameBoardUIHover();
            this.SuspendLayout();
            // 
            // buttonSettings
            // 
            this.buttonSettings.Location = new System.Drawing.Point(13, 17);
            this.buttonSettings.Name = "buttonSettings";
            this.buttonSettings.Size = new System.Drawing.Size(75, 23);
            this.buttonSettings.TabIndex = 0;
            this.buttonSettings.Text = "settings";
            this.buttonSettings.UseVisualStyleBackColor = true;
            this.buttonSettings.Click += new System.EventHandler(this.buttonSettings_Click);
            // 
            // buttonSaveShip
            // 
            this.buttonSaveShip.Location = new System.Drawing.Point(358, 520);
            this.buttonSaveShip.Name = "buttonSaveShip";
            this.buttonSaveShip.Size = new System.Drawing.Size(75, 23);
            this.buttonSaveShip.TabIndex = 2;
            this.buttonSaveShip.Text = "save Ships";
            this.buttonSaveShip.UseVisualStyleBackColor = true;
            this.buttonSaveShip.Click += new System.EventHandler(this.buttonSaveShip_Click);
            // 
            // HorizontaalRadio
            // 
            this.HorizontaalRadio.AutoSize = true;
            this.HorizontaalRadio.Location = new System.Drawing.Point(723, 132);
            this.HorizontaalRadio.Name = "HorizontaalRadio";
            this.HorizontaalRadio.Size = new System.Drawing.Size(78, 17);
            this.HorizontaalRadio.TabIndex = 4;
            this.HorizontaalRadio.TabStop = true;
            this.HorizontaalRadio.Text = "Horizontaal";
            this.HorizontaalRadio.UseVisualStyleBackColor = true;
            this.HorizontaalRadio.CheckedChanged += new System.EventHandler(this.HorizontaalRadio_CheckedChanged);
            // 
            // VerticaalRadio
            // 
            this.VerticaalRadio.AutoSize = true;
            this.VerticaalRadio.Location = new System.Drawing.Point(723, 156);
            this.VerticaalRadio.Name = "VerticaalRadio";
            this.VerticaalRadio.Size = new System.Drawing.Size(66, 17);
            this.VerticaalRadio.TabIndex = 5;
            this.VerticaalRadio.TabStop = true;
            this.VerticaalRadio.Text = "Verticaal";
            this.VerticaalRadio.UseVisualStyleBackColor = true;
            // 
            // gameBoardUIHover1
            // 
            this.gameBoardUIHover1.Clickable = false;
            this.gameBoardUIHover1.Game = null;
            this.gameBoardUIHover1.Location = new System.Drawing.Point(223, 47);
            this.gameBoardUIHover1.MaximumSize = new System.Drawing.Size(400, 400);
            this.gameBoardUIHover1.MinimumSize = new System.Drawing.Size(400, 400);
            this.gameBoardUIHover1.Name = "gameBoardUIHover1";
            this.gameBoardUIHover1.ShipToSet = null;
            this.gameBoardUIHover1.Size = new System.Drawing.Size(400, 400);
            this.gameBoardUIHover1.TabIndex = 3;
            // 
            // StartScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1076, 565);
            this.Controls.Add(this.VerticaalRadio);
            this.Controls.Add(this.HorizontaalRadio);
            this.Controls.Add(this.gameBoardUIHover1);
            this.Controls.Add(this.buttonSaveShip);
            this.Controls.Add(this.buttonSettings);
            this.Name = "StartScreen";
            this.Text = "StartScreen";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonSettings;
        private System.Windows.Forms.Button buttonSaveShip;
        private GameBoardUIHover gameBoardUIHover1;
        private System.Windows.Forms.RadioButton HorizontaalRadio;
        private System.Windows.Forms.RadioButton VerticaalRadio;
    }
}