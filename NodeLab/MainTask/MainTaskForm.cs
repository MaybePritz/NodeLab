using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NodeLab.MainTask
{
    public partial class MainTaskForm : Form
    {
        private SingleLinkedList ll;
        public MainTaskForm(SingleLinkedList ll)
        {
            InitializeComponent();
            this.ll = ll;
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            int value1 = int.Parse(textBox1.Text);
            int value2 = int.Parse(textBox2.Text);
            string error = "";

            ll.DeleteBetween(value1, value2, out error);

            if (error == "")
            {
                PrintListForm form = new PrintListForm(ll);
                form.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show(
                    error,
                    "Ошибка",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
