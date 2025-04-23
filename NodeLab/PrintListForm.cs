using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NodeLab
{
    public partial class PrintListForm : Form
    {
        private SingleLinkedList ll;
        public PrintListForm(SingleLinkedList ll)
        {
            InitializeComponent();
            this.ll = ll;
        }

        private void PrintListForm_Load(object sender, EventArgs e)
        {
            ll.PrintListBox(listBox1);
        }
    }
}
