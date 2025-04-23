using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace NodeLab.AddElement
{
    public partial class InsertCustomForm : Form
    {
        private SingleLinkedList ll;
        public InsertCustomForm(SingleLinkedList linkedList)
        {
            InitializeComponent();
            ll = linkedList;
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            string inputData = textBox1.Text;
            string inputPos = textBox2.Text;

            if (Int32.TryParse(inputData, out int data)
                && Int32.TryParse(inputPos, out int position))
            {
                ll.InsertCustom(data, position, out string errorMessage);

                if(errorMessage == "")
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
                    "Ошибка ввода! Проверьте, что вы ввели только числа в оба поля.",
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
