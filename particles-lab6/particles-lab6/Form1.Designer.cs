namespace particles_lab6 {
    partial class Form1 {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            components = new System.ComponentModel.Container();
            timer1 = new System.Windows.Forms.Timer(components);
            picDisplay = new PictureBox();
            trackBarParticlesAmount = new TrackBar();
            label1 = new Label();
            trackBarLifePeriod = new TrackBar();
            label2 = new Label();
            trackBarDirection = new TrackBar();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            labelParticleCounter = new Label();
            label7 = new Label();
            trackBar1 = new TrackBar();
            trackBarGravity = new TrackBar();
            trackBarSpeed = new TrackBar();
            lblParticleAmount = new Label();
            lblLifePeriod = new Label();
            lblDirection = new Label();
            lblGravity = new Label();
            lblSpeed = new Label();
            ((System.ComponentModel.ISupportInitialize)picDisplay).BeginInit();
            ((System.ComponentModel.ISupportInitialize)trackBarParticlesAmount).BeginInit();
            ((System.ComponentModel.ISupportInitialize)trackBarLifePeriod).BeginInit();
            ((System.ComponentModel.ISupportInitialize)trackBarDirection).BeginInit();
            ((System.ComponentModel.ISupportInitialize)trackBar1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)trackBarGravity).BeginInit();
            ((System.ComponentModel.ISupportInitialize)trackBarSpeed).BeginInit();
            SuspendLayout();
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Interval = 20;
            timer1.Tick += timer1_Tick;
            // 
            // picDisplay
            // 
            picDisplay.Location = new Point(12, 12);
            picDisplay.Name = "picDisplay";
            picDisplay.Size = new Size(953, 651);
            picDisplay.TabIndex = 0;
            picDisplay.TabStop = false;
            // 
            // trackBarParticlesAmount
            // 
            trackBarParticlesAmount.Location = new Point(984, 36);
            trackBarParticlesAmount.Maximum = 100;
            trackBarParticlesAmount.Name = "trackBarParticlesAmount";
            trackBarParticlesAmount.Size = new Size(246, 45);
            trackBarParticlesAmount.TabIndex = 1;
            trackBarParticlesAmount.Value = 1;
            trackBarParticlesAmount.Scroll += trackBarParticlesAmount_Scroll;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("JetBrains Mono", 11.9999981F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label1.Location = new Point(984, 12);
            label1.Name = "label1";
            label1.Size = new Size(250, 21);
            label1.TabIndex = 2;
            label1.Text = "Количество частиц в такт";
            // 
            // trackBarLifePeriod
            // 
            trackBarLifePeriod.Location = new Point(984, 108);
            trackBarLifePeriod.Maximum = 100;
            trackBarLifePeriod.Minimum = 20;
            trackBarLifePeriod.Name = "trackBarLifePeriod";
            trackBarLifePeriod.Size = new Size(246, 45);
            trackBarLifePeriod.TabIndex = 1;
            trackBarLifePeriod.Value = 20;
            trackBarLifePeriod.Scroll += trackBarLifePeriod_Scroll;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("JetBrains Mono", 11.9999981F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label2.Location = new Point(984, 84);
            label2.Name = "label2";
            label2.Size = new Size(240, 21);
            label2.TabIndex = 2;
            label2.Text = "Продолжительность жизни";
            // 
            // trackBarDirection
            // 
            trackBarDirection.Location = new Point(984, 180);
            trackBarDirection.Maximum = 360;
            trackBarDirection.Name = "trackBarDirection";
            trackBarDirection.Size = new Size(246, 45);
            trackBarDirection.TabIndex = 1;
            trackBarDirection.Scroll += trackBarDirection_Scroll;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("JetBrains Mono", 11.9999981F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label3.Location = new Point(984, 156);
            label3.Name = "label3";
            label3.Size = new Size(120, 21);
            label3.TabIndex = 2;
            label3.Text = "Направление";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("JetBrains Mono", 11.9999981F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label4.Location = new Point(984, 296);
            label4.Name = "label4";
            label4.Size = new Size(90, 21);
            label4.TabIndex = 2;
            label4.Text = "Скорость";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("JetBrains Mono", 11.9999981F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label5.Location = new Point(984, 368);
            label5.Name = "label5";
            label5.Size = new Size(190, 21);
            label5.TabIndex = 2;
            label5.Text = "Количество частиц:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("JetBrains Mono", 11.9999981F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label6.Location = new Point(984, 405);
            label6.Name = "label6";
            label6.Size = new Size(0, 21);
            label6.TabIndex = 2;
            // 
            // labelParticleCounter
            // 
            labelParticleCounter.AutoSize = true;
            labelParticleCounter.Font = new Font("JetBrains Mono", 11.9999981F, FontStyle.Regular, GraphicsUnit.Point, 204);
            labelParticleCounter.Location = new Point(990, 405);
            labelParticleCounter.Name = "labelParticleCounter";
            labelParticleCounter.Size = new Size(20, 21);
            labelParticleCounter.TabIndex = 2;
            labelParticleCounter.Text = "0";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("JetBrains Mono", 11.9999981F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label7.Location = new Point(984, 228);
            label7.Name = "label7";
            label7.Size = new Size(110, 21);
            label7.TabIndex = 2;
            label7.Text = "Притяжение";
            // 
            // trackBar1
            // 
            trackBar1.Location = new Point(984, 252);
            trackBar1.Name = "trackBar1";
            trackBar1.Size = new Size(246, 45);
            trackBar1.TabIndex = 1;
            // 
            // trackBarGravity
            // 
            trackBarGravity.Location = new Point(984, 252);
            trackBarGravity.Maximum = 1000;
            trackBarGravity.Minimum = 100;
            trackBarGravity.Name = "trackBarGravity";
            trackBarGravity.Size = new Size(246, 45);
            trackBarGravity.TabIndex = 1;
            trackBarGravity.Value = 100;
            trackBarGravity.Scroll += trackBarGravity_Scroll;
            // 
            // trackBarSpeed
            // 
            trackBarSpeed.Location = new Point(984, 320);
            trackBarSpeed.Maximum = 50;
            trackBarSpeed.Minimum = 10;
            trackBarSpeed.Name = "trackBarSpeed";
            trackBarSpeed.Size = new Size(246, 45);
            trackBarSpeed.TabIndex = 1;
            trackBarSpeed.Value = 10;
            trackBarSpeed.Scroll += trackBarSpeed_Scroll;
            // 
            // lblParticleAmount
            // 
            lblParticleAmount.AutoSize = true;
            lblParticleAmount.Location = new Point(1236, 36);
            lblParticleAmount.Name = "lblParticleAmount";
            lblParticleAmount.Size = new Size(13, 15);
            lblParticleAmount.TabIndex = 3;
            lblParticleAmount.Text = "1";
            // 
            // lblLifePeriod
            // 
            lblLifePeriod.AutoSize = true;
            lblLifePeriod.Location = new Point(1236, 108);
            lblLifePeriod.Name = "lblLifePeriod";
            lblLifePeriod.Size = new Size(19, 15);
            lblLifePeriod.TabIndex = 3;
            lblLifePeriod.Text = "20";
            // 
            // lblDirection
            // 
            lblDirection.AutoSize = true;
            lblDirection.Location = new Point(1236, 180);
            lblDirection.Name = "lblDirection";
            lblDirection.Size = new Size(18, 15);
            lblDirection.TabIndex = 3;
            lblDirection.Text = "0°";
            // 
            // lblGravity
            // 
            lblGravity.AutoSize = true;
            lblGravity.Location = new Point(1236, 252);
            lblGravity.Name = "lblGravity";
            lblGravity.Size = new Size(25, 15);
            lblGravity.TabIndex = 3;
            lblGravity.Text = "100";
            // 
            // lblSpeed
            // 
            lblSpeed.AutoSize = true;
            lblSpeed.Location = new Point(1236, 320);
            lblSpeed.Name = "lblSpeed";
            lblSpeed.Size = new Size(19, 15);
            lblSpeed.TabIndex = 3;
            lblSpeed.Text = "10";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1293, 675);
            Controls.Add(lblSpeed);
            Controls.Add(lblGravity);
            Controls.Add(lblDirection);
            Controls.Add(lblLifePeriod);
            Controls.Add(lblParticleAmount);
            Controls.Add(label6);
            Controls.Add(labelParticleCounter);
            Controls.Add(label5);
            Controls.Add(label7);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(trackBarSpeed);
            Controls.Add(trackBarGravity);
            Controls.Add(trackBarDirection);
            Controls.Add(label1);
            Controls.Add(trackBarLifePeriod);
            Controls.Add(trackBarParticlesAmount);
            Controls.Add(picDisplay);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)picDisplay).EndInit();
            ((System.ComponentModel.ISupportInitialize)trackBarParticlesAmount).EndInit();
            ((System.ComponentModel.ISupportInitialize)trackBarLifePeriod).EndInit();
            ((System.ComponentModel.ISupportInitialize)trackBarDirection).EndInit();
            ((System.ComponentModel.ISupportInitialize)trackBar1).EndInit();
            ((System.ComponentModel.ISupportInitialize)trackBarGravity).EndInit();
            ((System.ComponentModel.ISupportInitialize)trackBarSpeed).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private PictureBox picDisplay;
        private TrackBar trackBarParticlesAmount;
        private Label label1;
        private TrackBar trackBarLifePeriod;
        private Label label2;
        private TrackBar trackBarDirection;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label labelParticleCounter;
        private Label label7;
        private TrackBar trackBar1;
        private TrackBar trackBarGravity;
        private TrackBar trackBarSpeed;
        private Label lblParticleAmount;
        private Label lblLifePeriod;
        private Label lblDirection;
        private Label lblGravity;
        private Label lblSpeed;
    }
}
