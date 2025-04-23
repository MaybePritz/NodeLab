using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NodeLab.DeleteElement
{
    public partial class DeleteCustomForm : Form
    {
        private SingleLinkedList ll;
        public DeleteCustomForm(SingleLinkedList linkedList)
        {
            InitializeComponent();
            ll = linkedList;
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            string input = textBox1.Text;
            if (Int32.TryParse(input, out int position))
            {
                ll.DeleteCustom(position, out string errorMessage);

                if (errorMessage == "")
                {
                    PrintListForm form = new PrintListForm(ll);
                    form.ShowDialog();
                }
                else
                {
                    MessageBox.Show(
                        errorMessage,
                        "Ошибка",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error
                    );
                }

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
