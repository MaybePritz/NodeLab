namespace NodeLab
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            toolStrip1 = new ToolStrip();
            mainbtn = new ToolStripButton();
            tasks = new ToolStripDropDownButton();
            tasks_createList = new ToolStripMenuItem();
            tasks_editList = new ToolStripMenuItem();
            tasks_editList_add = new ToolStripMenuItem();
            tasks_editList_add_start = new ToolStripMenuItem();
            tasks_editList_add_end = new ToolStripMenuItem();
            tasks_editList_add_point = new ToolStripMenuItem();
            tasks_editList_delete = new ToolStripMenuItem();
            tasks_editList_delete_start = new ToolStripMenuItem();
            tasks_editList_delete_end = new ToolStripMenuItem();
            tasks_editList_delete_point = new ToolStripMenuItem();
            tasks_mainTask = new ToolStripMenuItem();
            task_deleteList = new ToolStripMenuItem();
            exitbtn = new ToolStripButton();
            container = new Panel();
            toolStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // toolStrip1
            // 
            toolStrip1.ImageScalingSize = new Size(32, 32);
            toolStrip1.Items.AddRange(new ToolStripItem[] { mainbtn, tasks, exitbtn });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Padding = new Padding(0, 0, 2, 0);
            toolStrip1.Size = new Size(524, 25);
            toolStrip1.TabIndex = 0;
            toolStrip1.Text = "toolStrip";
            // 
            // mainbtn
            // 
            mainbtn.DisplayStyle = ToolStripItemDisplayStyle.Text;
            mainbtn.Image = (Image)resources.GetObject("mainbtn.Image");
            mainbtn.ImageTransparentColor = Color.Magenta;
            mainbtn.Name = "mainbtn";
            mainbtn.Size = new Size(86, 22);
            mainbtn.Text = "О программе";
            // 
            // tasks
            // 
            tasks.DisplayStyle = ToolStripItemDisplayStyle.Text;
            tasks.DropDownItems.AddRange(new ToolStripItem[] { tasks_createList, tasks_editList, tasks_mainTask, task_deleteList });
            tasks.Image = (Image)resources.GetObject("tasks.Image");
            tasks.ImageTransparentColor = Color.Magenta;
            tasks.Name = "tasks";
            tasks.Size = new Size(65, 22);
            tasks.Text = "Задание";
            // 
            // tasks_createList
            // 
            tasks_createList.Name = "tasks_createList";
            tasks_createList.Size = new Size(204, 22);
            tasks_createList.Text = "Создание списка";
            tasks_createList.Click += tasks_createList_Click;
            // 
            // tasks_editList
            // 
            tasks_editList.DropDownItems.AddRange(new ToolStripItem[] { tasks_editList_add, tasks_editList_delete });
            tasks_editList.Name = "tasks_editList";
            tasks_editList.Size = new Size(204, 22);
            tasks_editList.Text = "Редактирование списка";
            // 
            // tasks_editList_add
            // 
            tasks_editList_add.DropDownItems.AddRange(new ToolStripItem[] { tasks_editList_add_start, tasks_editList_add_end, tasks_editList_add_point });
            tasks_editList_add.Name = "tasks_editList_add";
            tasks_editList_add.Size = new Size(196, 22);
            tasks_editList_add.Text = "Добавление элемента";
            // 
            // tasks_editList_add_start
            // 
            tasks_editList_add_start.Name = "tasks_editList_add_start";
            tasks_editList_add_start.Size = new Size(200, 22);
            tasks_editList_add_start.Text = "В начало";
            tasks_editList_add_start.Click += tasks_editList_add_start_Click;
            // 
            // tasks_editList_add_end
            // 
            tasks_editList_add_end.Name = "tasks_editList_add_end";
            tasks_editList_add_end.Size = new Size(200, 22);
            tasks_editList_add_end.Text = "В конец";
            tasks_editList_add_end.Click += tasks_editList_add_end_Click;
            // 
            // tasks_editList_add_point
            // 
            tasks_editList_add_point.Name = "tasks_editList_add_point";
            tasks_editList_add_point.Size = new Size(200, 22);
            tasks_editList_add_point.Text = "В произвольную точку";
            tasks_editList_add_point.Click += tasks_editList_add_point_Click;
            // 
            // tasks_editList_delete
            // 
            tasks_editList_delete.DropDownItems.AddRange(new ToolStripItem[] { tasks_editList_delete_start, tasks_editList_delete_end, tasks_editList_delete_point });
            tasks_editList_delete.Name = "tasks_editList_delete";
            tasks_editList_delete.Size = new Size(196, 22);
            tasks_editList_delete.Text = "Удаление элемента";
            // 
            // tasks_editList_delete_start
            // 
            tasks_editList_delete_start.Name = "tasks_editList_delete_start";
            tasks_editList_delete_start.Size = new Size(198, 22);
            tasks_editList_delete_start.Text = "В начале";
            tasks_editList_delete_start.Click += tasks_editList_delete_start_Click;
            // 
            // tasks_editList_delete_end
            // 
            tasks_editList_delete_end.Name = "tasks_editList_delete_end";
            tasks_editList_delete_end.Size = new Size(198, 22);
            tasks_editList_delete_end.Text = "В конце";
            tasks_editList_delete_end.Click += tasks_editList_delete_end_Click;
            // 
            // tasks_editList_delete_point
            // 
            tasks_editList_delete_point.Name = "tasks_editList_delete_point";
            tasks_editList_delete_point.Size = new Size(198, 22);
            tasks_editList_delete_point.Text = "В произвольной точке";
            tasks_editList_delete_point.Click += tasks_editList_delete_point_Click;
            // 
            // tasks_mainTask
            // 
            tasks_mainTask.Name = "tasks_mainTask";
            tasks_mainTask.Size = new Size(204, 22);
            tasks_mainTask.Text = "Обработка списка";
            tasks_mainTask.Click += tasks_mainTask_Click;
            // 
            // task_deleteList
            // 
            task_deleteList.Name = "task_deleteList";
            task_deleteList.Size = new Size(204, 22);
            task_deleteList.Text = "Разрушение списка";
            task_deleteList.Click += task_deleteList_Click;
            // 
            // exitbtn
            // 
            exitbtn.DisplayStyle = ToolStripItemDisplayStyle.Text;
            exitbtn.Image = (Image)resources.GetObject("exitbtn.Image");
            exitbtn.ImageTransparentColor = Color.Magenta;
            exitbtn.Name = "exitbtn";
            exitbtn.Size = new Size(45, 22);
            exitbtn.Text = "Выход";
            exitbtn.Click += exitbtn_Click;
            // 
            // container
            // 
            container.Dock = DockStyle.Fill;
            container.Location = new Point(0, 25);
            container.Margin = new Padding(2, 1, 2, 1);
            container.Name = "container";
            container.Size = new Size(524, 317);
            container.TabIndex = 1;
            container.Paint += container_Paint;
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(524, 342);
            Controls.Add(container);
            Controls.Add(toolStrip1);
            Margin = new Padding(2, 1, 2, 1);
            Name = "Main";
            Text = "О программе";
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ToolStrip toolStrip1;
        private ToolStripButton mainbtn;
        private ToolStripDropDownButton tasks;
        private ToolStripMenuItem tasks_createList;
        private ToolStripButton exitbtn;
        private ToolStripMenuItem tasks_editList;
        private ToolStripMenuItem tasks_editList_add;
        private ToolStripMenuItem tasks_editList_add_start;
        private ToolStripMenuItem tasks_editList_add_end;
        private ToolStripMenuItem tasks_editList_add_point;
        private ToolStripMenuItem tasks_editList_delete;
        private ToolStripMenuItem tasks_editList_delete_start;
        private ToolStripMenuItem tasks_editList_delete_end;
        private ToolStripMenuItem tasks_editList_delete_point;
        private ToolStripMenuItem tasks_mainTask;
        private ToolStripMenuItem task_deleteList;
        private Panel container;
    }
}