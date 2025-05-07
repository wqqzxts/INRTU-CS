namespace inheritance_lab4 {
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
            buttonRefill = new Button();
            textInfo = new RichTextBox();
            buttonGet = new Button();
            textOut = new RichTextBox();
            SuspendLayout();
            // 
            // buttonRefill
            // 
            buttonRefill.Font = new Font("JetBrains Mono", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            buttonRefill.Location = new Point(12, 12);
            buttonRefill.Name = "buttonRefill";
            buttonRefill.Size = new Size(351, 43);
            buttonRefill.TabIndex = 0;
            buttonRefill.Text = "Перезаполнить";
            buttonRefill.UseVisualStyleBackColor = true;
            buttonRefill.Click += buttonRefill_Click;
            // 
            // textInfo
            // 
            textInfo.Font = new Font("JetBrains Mono", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textInfo.Location = new Point(12, 61);
            textInfo.Name = "textInfo";
            textInfo.Size = new Size(351, 80);
            textInfo.TabIndex = 1;
            textInfo.Text = "";
            // 
            // buttonGet
            // 
            buttonGet.Font = new Font("JetBrains Mono", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            buttonGet.Location = new Point(268, 147);
            buttonGet.Name = "buttonGet";
            buttonGet.Size = new Size(95, 155);
            buttonGet.TabIndex = 0;
            buttonGet.Text = "Получить";
            buttonGet.UseVisualStyleBackColor = true;
            buttonGet.Click += buttonGet_Click;
            // 
            // textOut
            // 
            textOut.Font = new Font("JetBrains Mono", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textOut.Location = new Point(12, 147);
            textOut.Name = "textOut";
            textOut.Size = new Size(250, 155);
            textOut.TabIndex = 1;
            textOut.Text = "";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(375, 314);
            Controls.Add(textOut);
            Controls.Add(textInfo);
            Controls.Add(buttonGet);
            Controls.Add(buttonRefill);
            Name = "Form1";
            Text = "Form1";            
            ResumeLayout(false);
        }

        #endregion

        private Button buttonRefill;
        private RichTextBox textInfo;
        private Button buttonGet;
        private RichTextBox textOut;
    }
}
