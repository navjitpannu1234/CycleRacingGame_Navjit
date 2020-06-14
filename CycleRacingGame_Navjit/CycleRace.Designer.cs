namespace CycleRacingGame_Navjit
{
    partial class CycleRace
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
            this.RaceBtn = new System.Windows.Forms.Button();
            this.betBtn = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.MinimumBet = new System.Windows.Forms.Label();
            this.labelRanjitBet = new System.Windows.Forms.Label();
            this.labelKuljitBet = new System.Windows.Forms.Label();
            this.labelNavjitBet = new System.Windows.Forms.Label();
            this.numericUpDownCar = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownBets = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.radioButtonRanjit = new System.Windows.Forms.RadioButton();
            this.radioButtonKuljit = new System.Windows.Forms.RadioButton();
            this.radioButtonNavjit = new System.Windows.Forms.RadioButton();
            this.cycleD = new System.Windows.Forms.PictureBox();
            this.cycleC = new System.Windows.Forms.PictureBox();
            this.cycleB = new System.Windows.Forms.PictureBox();
            this.cycleA = new System.Windows.Forms.PictureBox();
            this.cycleRaceTrack = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownBets)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cycleD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cycleC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cycleB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cycleA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cycleRaceTrack)).BeginInit();
            this.SuspendLayout();
            // 
            // RaceBtn
            // 
            this.RaceBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RaceBtn.Location = new System.Drawing.Point(588, 422);
            this.RaceBtn.Name = "RaceBtn";
            this.RaceBtn.Size = new System.Drawing.Size(92, 32);
            this.RaceBtn.TabIndex = 41;
            this.RaceBtn.Text = "Race!";
            this.RaceBtn.UseVisualStyleBackColor = true;
            this.RaceBtn.Click += new System.EventHandler(this.RaceBtn_Click);
            // 
            // betBtn
            // 
            this.betBtn.Location = new System.Drawing.Point(142, 418);
            this.betBtn.Name = "betBtn";
            this.betBtn.Size = new System.Drawing.Size(112, 42);
            this.betBtn.TabIndex = 40;
            this.betBtn.Text = "Place Bet";
            this.betBtn.UseVisualStyleBackColor = true;
            this.betBtn.Click += new System.EventHandler(this.betBtn_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.MinimumBet);
            this.groupBox1.Controls.Add(this.labelRanjitBet);
            this.groupBox1.Controls.Add(this.labelKuljitBet);
            this.groupBox1.Controls.Add(this.labelNavjitBet);
            this.groupBox1.Controls.Add(this.numericUpDownCar);
            this.groupBox1.Controls.Add(this.numericUpDownBets);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.radioButtonRanjit);
            this.groupBox1.Controls.Add(this.radioButtonKuljit);
            this.groupBox1.Controls.Add(this.radioButtonNavjit);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(28, 469);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(862, 128);
            this.groupBox1.TabIndex = 39;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Betting System";
            // 
            // MinimumBet
            // 
            this.MinimumBet.AutoSize = true;
            this.MinimumBet.Location = new System.Drawing.Point(243, 38);
            this.MinimumBet.Name = "MinimumBet";
            this.MinimumBet.Size = new System.Drawing.Size(78, 13);
            this.MinimumBet.TabIndex = 26;
            this.MinimumBet.Text = "Minimum Bet";
            // 
            // labelRanjitBet
            // 
            this.labelRanjitBet.AutoSize = true;
            this.labelRanjitBet.BackColor = System.Drawing.Color.White;
            this.labelRanjitBet.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelRanjitBet.Location = new System.Drawing.Point(529, 106);
            this.labelRanjitBet.Name = "labelRanjitBet";
            this.labelRanjitBet.Size = new System.Drawing.Size(144, 15);
            this.labelRanjitBet.TabIndex = 25;
            this.labelRanjitBet.Text = "Ranjit hasn\'t placed bet";
            // 
            // labelKuljitBet
            // 
            this.labelKuljitBet.AutoSize = true;
            this.labelKuljitBet.BackColor = System.Drawing.Color.White;
            this.labelKuljitBet.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelKuljitBet.Location = new System.Drawing.Point(529, 66);
            this.labelKuljitBet.Name = "labelKuljitBet";
            this.labelKuljitBet.Size = new System.Drawing.Size(139, 15);
            this.labelKuljitBet.TabIndex = 24;
            this.labelKuljitBet.Text = "Kuljit hasn\'t placed bet";
            // 
            // labelNavjitBet
            // 
            this.labelNavjitBet.AutoSize = true;
            this.labelNavjitBet.BackColor = System.Drawing.Color.White;
            this.labelNavjitBet.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelNavjitBet.Location = new System.Drawing.Point(529, 28);
            this.labelNavjitBet.Name = "labelNavjitBet";
            this.labelNavjitBet.Size = new System.Drawing.Size(144, 15);
            this.labelNavjitBet.TabIndex = 23;
            this.labelNavjitBet.Text = "Navjit hasn\'t placed bet";
            // 
            // numericUpDownCar
            // 
            this.numericUpDownCar.Location = new System.Drawing.Point(412, 74);
            this.numericUpDownCar.Maximum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.numericUpDownCar.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownCar.Name = "numericUpDownCar";
            this.numericUpDownCar.Size = new System.Drawing.Size(44, 20);
            this.numericUpDownCar.TabIndex = 22;
            this.numericUpDownCar.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // numericUpDownBets
            // 
            this.numericUpDownBets.Location = new System.Drawing.Point(412, 36);
            this.numericUpDownBets.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownBets.Name = "numericUpDownBets";
            this.numericUpDownBets.Size = new System.Drawing.Size(44, 20);
            this.numericUpDownBets.TabIndex = 21;
            this.numericUpDownBets.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(387, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(19, 13);
            this.label2.TabIndex = 20;
            this.label2.Text = " #";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(392, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(14, 13);
            this.label1.TabIndex = 19;
            this.label1.Text = "$";
            // 
            // radioButtonRanjit
            // 
            this.radioButtonRanjit.AutoSize = true;
            this.radioButtonRanjit.Location = new System.Drawing.Point(34, 106);
            this.radioButtonRanjit.Name = "radioButtonRanjit";
            this.radioButtonRanjit.Size = new System.Drawing.Size(58, 17);
            this.radioButtonRanjit.TabIndex = 2;
            this.radioButtonRanjit.TabStop = true;
            this.radioButtonRanjit.Text = "Ranjit";
            this.radioButtonRanjit.UseVisualStyleBackColor = true;
            // 
            // radioButtonKuljit
            // 
            this.radioButtonKuljit.AutoSize = true;
            this.radioButtonKuljit.Location = new System.Drawing.Point(34, 64);
            this.radioButtonKuljit.Name = "radioButtonKuljit";
            this.radioButtonKuljit.Size = new System.Drawing.Size(53, 17);
            this.radioButtonKuljit.TabIndex = 1;
            this.radioButtonKuljit.TabStop = true;
            this.radioButtonKuljit.Text = "Kuljit";
            this.radioButtonKuljit.UseVisualStyleBackColor = true;
            // 
            // radioButtonNavjit
            // 
            this.radioButtonNavjit.AutoSize = true;
            this.radioButtonNavjit.Location = new System.Drawing.Point(34, 28);
            this.radioButtonNavjit.Name = "radioButtonNavjit";
            this.radioButtonNavjit.Size = new System.Drawing.Size(58, 17);
            this.radioButtonNavjit.TabIndex = 0;
            this.radioButtonNavjit.TabStop = true;
            this.radioButtonNavjit.Text = "Navjit";
            this.radioButtonNavjit.UseVisualStyleBackColor = true;
            // 
            // cycleD
            // 
            this.cycleD.Image = global::CycleRacingGame_Navjit.Properties.Resources._1___Copy1;
            this.cycleD.Location = new System.Drawing.Point(28, 302);
            this.cycleD.Name = "cycleD";
            this.cycleD.Size = new System.Drawing.Size(100, 50);
            this.cycleD.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.cycleD.TabIndex = 45;
            this.cycleD.TabStop = false;
            // 
            // cycleC
            // 
            this.cycleC.Image = global::CycleRacingGame_Navjit.Properties.Resources._1___Copy1;
            this.cycleC.Location = new System.Drawing.Point(28, 212);
            this.cycleC.Name = "cycleC";
            this.cycleC.Size = new System.Drawing.Size(100, 50);
            this.cycleC.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.cycleC.TabIndex = 44;
            this.cycleC.TabStop = false;
            // 
            // cycleB
            // 
            this.cycleB.Image = global::CycleRacingGame_Navjit.Properties.Resources._1___Copy1;
            this.cycleB.Location = new System.Drawing.Point(28, 119);
            this.cycleB.Name = "cycleB";
            this.cycleB.Size = new System.Drawing.Size(100, 50);
            this.cycleB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.cycleB.TabIndex = 43;
            this.cycleB.TabStop = false;
            // 
            // cycleA
            // 
            this.cycleA.Image = global::CycleRacingGame_Navjit.Properties.Resources._1___Copy;
            this.cycleA.Location = new System.Drawing.Point(28, 42);
            this.cycleA.Name = "cycleA";
            this.cycleA.Size = new System.Drawing.Size(100, 50);
            this.cycleA.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.cycleA.TabIndex = 42;
            this.cycleA.TabStop = false;
            // 
            // cycleRaceTrack
            // 
            this.cycleRaceTrack.Image = global::CycleRacingGame_Navjit.Properties.Resources.track;
            this.cycleRaceTrack.Location = new System.Drawing.Point(0, 0);
            this.cycleRaceTrack.Name = "cycleRaceTrack";
            this.cycleRaceTrack.Size = new System.Drawing.Size(900, 400);
            this.cycleRaceTrack.TabIndex = 0;
            this.cycleRaceTrack.TabStop = false;
            // 
            // CycleRace
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(902, 611);
            this.Controls.Add(this.cycleD);
            this.Controls.Add(this.cycleC);
            this.Controls.Add(this.cycleB);
            this.Controls.Add(this.cycleA);
            this.Controls.Add(this.RaceBtn);
            this.Controls.Add(this.betBtn);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.cycleRaceTrack);
            this.Name = "CycleRace";
            this.Text = "Cycle Race";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownBets)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cycleD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cycleC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cycleB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cycleA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cycleRaceTrack)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox cycleRaceTrack;
        private System.Windows.Forms.Button RaceBtn;
        private System.Windows.Forms.Button betBtn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label MinimumBet;
        private System.Windows.Forms.Label labelRanjitBet;
        private System.Windows.Forms.Label labelKuljitBet;
        private System.Windows.Forms.Label labelNavjitBet;
        private System.Windows.Forms.NumericUpDown numericUpDownCar;
        private System.Windows.Forms.NumericUpDown numericUpDownBets;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton radioButtonRanjit;
        private System.Windows.Forms.RadioButton radioButtonKuljit;
        private System.Windows.Forms.RadioButton radioButtonNavjit;
        private System.Windows.Forms.PictureBox cycleA;
        private System.Windows.Forms.PictureBox cycleB;
        private System.Windows.Forms.PictureBox cycleC;
        private System.Windows.Forms.PictureBox cycleD;
    }
}

