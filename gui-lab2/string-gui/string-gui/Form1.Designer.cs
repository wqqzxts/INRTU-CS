namespace string_gui {
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
            label1 = new Label();
            button1 = new Button();
            sentenceInput = new TextBox();
            label2 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("JetBrains Mono", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(744, 17);
            label1.TabIndex = 0;
            label1.Text = "Слова с четным количеством символов удаляются - с нечетным дублируются - 'd' меняется на 't'";
            // 
            // button1
            // 
            button1.Font = new Font("JetBrains Mono", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            button1.Location = new Point(12, 98);
            button1.Name = "button1";
            button1.Size = new Size(744, 69);
            button1.TabIndex = 2;
            button1.Text = "Форматировать!";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // sentenceInput
            // 
            sentenceInput.Font = new Font("JetBrains Mono", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            sentenceInput.Location = new Point(12, 69);
            sentenceInput.Name = "sentenceInput";
            sentenceInput.Size = new Size(744, 25);
            sentenceInput.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("JetBrains Mono", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label2.Location = new Point(12, 49);
            label2.Name = "label2";
            label2.Size = new Size(368, 17);
            label2.TabIndex = 0;
            label2.Text = "Пожалуйста, введите предложение в форме ниже:";
            label2.TextAlign = ContentAlignment.TopCenter;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(767, 175);
            Controls.Add(sentenceInput);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button button1;
        private TextBox sentenceInput;
        private Label label2;
    }
}
