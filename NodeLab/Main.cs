using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using NodeLab.AddElement;
using NodeLab.DeleteElement;
using NodeLab.MainTask;


namespace NodeLab
{
    public partial class Main : Form
    {
        private SingleLinkedList ll = new SingleLinkedList();

        public Main()
        {
            InitializeComponent();

            About about = new About();
            container.Controls.Add(about);
            about.Dock = DockStyle.Fill;
        }


        private void exitbtn_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Вы хотите завершить работу?",
                "Завершение работы",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }

        }

        private void tasks_createList_Click(object sender, EventArgs e)
        {
            CreateListForm form = new CreateListForm(ll);
            form.ShowDialog();
        }

        private void task_deleteList_Click(object sender, EventArgs e)
        {
            ll.Destroy();

            MessageBox.Show("Список разрушен", "Разрушить список");
        }

        private void tasks_editList_add_start_Click(object sender, EventArgs e)
        {
            InsertFirstForm form = new InsertFirstForm(ll);
            form.ShowDialog();

        }

        private void tasks_editList_add_end_Click(object sender, EventArgs e)
        {
            InsertLastForm form = new InsertLastForm(ll);
            form.ShowDialog();
        }

        private void tasks_editList_add_point_Click(object sender, EventArgs e)
        {
            InsertCustomForm form = new InsertCustomForm(ll);
            form.ShowDialog();
        }

        private void tasks_editList_delete_start_Click(object sender, EventArgs e)
        {
            ll.DeleteFirst1();

            PrintListForm form = new PrintListForm(ll);
            form.ShowDialog();

        }

        private void tasks_editList_delete_end_Click(object sender, EventArgs e)
        {
            ll.DeleteLast();

            PrintListForm form = new PrintListForm(ll);
            form.ShowDialog();
        }

        private void tasks_editList_delete_point_Click(object sender, EventArgs e)
        {
            DeleteCustomForm form = new DeleteCustomForm(ll);
            form.ShowDialog();
        }

        private void container_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tasks_mainTask_Click(object sender, EventArgs e)
        {
            MainTaskForm form = new MainTaskForm(ll);
            form.ShowDialog();
        }
    }
}
