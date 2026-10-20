using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace лаб_43
{
    public partial class Form2 : Form
    {
        private Array1 array;
        private Random random = new Random();
        public Form2()
        {
            InitializeComponent();

            button1.Click += button1_Click;
        }

        private void ShowArray(
           DataGridView grid, Array1 source)
        {
            grid.AllowUserToAddRows = false;
            grid.ReadOnly = true;

            grid.Rows.Clear();
            grid.Columns.Clear();

            // Один стовпець для значень масиву.
            grid.Columns.Add("value", "Значення");
            grid.Columns[0].Width = 100;

            grid.Columns[0].SortMode =
                DataGridViewColumnSortMode.NotSortable;

            grid.RowHeadersWidth = 60;

            // Кожний елемент — в окремому рядку.
            for (int i = 0; i < source.Length; i++)
            {
                int rowIndex = grid.Rows.Add();

                grid.Rows[rowIndex].Cells[0].Value = source[i];
                grid.Rows[rowIndex].HeaderCell.Value = i.ToString();
            }

            grid.ClearSelection();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int n;

                if (!int.TryParse(textBox1.Text, out n))
                    throw new FormatException(
                        "Введіть ціле число N.");

                if (n < 0 || n > 100)
                    throw new ArgumentException(
                        "N має бути від 0 до 100.");

                array = new Array1(n);
                array.FillRandom(random);

                // Початковий масив.
                ShowArray(dataGridView1, array);

                // Інверсний масив.
                Array1 reversed = array.GetReversed();
                ShowArray(dataGridView2, reversed);
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    ex.Message, "Помилка",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }
    }
}
