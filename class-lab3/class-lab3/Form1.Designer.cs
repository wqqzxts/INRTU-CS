namespace class_lab3 {
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
            textFirst = new TextBox();
            label1 = new Label();
            comboOperation = new ComboBox();
            textSecond = new TextBox();
            comboTypeFirst = new ComboBox();
            comboTypeSecond = new ComboBox();
            textResult = new TextBox();
            comboTypeResult = new ComboBox();
            label2 = new Label();
            label3 = new Label();
            contextMenuStrip1 = new ContextMenuStrip(components);
            SuspendLayout();
            // 
            // textFirst
            // 
            textFirst.Font = new Font("JetBrains Mono", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textFirst.Location = new Point(90, 80);
            textFirst.Name = "textFirst";
            textFirst.Size = new Size(416, 25);
            textFirst.TabIndex = 0;
            textFirst.TextChanged += textFirst_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("JetBrains Mono SemiBold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(573, 25);
            label1.TabIndex = 1;
            label1.Text = "Калькулятор и конвертер температур  C,  Fa,  K,  Ra";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // comboOperation
            // 
            comboOperation.Font = new Font("JetBrains Mono", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            comboOperation.FormattingEnabled = true;
            comboOperation.Items.AddRange(new object[] { "+", "-", "*", ">", "<", "==", "!=" });
            comboOperation.Location = new Point(18, 103);
            comboOperation.Name = "comboOperation";
            comboOperation.Size = new Size(66, 25);
            comboOperation.TabIndex = 2;
            comboOperation.SelectedIndexChanged += onValueChanged;
            // 
            // textSecond
            // 
            textSecond.Font = new Font("JetBrains Mono", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textSecond.Location = new Point(90, 126);
            textSecond.Name = "textSecond";
            textSecond.Size = new Size(416, 25);
            textSecond.TabIndex = 0;
            textSecond.TextChanged += textSecond_TextChanged;
            // 
            // comboTypeFirst
            // 
            comboTypeFirst.Font = new Font("JetBrains Mono", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            comboTypeFirst.FormattingEnabled = true;
            comboTypeFirst.Location = new Point(512, 80);
            comboTypeFirst.Name = "comboTypeFirst";
            comboTypeFirst.Size = new Size(101, 25);
            comboTypeFirst.TabIndex = 2;
            comboTypeFirst.SelectedIndexChanged += onValueChanged;
            // 
            // comboTypeSecond
            // 
            comboTypeSecond.Font = new Font("JetBrains Mono", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            comboTypeSecond.FormattingEnabled = true;
            comboTypeSecond.Location = new Point(512, 126);
            comboTypeSecond.Name = "comboTypeSecond";
            comboTypeSecond.Size = new Size(101, 25);
            comboTypeSecond.TabIndex = 2;
            comboTypeSecond.SelectedIndexChanged += onValueChanged;
            // 
            // textResult
            // 
            textResult.Font = new Font("JetBrains Mono", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textResult.Location = new Point(18, 205);
            textResult.Name = "textResult";
            textResult.Size = new Size(488, 25);
            textResult.TabIndex = 0;
            // 
            // comboTypeResult
            // 
            comboTypeResult.Font = new Font("JetBrains Mono", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            comboTypeResult.FormattingEnabled = true;
            comboTypeResult.Location = new Point(512, 205);
            comboTypeResult.Name = "comboTypeResult";
            comboTypeResult.Size = new Size(101, 25);
            comboTypeResult.TabIndex = 2;
            comboTypeResult.SelectedIndexChanged += onValueChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("JetBrains Mono", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label2.Location = new Point(12, 177);
            label2.Name = "label2";
            label2.Size = new Size(122, 25);
            label2.TabIndex = 1;
            label2.Text = "Результат:";
            label2.TextAlign = ContentAlignment.TopCenter;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("JetBrains Mono SemiBold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label3.Location = new Point(12, 43);
            label3.Name = "label3";
            label3.Size = new Size(177, 25);
            label3.TabIndex = 1;
            label3.Text = "Введите данные:";
            label3.TextAlign = ContentAlignment.TopCenter;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(625, 247);
            Controls.Add(comboTypeResult);
            Controls.Add(comboTypeSecond);
            Controls.Add(comboTypeFirst);
            Controls.Add(comboOperation);
            Controls.Add(label2);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(textResult);
            Controls.Add(textSecond);
            Controls.Add(textFirst);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textFirst;
        private Label label1;
        private ComboBox comboOperation;
        private TextBox textSecond;
        private ComboBox comboTypeFirst;
        private ComboBox comboTypeSecond;
        private TextBox textResult;
        private ComboBox comboTypeResult;
        private Label label2;
        private Label label3;
        private ContextMenuStrip contextMenuStrip1;
    }
}
