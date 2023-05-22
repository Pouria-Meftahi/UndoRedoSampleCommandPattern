using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UndoRedoWithCommand.Commands;

namespace UndoRedoWithCommand
{
    public partial class Form1 : Form
    {

        InvokerEditText invokerEditText;
        public Form1()
        {

            invokerEditText = new InvokerEditText();
            InitializeComponent();
        }

        private void btnSetText_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1.Text))
            {
                MessageBox.Show("لطفا مقدار را وارد کنید");
            }
            else
            {
                label1.Text = invokerEditText.ExecuteCommand(textBox1.Text);
                textBox1.Text = "";
            }
        }

        private void Undo_Click(object sender, EventArgs e)
        {
            label1.Text = invokerEditText.Undo();
        }

        private void Redo_Click(object sender, EventArgs e)
        {
            label1.Text = invokerEditText.Redo();
        }
    }
}
