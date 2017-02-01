namespace DogRacing
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.raceTrackPicture = new System.Windows.Forms.PictureBox();
            this.dogPicture1 = new System.Windows.Forms.PictureBox();
            this.dogPicture2 = new System.Windows.Forms.PictureBox();
            this.dogPicture3 = new System.Windows.Forms.PictureBox();
            this.dogPicture4 = new System.Windows.Forms.PictureBox();
            this.bettingParlourLabel = new System.Windows.Forms.Label();
            this.betsLabel = new System.Windows.Forms.Label();
            this.minimumBetLabel = new System.Windows.Forms.Label();
            this.joeRadioButton = new System.Windows.Forms.RadioButton();
            this.bobRadioButton = new System.Windows.Forms.RadioButton();
            this.AlRadioButton = new System.Windows.Forms.RadioButton();
            this.betNameLabel = new System.Windows.Forms.Label();
            this.betNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.bucksOnLabel = new System.Windows.Forms.Label();
            this.dogNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.confirmButton = new System.Windows.Forms.Button();
            this.joesBetLabel = new System.Windows.Forms.Label();
            this.bobsBetLabel = new System.Windows.Forms.Label();
            this.alsBetLabel = new System.Windows.Forms.Label();
            this.raceButton = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.raceTrackPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dogPicture1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dogPicture2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dogPicture3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dogPicture4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.betNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dogNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // raceTrackPicture
            // 
            this.raceTrackPicture.Image = ((System.Drawing.Image)(resources.GetObject("raceTrackPicture.Image")));
            this.raceTrackPicture.InitialImage = ((System.Drawing.Image)(resources.GetObject("raceTrackPicture.InitialImage")));
            this.raceTrackPicture.Location = new System.Drawing.Point(-3, 4);
            this.raceTrackPicture.Name = "raceTrackPicture";
            this.raceTrackPicture.Size = new System.Drawing.Size(1200, 400);
            this.raceTrackPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.raceTrackPicture.TabIndex = 0;
            this.raceTrackPicture.TabStop = false;
            // 
            // dogPicture1
            // 
            this.dogPicture1.Image = ((System.Drawing.Image)(resources.GetObject("dogPicture1.Image")));
            this.dogPicture1.Location = new System.Drawing.Point(68, 29);
            this.dogPicture1.Name = "dogPicture1";
            this.dogPicture1.Size = new System.Drawing.Size(100, 35);
            this.dogPicture1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.dogPicture1.TabIndex = 1;
            this.dogPicture1.TabStop = false;
            // 
            // dogPicture2
            // 
            this.dogPicture2.Image = ((System.Drawing.Image)(resources.GetObject("dogPicture2.Image")));
            this.dogPicture2.Location = new System.Drawing.Point(68, 120);
            this.dogPicture2.Name = "dogPicture2";
            this.dogPicture2.Size = new System.Drawing.Size(100, 35);
            this.dogPicture2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.dogPicture2.TabIndex = 2;
            this.dogPicture2.TabStop = false;
            // 
            // dogPicture3
            // 
            this.dogPicture3.Image = ((System.Drawing.Image)(resources.GetObject("dogPicture3.Image")));
            this.dogPicture3.Location = new System.Drawing.Point(68, 230);
            this.dogPicture3.Name = "dogPicture3";
            this.dogPicture3.Size = new System.Drawing.Size(100, 35);
            this.dogPicture3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.dogPicture3.TabIndex = 3;
            this.dogPicture3.TabStop = false;
            // 
            // dogPicture4
            // 
            this.dogPicture4.Image = ((System.Drawing.Image)(resources.GetObject("dogPicture4.Image")));
            this.dogPicture4.Location = new System.Drawing.Point(68, 337);
            this.dogPicture4.Name = "dogPicture4";
            this.dogPicture4.Size = new System.Drawing.Size(100, 35);
            this.dogPicture4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.dogPicture4.TabIndex = 4;
            this.dogPicture4.TabStop = false;
            // 
            // bettingParlourLabel
            // 
            this.bettingParlourLabel.AutoSize = true;
            this.bettingParlourLabel.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bettingParlourLabel.Location = new System.Drawing.Point(302, 427);
            this.bettingParlourLabel.Name = "bettingParlourLabel";
            this.bettingParlourLabel.Size = new System.Drawing.Size(142, 26);
            this.bettingParlourLabel.TabIndex = 5;
            this.bettingParlourLabel.Text = "Betting Parlour";
            // 
            // betsLabel
            // 
            this.betsLabel.AutoSize = true;
            this.betsLabel.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.betsLabel.Location = new System.Drawing.Point(704, 448);
            this.betsLabel.Name = "betsLabel";
            this.betsLabel.Size = new System.Drawing.Size(50, 26);
            this.betsLabel.TabIndex = 6;
            this.betsLabel.Text = "Bets";
            // 
            // minimumBetLabel
            // 
            this.minimumBetLabel.AutoSize = true;
            this.minimumBetLabel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minimumBetLabel.Location = new System.Drawing.Point(302, 453);
            this.minimumBetLabel.Name = "minimumBetLabel";
            this.minimumBetLabel.Size = new System.Drawing.Size(107, 19);
            this.minimumBetLabel.TabIndex = 7;
            this.minimumBetLabel.Text = "Minimum Bet: ";
            // 
            // joeRadioButton
            // 
            this.joeRadioButton.AutoSize = true;
            this.joeRadioButton.Location = new System.Drawing.Point(307, 480);
            this.joeRadioButton.Name = "joeRadioButton";
            this.joeRadioButton.Size = new System.Drawing.Size(42, 17);
            this.joeRadioButton.TabIndex = 8;
            this.joeRadioButton.TabStop = true;
            this.joeRadioButton.Text = "Joe";
            this.joeRadioButton.UseVisualStyleBackColor = true;
            this.joeRadioButton.CheckedChanged += new System.EventHandler(this.joeRadioButton_CheckedChanged);
            // 
            // bobRadioButton
            // 
            this.bobRadioButton.AutoSize = true;
            this.bobRadioButton.Location = new System.Drawing.Point(307, 503);
            this.bobRadioButton.Name = "bobRadioButton";
            this.bobRadioButton.Size = new System.Drawing.Size(44, 17);
            this.bobRadioButton.TabIndex = 9;
            this.bobRadioButton.TabStop = true;
            this.bobRadioButton.Text = "Bob";
            this.bobRadioButton.UseVisualStyleBackColor = true;
            this.bobRadioButton.CheckedChanged += new System.EventHandler(this.bobRadioButton_CheckedChanged);
            // 
            // AlRadioButton
            // 
            this.AlRadioButton.AutoSize = true;
            this.AlRadioButton.Location = new System.Drawing.Point(307, 526);
            this.AlRadioButton.Name = "AlRadioButton";
            this.AlRadioButton.Size = new System.Drawing.Size(34, 17);
            this.AlRadioButton.TabIndex = 10;
            this.AlRadioButton.TabStop = true;
            this.AlRadioButton.Text = "Al";
            this.AlRadioButton.UseVisualStyleBackColor = true;
            this.AlRadioButton.CheckedChanged += new System.EventHandler(this.AlRadioButton_CheckedChanged);
            // 
            // betNameLabel
            // 
            this.betNameLabel.AutoSize = true;
            this.betNameLabel.Location = new System.Drawing.Point(304, 557);
            this.betNameLabel.Name = "betNameLabel";
            this.betNameLabel.Size = new System.Drawing.Size(47, 13);
            this.betNameLabel.TabIndex = 11;
            this.betNameLabel.Text = "Joe bets";
            this.betNameLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // betNumericUpDown
            // 
            this.betNumericUpDown.Location = new System.Drawing.Point(357, 555);
            this.betNumericUpDown.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.betNumericUpDown.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.betNumericUpDown.Name = "betNumericUpDown";
            this.betNumericUpDown.Size = new System.Drawing.Size(38, 20);
            this.betNumericUpDown.TabIndex = 12;
            this.betNumericUpDown.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // bucksOnLabel
            // 
            this.bucksOnLabel.AutoSize = true;
            this.bucksOnLabel.Location = new System.Drawing.Point(401, 557);
            this.bucksOnLabel.Name = "bucksOnLabel";
            this.bucksOnLabel.Size = new System.Drawing.Size(110, 13);
            this.bucksOnLabel.TabIndex = 13;
            this.bucksOnLabel.Text = "bucks on dog number";
            // 
            // dogNumericUpDown
            // 
            this.dogNumericUpDown.Location = new System.Drawing.Point(517, 557);
            this.dogNumericUpDown.Maximum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.dogNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.dogNumericUpDown.Name = "dogNumericUpDown";
            this.dogNumericUpDown.Size = new System.Drawing.Size(38, 20);
            this.dogNumericUpDown.TabIndex = 14;
            this.dogNumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // confirmButton
            // 
            this.confirmButton.Location = new System.Drawing.Point(561, 555);
            this.confirmButton.Name = "confirmButton";
            this.confirmButton.Size = new System.Drawing.Size(75, 23);
            this.confirmButton.TabIndex = 15;
            this.confirmButton.Text = "Place Bet";
            this.confirmButton.UseVisualStyleBackColor = true;
            this.confirmButton.Click += new System.EventHandler(this.confirmButton_Click);
            // 
            // joesBetLabel
            // 
            this.joesBetLabel.AutoSize = true;
            this.joesBetLabel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.joesBetLabel.Location = new System.Drawing.Point(705, 478);
            this.joesBetLabel.Name = "joesBetLabel";
            this.joesBetLabel.Size = new System.Drawing.Size(159, 19);
            this.joesBetLabel.TabIndex = 16;
            this.joesBetLabel.Text = "Joe has not made a bet";
            // 
            // bobsBetLabel
            // 
            this.bobsBetLabel.AutoSize = true;
            this.bobsBetLabel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bobsBetLabel.Location = new System.Drawing.Point(705, 501);
            this.bobsBetLabel.Name = "bobsBetLabel";
            this.bobsBetLabel.Size = new System.Drawing.Size(163, 19);
            this.bobsBetLabel.TabIndex = 17;
            this.bobsBetLabel.Text = "Bob has not made a bet";
            // 
            // alsBetLabel
            // 
            this.alsBetLabel.AutoSize = true;
            this.alsBetLabel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.alsBetLabel.Location = new System.Drawing.Point(705, 524);
            this.alsBetLabel.Name = "alsBetLabel";
            this.alsBetLabel.Size = new System.Drawing.Size(151, 19);
            this.alsBetLabel.TabIndex = 18;
            this.alsBetLabel.Text = "Al has not made a bet";
            // 
            // raceButton
            // 
            this.raceButton.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.raceButton.Location = new System.Drawing.Point(961, 448);
            this.raceButton.Name = "raceButton";
            this.raceButton.Size = new System.Drawing.Size(207, 120);
            this.raceButton.TabIndex = 19;
            this.raceButton.Text = "Race!";
            this.raceButton.UseVisualStyleBackColor = true;
            this.raceButton.Click += new System.EventHandler(this.raceButton_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 5;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1180, 593);
            this.Controls.Add(this.raceButton);
            this.Controls.Add(this.alsBetLabel);
            this.Controls.Add(this.bobsBetLabel);
            this.Controls.Add(this.joesBetLabel);
            this.Controls.Add(this.confirmButton);
            this.Controls.Add(this.dogNumericUpDown);
            this.Controls.Add(this.bucksOnLabel);
            this.Controls.Add(this.betNumericUpDown);
            this.Controls.Add(this.betNameLabel);
            this.Controls.Add(this.AlRadioButton);
            this.Controls.Add(this.bobRadioButton);
            this.Controls.Add(this.joeRadioButton);
            this.Controls.Add(this.minimumBetLabel);
            this.Controls.Add(this.betsLabel);
            this.Controls.Add(this.bettingParlourLabel);
            this.Controls.Add(this.dogPicture4);
            this.Controls.Add(this.dogPicture3);
            this.Controls.Add(this.dogPicture2);
            this.Controls.Add(this.dogPicture1);
            this.Controls.Add(this.raceTrackPicture);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "A Day at the Races";
            ((System.ComponentModel.ISupportInitialize)(this.raceTrackPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dogPicture1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dogPicture2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dogPicture3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dogPicture4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.betNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dogNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox raceTrackPicture;
        private System.Windows.Forms.PictureBox dogPicture1;
        private System.Windows.Forms.PictureBox dogPicture2;
        private System.Windows.Forms.PictureBox dogPicture3;
        private System.Windows.Forms.PictureBox dogPicture4;
        private System.Windows.Forms.Label bettingParlourLabel;
        private System.Windows.Forms.Label betsLabel;
        private System.Windows.Forms.Label minimumBetLabel;
        private System.Windows.Forms.RadioButton joeRadioButton;
        private System.Windows.Forms.RadioButton bobRadioButton;
        private System.Windows.Forms.RadioButton AlRadioButton;
        private System.Windows.Forms.Label betNameLabel;
        private System.Windows.Forms.NumericUpDown betNumericUpDown;
        private System.Windows.Forms.Label bucksOnLabel;
        private System.Windows.Forms.NumericUpDown dogNumericUpDown;
        private System.Windows.Forms.Button confirmButton;
        private System.Windows.Forms.Label joesBetLabel;
        private System.Windows.Forms.Label bobsBetLabel;
        private System.Windows.Forms.Label alsBetLabel;
        private System.Windows.Forms.Button raceButton;
        private System.Windows.Forms.Timer timer1;
    }
}

