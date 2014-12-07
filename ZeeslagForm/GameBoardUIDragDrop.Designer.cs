namespace ZeeslagForm
{
    partial class GameBoardUIDragDrop
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.gameBoardUI1 = new ZeeslagForm.GameBoardUI();
            this.ShipsPanel = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // gameBoardUI1
            // 
            this.gameBoardUI1.Clickable = false;
            this.gameBoardUI1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gameBoardUI1.Game = null;
            this.gameBoardUI1.Location = new System.Drawing.Point(0, 0);
            this.gameBoardUI1.MaximumSize = new System.Drawing.Size(400, 400);
            this.gameBoardUI1.MinimumSize = new System.Drawing.Size(400, 400);
            this.gameBoardUI1.Name = "gameBoardUI1";
            this.gameBoardUI1.Size = new System.Drawing.Size(400, 400);
            this.gameBoardUI1.TabIndex = 0;
            // 
            // ShipsPanel
            // 
            this.ShipsPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.ShipsPanel.Location = new System.Drawing.Point(466, 0);
            this.ShipsPanel.Name = "ShipsPanel";
            this.ShipsPanel.Size = new System.Drawing.Size(241, 479);
            this.ShipsPanel.TabIndex = 1;
            // 
            // GameBoardUIDragDrop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ShipsPanel);
            this.Controls.Add(this.gameBoardUI1);
            this.Name = "GameBoardUIDragDrop";
            this.Size = new System.Drawing.Size(707, 479);
            this.ResumeLayout(false);

        }

        #endregion

        private GameBoardUI gameBoardUI1;
        private System.Windows.Forms.Panel ShipsPanel;
    }
}
