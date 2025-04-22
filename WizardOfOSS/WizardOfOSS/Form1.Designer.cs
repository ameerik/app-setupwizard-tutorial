namespace WizardOfOSS
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            btnReset = new Button();
            lblTitle = new Label();
            pbWizard = new PictureBox();
            pnlGame = new Panel();
            pbOrb12 = new PictureBox();
            pbOrb11 = new PictureBox();
            pbOrb10 = new PictureBox();
            pbOrb9 = new PictureBox();
            pbOrb8 = new PictureBox();
            pbOrb7 = new PictureBox();
            pbOrb6 = new PictureBox();
            pbOrb5 = new PictureBox();
            pbOrb4 = new PictureBox();
            pbOrb3 = new PictureBox();
            pbOrb2 = new PictureBox();
            pbOrb1 = new PictureBox();
            lblTimer = new Label();
            gameTimer = new System.Windows.Forms.Timer(components);
            btnHelp = new Button();
            ((System.ComponentModel.ISupportInitialize)pbWizard).BeginInit();
            pnlGame.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbOrb12).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbOrb11).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbOrb10).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbOrb9).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbOrb8).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbOrb7).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbOrb6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbOrb5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbOrb4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbOrb3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbOrb2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbOrb1).BeginInit();
            SuspendLayout();
            // 
            // btnReset
            // 
            btnReset.BackColor = Color.Goldenrod;
            btnReset.Cursor = Cursors.Hand;
            btnReset.Font = new Font("Times New Roman", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnReset.ForeColor = SystemColors.ButtonHighlight;
            btnReset.Location = new Point(502, 440);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(166, 44);
            btnReset.TabIndex = 0;
            btnReset.Text = "RESET";
            btnReset.UseVisualStyleBackColor = false;
            btnReset.Click += btnReset_Click;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.BackColor = Color.Goldenrod;
            lblTitle.BorderStyle = BorderStyle.Fixed3D;
            lblTitle.Cursor = Cursors.Hand;
            lblTitle.FlatStyle = FlatStyle.Popup;
            lblTitle.Font = new Font("Times New Roman", 48F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.ForeColor = SystemColors.ButtonHighlight;
            lblTitle.Location = new Point(101, 9);
            lblTitle.Margin = new Padding(0);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(674, 92);
            lblTitle.TabIndex = 1;
            lblTitle.Text = "WIZARD OF OSS";
            lblTitle.TextAlign = ContentAlignment.TopCenter;
            lblTitle.UseMnemonic = false;
            // 
            // pbWizard
            // 
            pbWizard.BackColor = SystemColors.ButtonHighlight;
            pbWizard.BorderStyle = BorderStyle.FixedSingle;
            pbWizard.Cursor = Cursors.No;
            pbWizard.Image = (Image)resources.GetObject("pbWizard.Image");
            pbWizard.Location = new Point(23, 120);
            pbWizard.Name = "pbWizard";
            pbWizard.Size = new Size(248, 359);
            pbWizard.SizeMode = PictureBoxSizeMode.StretchImage;
            pbWizard.TabIndex = 2;
            pbWizard.TabStop = false;
            pbWizard.Click += pbWizard_Click;
            // 
            // pnlGame
            // 
            pnlGame.BorderStyle = BorderStyle.Fixed3D;
            pnlGame.Controls.Add(pbOrb12);
            pnlGame.Controls.Add(pbOrb11);
            pnlGame.Controls.Add(pbOrb10);
            pnlGame.Controls.Add(pbOrb9);
            pnlGame.Controls.Add(pbOrb8);
            pnlGame.Controls.Add(pbOrb7);
            pnlGame.Controls.Add(pbOrb6);
            pnlGame.Controls.Add(pbOrb5);
            pnlGame.Controls.Add(pbOrb4);
            pnlGame.Controls.Add(pbOrb3);
            pnlGame.Controls.Add(pbOrb2);
            pnlGame.Controls.Add(pbOrb1);
            pnlGame.Cursor = Cursors.Cross;
            pnlGame.Location = new Point(277, 120);
            pnlGame.Name = "pnlGame";
            pnlGame.Size = new Size(575, 309);
            pnlGame.TabIndex = 3;
            // 
            // pbOrb12
            // 
            pbOrb12.Image = (Image)resources.GetObject("pbOrb12.Image");
            pbOrb12.Location = new Point(525, 259);
            pbOrb12.Name = "pbOrb12";
            pbOrb12.Size = new Size(41, 43);
            pbOrb12.SizeMode = PictureBoxSizeMode.StretchImage;
            pbOrb12.TabIndex = 11;
            pbOrb12.TabStop = false;
            // 
            // pbOrb11
            // 
            pbOrb11.Image = (Image)resources.GetObject("pbOrb11.Image");
            pbOrb11.Location = new Point(348, 29);
            pbOrb11.Name = "pbOrb11";
            pbOrb11.Size = new Size(41, 43);
            pbOrb11.SizeMode = PictureBoxSizeMode.StretchImage;
            pbOrb11.TabIndex = 10;
            pbOrb11.TabStop = false;
            // 
            // pbOrb10
            // 
            pbOrb10.Image = (Image)resources.GetObject("pbOrb10.Image");
            pbOrb10.Location = new Point(223, 210);
            pbOrb10.Name = "pbOrb10";
            pbOrb10.Size = new Size(41, 43);
            pbOrb10.SizeMode = PictureBoxSizeMode.StretchImage;
            pbOrb10.TabIndex = 9;
            pbOrb10.TabStop = false;
            // 
            // pbOrb9
            // 
            pbOrb9.Image = (Image)resources.GetObject("pbOrb9.Image");
            pbOrb9.Location = new Point(370, 241);
            pbOrb9.Name = "pbOrb9";
            pbOrb9.Size = new Size(41, 43);
            pbOrb9.SizeMode = PictureBoxSizeMode.StretchImage;
            pbOrb9.TabIndex = 8;
            pbOrb9.TabStop = false;
            // 
            // pbOrb8
            // 
            pbOrb8.Image = (Image)resources.GetObject("pbOrb8.Image");
            pbOrb8.Location = new Point(453, 137);
            pbOrb8.Name = "pbOrb8";
            pbOrb8.Size = new Size(41, 43);
            pbOrb8.SizeMode = PictureBoxSizeMode.StretchImage;
            pbOrb8.TabIndex = 7;
            pbOrb8.TabStop = false;
            // 
            // pbOrb7
            // 
            pbOrb7.Image = (Image)resources.GetObject("pbOrb7.Image");
            pbOrb7.Location = new Point(124, 29);
            pbOrb7.Name = "pbOrb7";
            pbOrb7.Size = new Size(41, 43);
            pbOrb7.SizeMode = PictureBoxSizeMode.StretchImage;
            pbOrb7.TabIndex = 6;
            pbOrb7.TabStop = false;
            // 
            // pbOrb6
            // 
            pbOrb6.Image = (Image)resources.GetObject("pbOrb6.Image");
            pbOrb6.Location = new Point(508, 18);
            pbOrb6.Name = "pbOrb6";
            pbOrb6.Size = new Size(41, 43);
            pbOrb6.SizeMode = PictureBoxSizeMode.StretchImage;
            pbOrb6.TabIndex = 5;
            pbOrb6.TabStop = false;
            // 
            // pbOrb5
            // 
            pbOrb5.Image = (Image)resources.GetObject("pbOrb5.Image");
            pbOrb5.Location = new Point(248, 109);
            pbOrb5.Name = "pbOrb5";
            pbOrb5.Size = new Size(41, 43);
            pbOrb5.SizeMode = PictureBoxSizeMode.StretchImage;
            pbOrb5.TabIndex = 4;
            pbOrb5.TabStop = false;
            // 
            // pbOrb4
            // 
            pbOrb4.Image = (Image)resources.GetObject("pbOrb4.Image");
            pbOrb4.Location = new Point(3, 210);
            pbOrb4.Name = "pbOrb4";
            pbOrb4.Size = new Size(41, 43);
            pbOrb4.SizeMode = PictureBoxSizeMode.StretchImage;
            pbOrb4.TabIndex = 3;
            pbOrb4.TabStop = false;
            // 
            // pbOrb3
            // 
            pbOrb3.Image = (Image)resources.GetObject("pbOrb3.Image");
            pbOrb3.Location = new Point(124, 241);
            pbOrb3.Name = "pbOrb3";
            pbOrb3.Size = new Size(41, 43);
            pbOrb3.SizeMode = PictureBoxSizeMode.StretchImage;
            pbOrb3.TabIndex = 2;
            pbOrb3.TabStop = false;
            // 
            // pbOrb2
            // 
            pbOrb2.BackgroundImageLayout = ImageLayout.None;
            pbOrb2.Image = (Image)resources.GetObject("pbOrb2.Image");
            pbOrb2.Location = new Point(63, 137);
            pbOrb2.Name = "pbOrb2";
            pbOrb2.Size = new Size(41, 43);
            pbOrb2.SizeMode = PictureBoxSizeMode.StretchImage;
            pbOrb2.TabIndex = 1;
            pbOrb2.TabStop = false;
            // 
            // pbOrb1
            // 
            pbOrb1.BackgroundImageLayout = ImageLayout.None;
            pbOrb1.Image = (Image)resources.GetObject("pbOrb1.Image");
            pbOrb1.Location = new Point(3, 3);
            pbOrb1.Name = "pbOrb1";
            pbOrb1.Size = new Size(41, 43);
            pbOrb1.SizeMode = PictureBoxSizeMode.StretchImage;
            pbOrb1.TabIndex = 0;
            pbOrb1.TabStop = false;
            // 
            // lblTimer
            // 
            lblTimer.AutoSize = true;
            lblTimer.BackColor = Color.Goldenrod;
            lblTimer.Cursor = Cursors.Hand;
            lblTimer.Font = new Font("Times New Roman", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTimer.ForeColor = SystemColors.ButtonHighlight;
            lblTimer.Location = new Point(101, 120);
            lblTimer.Name = "lblTimer";
            lblTimer.Size = new Size(96, 38);
            lblTimer.TabIndex = 5;
            lblTimer.Text = "00:00";
            // 
            // gameTimer
            // 
            gameTimer.Interval = 1000;
            // 
            // btnHelp
            // 
            btnHelp.BackColor = Color.Goldenrod;
            btnHelp.Font = new Font("Times New Roman", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnHelp.ForeColor = SystemColors.ButtonHighlight;
            btnHelp.Location = new Point(777, 454);
            btnHelp.Name = "btnHelp";
            btnHelp.Size = new Size(68, 29);
            btnHelp.TabIndex = 6;
            btnHelp.Text = "HELP";
            btnHelp.UseVisualStyleBackColor = false;
            btnHelp.Click += btnHelp_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Navy;
            ClientSize = new Size(857, 491);
            Controls.Add(btnHelp);
            Controls.Add(lblTimer);
            Controls.Add(pnlGame);
            Controls.Add(pbWizard);
            Controls.Add(lblTitle);
            Controls.Add(btnReset);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pbWizard).EndInit();
            pnlGame.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pbOrb12).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbOrb11).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbOrb10).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbOrb9).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbOrb8).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbOrb7).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbOrb6).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbOrb5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbOrb4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbOrb3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbOrb2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbOrb1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnReset;
        private Label lblTitle;
        private PictureBox pbWizard;
        private Panel pnlGame;
        private PictureBox pbOrb1;
        private Label lblTimer;
        private PictureBox pbOrb2;
        private PictureBox pbOrb5;
        private PictureBox pbOrb4;
        private PictureBox pbOrb3;
        private PictureBox pbOrb12;
        private PictureBox pbOrb11;
        private PictureBox pbOrb10;
        private PictureBox pbOrb9;
        private PictureBox pbOrb8;
        private PictureBox pbOrb7;
        private PictureBox pbOrb6;
        private System.Windows.Forms.Timer gameTimer;
        private Button btnHelp;
    }
}
