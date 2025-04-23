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
        public partial class CreateListForm : Form
        {
            private SingleLinkedList ll;

            public CreateListForm(SingleLinkedList linkedList)
            {
                InitializeComponent();
                ll = linkedList;
            }

        private void okButton_Click(object sender, EventArgs e)
        {
                string[] numberStrings = textBox1.Text.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                int[] numbers = new int[numberStrings.Length];
                bool allParsed = true;
                int i = 0;

                while (i < numberStrings.Length && allParsed)
                {
                    if (Int32.TryParse(numberStrings[i], out int value))
                    {
                        numbers[i] = value;
                    }
                    else
                    {
                        allParsed = false;
                    }
                    i++;
                }

                if (allParsed)
                {
                    ll.Create_2(numbers);

                    var form = new PrintListForm(ll);
                    form.ShowDialog();

                    this.Close();
                }
                else
                {
                    MessageBox.Show(
                        "Ошибка ввода! Проверьте, что вы ввели только числа, разделённые пробелами.",
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
