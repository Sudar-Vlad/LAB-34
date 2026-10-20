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

namespace лаб_43
{
    public partial class Form3 : Form
    {
        private Array2 array;

        private Random random = new Random();
        public Form3()
        {
            InitializeComponent();

            button1.Click += button1_Click;

        }

        private void ShowArray(DataGridView grid)
        {
            grid.AllowUserToAddRows = false;
            grid.ReadOnly = true;
            grid.RowHeadersWidth = 60;

            grid.Rows.Clear();
            grid.Columns.Clear();

            // Стовпці матриці.
            for (int j = 0; j < array.Columns; j++)
            {
                grid.Columns.Add("column" + j, j.ToString());
                grid.Columns[j].Width = 60;

                grid.Columns[j].SortMode =
                    DataGridViewColumnSortMode.NotSortable;
            }

            // Стовпець із сумами рядків.
            grid.Columns.Add("sum", "Сума");

            grid.Columns[array.Columns].SortMode =
                DataGridViewColumnSortMode.NotSortable;

            grid.Rows.Add(array.Rows);

            for (int i = 0; i < array.Rows; i++)
            {
                grid.Rows[i].HeaderCell.Value = i.ToString();

                for (int j = 0; j < array.Columns; j++)
                {
                    grid.Rows[i].Cells[j].Value = array[i, j];
                }

                grid.Rows[i].Cells[array.Columns].Value =
                    array.RowSum(i);
            }

            grid.ClearSelection();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int n;
                int m;

                if (!int.TryParse(textBox1.Text, out n) ||
                    !int.TryParse(textBox2.Text, out m))
                {
                    throw new FormatException(
                        "N і M мають бути цілими числами.");
                }

                if (n < 0 || m < 0 || n > 100 || m > 100)
                {
                    throw new ArgumentException(
                        "N і M мають бути від 0 до 100.");
                }

                // Створюємо масив один раз.
                array = new Array2(n, m);

                // Заповнюємо його випадковими числами.
                for (int i = 0; i < array.Rows; i++)
                {
                    for (int j = 0; j < array.Columns; j++)
                    {
                        array[i, j] = random.Next(-50, 51);
                    }
                }

                // Виводимо той самий масив у дві таблиці.
                ShowArray(dataGridView1);
                ShowArray(dataGridView2);

                // Знаходимо рядок із найбільшою сумою.
                int maxRow = 0;
                long maxSum = array.RowSum(0);

                for (int i = 1; i < array.Rows; i++)
                {
                    long sum = array.RowSum(i);

                    if (sum > maxSum)
                    {
                        maxSum = sum;
                        maxRow = i;
                    }
                }

                // Виділяємо рядок тільки в другій таблиці.
                DataGridViewCellStyle style =
                    dataGridView2.Rows[maxRow].DefaultCellStyle;

                style.BackColor = Color.Yellow;
                style.ForeColor = Color.Black;

                style.SelectionBackColor = Color.Yellow;
                style.SelectionForeColor = Color.Black;

                dataGridView2.ClearSelection();

                Text = $"Індекс рядка: {maxRow}. Найбільша сума: {maxSum}";
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    ex.Message,
                    "Помилка",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }
    }
}
