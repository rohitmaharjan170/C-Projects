namespace TicTacToe
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.gameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newGameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.A1 = new System.Windows.Forms.Button();
            this.A2 = new System.Windows.Forms.Button();
            this.A3 = new System.Windows.Forms.Button();
            this.B1 = new System.Windows.Forms.Button();
            this.B2 = new System.Windows.Forms.Button();
            this.B3 = new System.Windows.Forms.Button();
            this.C1 = new System.Windows.Forms.Button();
            this.C2 = new System.Windows.Forms.Button();
            this.C3 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.DrawWinCount = new System.Windows.Forms.Label();
            this.XWinCount = new System.Windows.Forms.Label();
            this.OWinCount = new System.Windows.Forms.Label();
            this.btnReset = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gameToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1231, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // gameToolStripMenuItem
            // 
            this.gameToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newGameToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.gameToolStripMenuItem.Name = "gameToolStripMenuItem";
            this.gameToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.gameToolStripMenuItem.Text = "Game";
            // 
            // newGameToolStripMenuItem
            // 
            this.newGameToolStripMenuItem.Name = "newGameToolStripMenuItem";
            this.newGameToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.newGameToolStripMenuItem.Text = "New Game";
            this.newGameToolStripMenuItem.Click += new System.EventHandler(this.newGameToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // A1
            // 
            this.A1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("A1.BackgroundImage")));
            this.A1.Font = new System.Drawing.Font("Willow Wisp", 47.99999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.A1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.A1.Location = new System.Drawing.Point(333, 157);
            this.A1.Name = "A1";
            this.A1.Size = new System.Drawing.Size(90, 90);
            this.A1.TabIndex = 1;
            this.A1.TabStop = false;
            this.A1.UseVisualStyleBackColor = true;
            this.A1.Click += new System.EventHandler(this.btn_Player_Click);
            this.A1.MouseEnter += new System.EventHandler(this.Btn_Enter);
            this.A1.MouseLeave += new System.EventHandler(this.Btn_Leave);
            // 
            // A2
            // 
            this.A2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("A2.BackgroundImage")));
            this.A2.Font = new System.Drawing.Font("Willow Wisp", 47.99999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.A2.Location = new System.Drawing.Point(482, 157);
            this.A2.Name = "A2";
            this.A2.Size = new System.Drawing.Size(90, 90);
            this.A2.TabIndex = 1;
            this.A2.TabStop = false;
            this.A2.UseVisualStyleBackColor = true;
            this.A2.Click += new System.EventHandler(this.btn_Player_Click);
            this.A2.MouseEnter += new System.EventHandler(this.Btn_Enter);
            this.A2.MouseLeave += new System.EventHandler(this.Btn_Leave);
            // 
            // A3
            // 
            this.A3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("A3.BackgroundImage")));
            this.A3.Font = new System.Drawing.Font("Willow Wisp", 47.99999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.A3.Location = new System.Drawing.Point(635, 157);
            this.A3.Name = "A3";
            this.A3.Size = new System.Drawing.Size(90, 90);
            this.A3.TabIndex = 1;
            this.A3.TabStop = false;
            this.A3.UseVisualStyleBackColor = true;
            this.A3.Click += new System.EventHandler(this.btn_Player_Click);
            this.A3.MouseEnter += new System.EventHandler(this.Btn_Enter);
            this.A3.MouseLeave += new System.EventHandler(this.Btn_Leave);
            // 
            // B1
            // 
            this.B1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("B1.BackgroundImage")));
            this.B1.Font = new System.Drawing.Font("Willow Wisp", 47.99999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.B1.Location = new System.Drawing.Point(333, 305);
            this.B1.Name = "B1";
            this.B1.Size = new System.Drawing.Size(90, 90);
            this.B1.TabIndex = 1;
            this.B1.TabStop = false;
            this.B1.UseVisualStyleBackColor = true;
            this.B1.Click += new System.EventHandler(this.btn_Player_Click);
            this.B1.MouseEnter += new System.EventHandler(this.Btn_Enter);
            this.B1.MouseLeave += new System.EventHandler(this.Btn_Leave);
            // 
            // B2
            // 
            this.B2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("B2.BackgroundImage")));
            this.B2.Font = new System.Drawing.Font("Willow Wisp", 47.99999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.B2.Location = new System.Drawing.Point(482, 305);
            this.B2.Name = "B2";
            this.B2.Size = new System.Drawing.Size(90, 90);
            this.B2.TabIndex = 1;
            this.B2.TabStop = false;
            this.B2.UseVisualStyleBackColor = true;
            this.B2.Click += new System.EventHandler(this.btn_Player_Click);
            this.B2.MouseEnter += new System.EventHandler(this.Btn_Enter);
            this.B2.MouseLeave += new System.EventHandler(this.Btn_Leave);
            // 
            // B3
            // 
            this.B3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("B3.BackgroundImage")));
            this.B3.Font = new System.Drawing.Font("Willow Wisp", 47.99999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.B3.Location = new System.Drawing.Point(635, 305);
            this.B3.Name = "B3";
            this.B3.Size = new System.Drawing.Size(90, 90);
            this.B3.TabIndex = 1;
            this.B3.TabStop = false;
            this.B3.UseVisualStyleBackColor = true;
            this.B3.Click += new System.EventHandler(this.btn_Player_Click);
            this.B3.MouseEnter += new System.EventHandler(this.Btn_Enter);
            this.B3.MouseLeave += new System.EventHandler(this.Btn_Leave);
            // 
            // C1
            // 
            this.C1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("C1.BackgroundImage")));
            this.C1.Font = new System.Drawing.Font("Willow Wisp", 47.99999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.C1.Location = new System.Drawing.Point(333, 458);
            this.C1.Name = "C1";
            this.C1.Size = new System.Drawing.Size(90, 90);
            this.C1.TabIndex = 1;
            this.C1.TabStop = false;
            this.C1.UseVisualStyleBackColor = true;
            this.C1.Click += new System.EventHandler(this.btn_Player_Click);
            this.C1.MouseEnter += new System.EventHandler(this.Btn_Enter);
            this.C1.MouseLeave += new System.EventHandler(this.Btn_Leave);
            // 
            // C2
            // 
            this.C2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("C2.BackgroundImage")));
            this.C2.Font = new System.Drawing.Font("Willow Wisp", 47.99999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.C2.Location = new System.Drawing.Point(482, 458);
            this.C2.Name = "C2";
            this.C2.Size = new System.Drawing.Size(90, 90);
            this.C2.TabIndex = 1;
            this.C2.TabStop = false;
            this.C2.UseVisualStyleBackColor = true;
            this.C2.Click += new System.EventHandler(this.btn_Player_Click);
            this.C2.MouseEnter += new System.EventHandler(this.Btn_Enter);
            this.C2.MouseLeave += new System.EventHandler(this.Btn_Leave);
            // 
            // C3
            // 
            this.C3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("C3.BackgroundImage")));
            this.C3.Font = new System.Drawing.Font("Willow Wisp", 47.99999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.C3.Location = new System.Drawing.Point(635, 458);
            this.C3.Name = "C3";
            this.C3.Size = new System.Drawing.Size(90, 90);
            this.C3.TabIndex = 1;
            this.C3.TabStop = false;
            this.C3.UseVisualStyleBackColor = true;
            this.C3.Click += new System.EventHandler(this.btn_Player_Click);
            this.C3.MouseEnter += new System.EventHandler(this.Btn_Enter);
            this.C3.MouseLeave += new System.EventHandler(this.Btn_Leave);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(274, 91);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(514, 505);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(819, 216);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(400, 250);
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Willow Wisp", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(895, 334);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 34);
            this.label1.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Willow Wisp", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(994, 334);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 34);
            this.label2.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Willow Wisp", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(1108, 334);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 34);
            this.label3.TabIndex = 4;
            // 
            // DrawWinCount
            // 
            this.DrawWinCount.AutoSize = true;
            this.DrawWinCount.BackColor = System.Drawing.SystemColors.Control;
            this.DrawWinCount.Font = new System.Drawing.Font("Willow Wisp", 47.99999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DrawWinCount.ForeColor = System.Drawing.SystemColors.ControlText;
            this.DrawWinCount.Location = new System.Drawing.Point(984, 305);
            this.DrawWinCount.Name = "DrawWinCount";
            this.DrawWinCount.Size = new System.Drawing.Size(60, 75);
            this.DrawWinCount.TabIndex = 5;
            this.DrawWinCount.Text = "0";
            // 
            // XWinCount
            // 
            this.XWinCount.AutoSize = true;
            this.XWinCount.BackColor = System.Drawing.SystemColors.Control;
            this.XWinCount.Font = new System.Drawing.Font("Willow Wisp", 47.99999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.XWinCount.ForeColor = System.Drawing.Color.IndianRed;
            this.XWinCount.Location = new System.Drawing.Point(877, 305);
            this.XWinCount.Name = "XWinCount";
            this.XWinCount.Size = new System.Drawing.Size(60, 75);
            this.XWinCount.TabIndex = 5;
            this.XWinCount.Text = "0";
            // 
            // OWinCount
            // 
            this.OWinCount.AutoSize = true;
            this.OWinCount.BackColor = System.Drawing.SystemColors.Control;
            this.OWinCount.Font = new System.Drawing.Font("Willow Wisp", 47.99999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OWinCount.ForeColor = System.Drawing.Color.MediumTurquoise;
            this.OWinCount.Location = new System.Drawing.Point(1095, 306);
            this.OWinCount.Name = "OWinCount";
            this.OWinCount.Size = new System.Drawing.Size(60, 75);
            this.OWinCount.TabIndex = 5;
            this.OWinCount.Text = "0";
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.SaddleBrown;
            this.btnReset.Font = new System.Drawing.Font("Willow Wisp", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.ForeColor = System.Drawing.SystemColors.Control;
            this.btnReset.Location = new System.Drawing.Point(946, 497);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(152, 44);
            this.btnReset.TabIndex = 6;
            this.btnReset.Text = "Reset ScoreBoaed";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnResetScoreBoard);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1231, 799);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.OWinCount);
            this.Controls.Add(this.XWinCount);
            this.Controls.Add(this.DrawWinCount);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.C3);
            this.Controls.Add(this.B3);
            this.Controls.Add(this.A3);
            this.Controls.Add(this.C2);
            this.Controls.Add(this.C1);
            this.Controls.Add(this.B2);
            this.Controls.Add(this.B1);
            this.Controls.Add(this.A2);
            this.Controls.Add(this.A1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tic Tac Toe - By Rohit Maharzan";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem gameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newGameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.Button A1;
        private System.Windows.Forms.Button A2;
        private System.Windows.Forms.Button A3;
        private System.Windows.Forms.Button B1;
        private System.Windows.Forms.Button B2;
        private System.Windows.Forms.Button B3;
        private System.Windows.Forms.Button C1;
        private System.Windows.Forms.Button C2;
        private System.Windows.Forms.Button C3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label DrawWinCount;
        private System.Windows.Forms.Label XWinCount;
        private System.Windows.Forms.Label OWinCount;
        private System.Windows.Forms.Button btnReset;
    }
}

