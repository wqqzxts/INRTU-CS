﻿namespace delegates_lab5 {
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
            txtLog = new RichTextBox();
            pbMain = new PictureBox();
            timer1 = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)pbMain).BeginInit();
            SuspendLayout();
            // 
            // txtLog
            // 
            txtLog.Location = new Point(645, 12);
            txtLog.Name = "txtLog";
            txtLog.Size = new Size(347, 426);
            txtLog.TabIndex = 0;
            txtLog.Text = "";
            // 
            // pbMain
            // 
            pbMain.Location = new Point(12, 12);
            pbMain.Name = "pbMain";
            pbMain.Size = new Size(627, 426);
            pbMain.TabIndex = 1;
            pbMain.TabStop = false;
            pbMain.Paint += pbMain_Paint;
            pbMain.MouseClick += pbMain_MouseClick;
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Interval = 15;
            timer1.Tick += timer1_Tick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1004, 450);
            Controls.Add(pbMain);
            Controls.Add(txtLog);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pbMain).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private RichTextBox txtLog;
        private PictureBox pbMain;
        private System.Windows.Forms.Timer timer1;
    }
}
