namespace NodeLab.AddElement
{
    partial class InsertCustomForm
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
            cancelButton = new Button();
            okButton = new Button();
            textBox1 = new TextBox();
            label1 = new Label();
            textBox2 = new TextBox();
            label2 = new Label();
            SuspendLayout();
            // 
            // cancelButton
            // 
            cancelButton.Location = new Point(198, 109);
            cancelButton.Name = "cancelButton";
            cancelButton.Size = new Size(75, 23);
            cancelButton.TabIndex = 11;
            cancelButton.Text = "Отмена";
            cancelButton.UseVisualStyleBackColor = true;
            cancelButton.Click += cancelButton_Click;
            // 
            // okButton
            // 
            okButton.Location = new Point(108, 109);
            okButton.Name = "okButton";
            okButton.Size = new Size(75, 23);
            okButton.TabIndex = 10;
            okButton.Text = "Добавить";
            okButton.UseVisualStyleBackColor = true;
            okButton.Click += okButton_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(18, 59);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(170, 23);
            textBox1.TabIndex = 9;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(18, 29);
            label1.Name = "label1";
            label1.Size = new Size(90, 15);
            label1.TabIndex = 8;
            label1.Text = "Введите число:";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(198, 59);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(170, 23);
            textBox2.TabIndex = 12;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(198, 29);
            label2.Name = "label2";
            label2.Size = new Size(106, 15);
            label2.TabIndex = 13;
            label2.Text = "Введите позицию:";
            // 
            // InsertCustomForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(384, 161);
            Controls.Add(label2);
            Controls.Add(textBox2);
            Controls.Add(cancelButton);
            Controls.Add(okButton);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Margin = new Padding(2, 1, 2, 1);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "InsertCustomForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Вставка в произвольную форму";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button cancelButton;
        private Button okButton;
        private TextBox textBox1;
        private Label label1;
        private TextBox textBox2;
        private Label label2;
    }
}