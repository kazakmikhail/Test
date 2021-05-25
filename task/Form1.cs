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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 add = new Form2();
            add.ShowDialog();
            if (add.DialogResult == DialogResult.OK)
            {
                dataGridView1.Rows.Add(false, add.GetTask(), add.GetDescr());
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are u Sure?", "achtung!", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                dataGridView1.Rows.Clear();
            }
            else if (dialogResult == DialogResult.No)
            {
                return;
            }
        }


        private void button3_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                foreach (DataGridViewRow row in dataGridView1.SelectedRows)
                {
                    dataGridView1.Rows.Remove(row);
                }
            }
            else
                MessageBox.Show("Для удаления задачи, выберете строку!", "Alert");


        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                Form2 edit = new Form2(dataGridView1.SelectedRows[0].Cells[1].Value.ToString(),
                    dataGridView1.SelectedRows[0].Cells[2].Value.ToString());
                edit.ShowDialog();
                if (edit.DialogResult == DialogResult.OK)
                {
                    dataGridView1.SelectedRows[0].Cells[1].Value = edit.GetTask();
                    dataGridView1.SelectedRows[0].Cells[2].Value = edit.GetDescr();
                }
            }
            else
                MessageBox.Show("Для изменения выберите строку!", "alarm!");
        }


        private void check(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0 && e.RowIndex != -1)
            {
                int num = dataGridView1.SelectedCells[0].RowIndex;
                if ((Boolean)dataGridView1.SelectedCells[0].Value)
                {
                    dataGridView1.Rows[num].DefaultCellStyle.BackColor = Color.LightGreen;
                }
                else
                    dataGridView1.Rows[num].DefaultCellStyle.BackColor = Color.White;
                dataGridView1.EndEdit();
            }
        }

        private void dataGridView1_OnCellMouseUp(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.ColumnIndex == 0 && e.RowIndex != -1)
            {
                int num = dataGridView1.SelectedCells[0].RowIndex;
                var check = dataGridView1.SelectedCells[0];
                if (true)
                {

                }
                dataGridView1.EndEdit();
            }
        }
    }
}
