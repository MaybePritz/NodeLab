namespace NodeLab
{
    partial class About
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            about_user_title = new Label();
            about_user_name = new Label();
            about_user_group = new Label();
            about_user_var = new Label();
            about_task_title = new Label();
            about_task_info = new Label();
            SuspendLayout();
            // 
            // about_user_title
            // 
            about_user_title.AutoSize = true;
            about_user_title.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            about_user_title.Location = new Point(12, 10);
            about_user_title.Name = "about_user_title";
            about_user_title.Size = new Size(253, 41);
            about_user_title.TabIndex = 1;
            about_user_title.Text = "О разработчике";
            // 
            // about_user_name
            // 
            about_user_name.AutoSize = true;
            about_user_name.Location = new Point(12, 60);
            about_user_name.Name = "about_user_name";
            about_user_name.Size = new Size(352, 32);
            about_user_name.TabIndex = 2;
            about_user_name.Text = "ФИО: Приц Артём Алексеевич";
            // 
            // about_user_group
            // 
            about_user_group.AutoSize = true;
            about_user_group.Location = new Point(12, 100);
            about_user_group.Name = "about_user_group";
            about_user_group.Size = new Size(260, 32);
            about_user_group.TabIndex = 3;
            about_user_group.Text = "Группа: 6106-090301D";
            // 
            // about_user_var
            // 
            about_user_var.AutoSize = true;
            about_user_var.Location = new Point(12, 140);
            about_user_var.Name = "about_user_var";
            about_user_var.Size = new Size(142, 32);
            about_user_var.TabIndex = 4;
            about_user_var.Text = "Вариант: 7";
            // 
            // about_task_title
            // 
            about_task_title.AutoSize = true;
            about_task_title.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            about_task_title.Location = new Point(12, 190);
            about_task_title.Name = "about_task_title";
            about_task_title.Size = new Size(139, 41);
            about_task_title.TabIndex = 5;
            about_task_title.Text = "Задание";
            // 
            // about_task_info
            // 
            about_task_info.AutoSize = true;
            about_task_info.Location = new Point(12, 240);
            about_task_info.Name = "about_task_info";
            about_task_info.Size = new Size(78, 32);
            about_task_info.TabIndex = 6;
            about_task_info.Text = "Исключите из списка все элементы между двумя элементами с заданными\nзначениями информационных полей.";
            // 
            // About
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(about_task_info);
            Controls.Add(about_task_title);
            Controls.Add(about_user_var);
            Controls.Add(about_user_group);
            Controls.Add(about_user_name);
            Controls.Add(about_user_title);
            Name = "About";
            Size = new Size(1000, 800);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label about_user_title;
        private Label about_user_name;
        private Label about_user_group;
        private Label about_user_var;
        private Label about_task_title;
        private Label about_task_info;
    }
}
