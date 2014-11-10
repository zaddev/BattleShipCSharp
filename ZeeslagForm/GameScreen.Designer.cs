namespace ZeeslagForm
{
    partial class GameScreen
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
            this.MainSplitScreen = new System.Windows.Forms.SplitContainer();
            this.BoardScreens = new System.Windows.Forms.SplitContainer();
            this.gameBoardUIOwn = new ZeeslagForm.GameBoardUI();
            this.gameBoardUIOpponent = new ZeeslagForm.GameBoardUI();
            ((System.ComponentModel.ISupportInitialize)(this.MainSplitScreen)).BeginInit();
            this.MainSplitScreen.Panel1.SuspendLayout();
            this.MainSplitScreen.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BoardScreens)).BeginInit();
            this.BoardScreens.Panel1.SuspendLayout();
            this.BoardScreens.Panel2.SuspendLayout();
            this.BoardScreens.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainSplitScreen
            // 
            this.MainSplitScreen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainSplitScreen.Location = new System.Drawing.Point(0, 0);
            this.MainSplitScreen.Name = "MainSplitScreen";
            this.MainSplitScreen.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // MainSplitScreen.Panel1
            // 
            this.MainSplitScreen.Panel1.Controls.Add(this.BoardScreens);
            // 
            // MainSplitScreen.Panel2
            // 
            this.MainSplitScreen.Panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer1_Panel2_Paint);
            this.MainSplitScreen.Size = new System.Drawing.Size(930, 443);
            this.MainSplitScreen.SplitterDistance = 354;
            this.MainSplitScreen.TabIndex = 0;
            // 
            // BoardScreens
            // 
            this.BoardScreens.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BoardScreens.Location = new System.Drawing.Point(0, 0);
            this.BoardScreens.Name = "BoardScreens";
            // 
            // BoardScreens.Panel1
            // 
            this.BoardScreens.Panel1.Controls.Add(this.gameBoardUIOwn);
            // 
            // BoardScreens.Panel2
            // 
            this.BoardScreens.Panel2.Controls.Add(this.gameBoardUIOpponent);
            this.BoardScreens.Size = new System.Drawing.Size(930, 354);
            this.BoardScreens.SplitterDistance = 463;
            this.BoardScreens.TabIndex = 0;
            // 
            // gameBoardUIOwn
            // 
            this.gameBoardUIOwn.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.gameBoardUIOwn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gameBoardUIOwn.Location = new System.Drawing.Point(0, 0);
            this.gameBoardUIOwn.Name = "gameBoardUIOwn";
            this.gameBoardUIOwn.Size = new System.Drawing.Size(463, 354);
            this.gameBoardUIOwn.TabIndex = 0;
            // 
            // gameBoardUIOpponent
            // 
            this.gameBoardUIOpponent.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.gameBoardUIOpponent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gameBoardUIOpponent.Location = new System.Drawing.Point(0, 0);
            this.gameBoardUIOpponent.Name = "gameBoardUIOpponent";
            this.gameBoardUIOpponent.Size = new System.Drawing.Size(463, 354);
            this.gameBoardUIOpponent.TabIndex = 1;
            // 
            // GameScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(930, 443);
            this.Controls.Add(this.MainSplitScreen);
            this.Name = "GameScreen";
            this.Text = "GameScreen";
            this.MainSplitScreen.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.MainSplitScreen)).EndInit();
            this.MainSplitScreen.ResumeLayout(false);
            this.BoardScreens.Panel1.ResumeLayout(false);
            this.BoardScreens.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.BoardScreens)).EndInit();
            this.BoardScreens.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer MainSplitScreen;
        private System.Windows.Forms.SplitContainer BoardScreens;
        private GameBoardUI gameBoardUIOwn;
        private GameBoardUI gameBoardUIOpponent;
    }
}