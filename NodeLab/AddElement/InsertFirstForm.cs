using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace NodeLab
{
    public partial class InsertFirstForm : Form
    {
        private SingleLinkedList ll;
        public InsertFirstForm(SingleLinkedList linkedList)
        {
            InitializeComponent();
            ll = linkedList;
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            string input = textBox1.Text;
            if (Int32.TryParse(input, out int data))
            {
                ll.InsertBeforeFirst(data);

                PrintListForm form = new PrintListForm(ll);
                form.ShowDialog();

                this.Close();
            }
            else
            {
                MessageBox.Show(
                    "Ошибка ввода! Проверьте, что вы ввели только числа.",
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
