namespace NodeLab
{
    partial class InsertFirstForm
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
            SuspendLayout();
            // 
            // cancelButton
            // 
            cancelButton.Location = new Point(366, 233);
            cancelButton.Margin = new Padding(6);
            cancelButton.Name = "cancelButton";
            cancelButton.Size = new Size(139, 49);
            cancelButton.TabIndex = 7;
            cancelButton.Text = "Отмена";
            cancelButton.UseVisualStyleBackColor = true;
            cancelButton.Click += cancelButton_Click;
            // 
            // okButton
            // 
            okButton.Location = new Point(199, 233);
            okButton.Margin = new Padding(6);
            okButton.Name = "okButton";
            okButton.Size = new Size(139, 49);
            okButton.TabIndex = 6;
            okButton.Text = "Добавить";
            okButton.UseVisualStyleBackColor = true;
            okButton.Click += okButton_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(32, 126);
            textBox1.Margin = new Padding(6);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(647, 39);
            textBox1.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(32, 62);
            label1.Margin = new Padding(6, 0, 6, 0);
            label1.Name = "label1";
            label1.Size = new Size(182, 32);
            label1.TabIndex = 4;
            label1.Text = "Введите число:";
            // 
            // InsertFirstForm
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(713, 343);
            Controls.Add(cancelButton);
            Controls.Add(okButton);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Margin = new Padding(6);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "InsertFirstForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Добавление элемента в начало";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button cancelButton;
        private Button okButton;
        private TextBox textBox1;
        private Label label1;
    }
}