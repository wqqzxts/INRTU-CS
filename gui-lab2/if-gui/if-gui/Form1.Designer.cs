namespace if_gui {
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
            textBox1 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            textBox2 = new TextBox();
            label3 = new Label();
            textBox3 = new TextBox();
            label4 = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(12, 64);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(62, 23);
            textBox1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("JetBrains Mono", 11.9999981F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label1.Location = new Point(80, 66);
            label1.Name = "label1";
            label1.Size = new Size(390, 21);
            label1.TabIndex = 1;
            label1.Text = "- Положительное вещественное число \"A\"";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("JetBrains Mono", 11.9999981F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label2.Location = new Point(12, 9);
            label2.Name = "label2";
            label2.Size = new Size(460, 21);
            label2.TabIndex = 1;
            label2.Text = "Является ли  треугольник  ABC  прямоугольным?";
            label2.Click += label1_Click;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(12, 93);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(62, 23);
            textBox2.TabIndex = 0;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("JetBrains Mono", 11.9999981F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label3.Location = new Point(80, 95);
            label3.Name = "label3";
            label3.Size = new Size(390, 21);
            label3.TabIndex = 1;
            label3.Text = "- Положительное вещественное число \"B\"";
            label3.Click += label1_Click;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(12, 122);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(62, 23);
            textBox3.TabIndex = 0;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("JetBrains Mono", 11.9999981F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label4.Location = new Point(80, 124);
            label4.Name = "label4";
            label4.Size = new Size(390, 21);
            label4.TabIndex = 1;
            label4.Text = "- Положительное вещественное число \"B\"";
            label4.Click += label1_Click;
            // 
            // button1
            // 
            button1.Location = new Point(12, 151);
            button1.Name = "button1";
            button1.Size = new Size(458, 59);
            button1.TabIndex = 2;
            button1.Text = "Выяснить!";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(681, 222);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(textBox3);
            Controls.Add(label1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private Label label1;
        private Label label2;
        private TextBox textBox2;
        private Label label3;
        private TextBox textBox3;
        private Label label4;
        private Button button1;
    }
}
