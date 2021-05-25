using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace task
{
    public partial class Form2 : Form
    {
        public Form2(string task ="",string descr="")
        {
            InitializeComponent();
            textBox1.Text = task;
            richTextBox1.Text = descr;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (GetTask() == "" | GetDescr() == "")
            {
                DialogResult result = MessageBox.Show("Одно из полей пустое. Добавить данную задачу?", "Atention", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                    this.DialogResult = DialogResult.OK;
            }
            else
                this.DialogResult = DialogResult.OK;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
            
        public string GetTask()
        {
            return textBox1.Text;
        }
        public string GetDescr()
        {
            return richTextBox1.Text;
        }
   
    }
}
