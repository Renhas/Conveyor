using ConveyorSystem;
using Permutations;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Timetable;

namespace Forms
{
    public partial class Timetable : UserControl
    {
        List<Color> _colors;
        public List<Color> Colors { get 
            {
                return _colors;
            } set 
            {
                _colors = value;
                TableInit(MainGrid.Tag as int[,]);
            } 
        }
        ColorSelectMenu selectColors;
        
        public Timetable() 
        {
            InitializeComponent();
            Colors = new List<Color>();
            selectColors = new ColorSelectMenu(Colors);
        }
        public Timetable(Result result, List<Color> colors) : this()
        {
            SetResult(result);
            Colors = colors;
            
        }

        public void SetResult(Result result) 
        {
            ResultBox.Text = $"{PermutationToString(result.Permutation)}; " +
                $"Критерий = {result.Criterion}";
            Permutation<Job> permutation = result.Permutation;
            int dif = permutation.Values.Count - Colors.Count;
            if (dif < 0)
                Colors.RemoveRange(permutation.Values.Count() - 1, dif);
            for (int i = Colors.Count(); i < permutation.Values.Count(); i++)
            {
                Colors.Add(Color.Red);
            }
            selectColors = new ColorSelectMenu(Colors);
        }

        private string PermutationToString(Permutation<Job> permutation)
        {
            string str = $"Перестановка: ";
            for (int i = 0; i < permutation.Values.Count; i++) str += $"{permutation.Values[i].Id}, ";

            return str.Remove(str.Length - 2);
        }

        public void TableInit(int[,] matrix) 
        {
            if (matrix == null) return;
            MainGrid.Tag = matrix;
            ColumnsInit(matrix.GetUpperBound(1) + 1);
            RowsInit(matrix.GetUpperBound(0) + 1);

            for (int i = 0; i <= matrix.GetUpperBound(0); i++)
                for (int j = 0; j <= matrix.GetUpperBound(1); j++)
                    CellInit(matrix, i, j);
        }

        private void ColumnsInit(int count) 
        {
            MainGrid.Columns.Clear();
            for (int i = 0; i < count; i++) 
            {
                MainGrid.Columns.Add(new DataGridViewColumn()
                {
                    Name = (i+1).ToString(),
                    CellTemplate = new DataGridViewTextBoxCell(),
                    DefaultCellStyle = new DataGridViewCellStyle() 
                    {
                        BackColor = Color.White,
                        SelectionBackColor = Color.White,
                    },
                    HeaderText = (i+1).ToString(),
                    AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader
                }
                );            
            }
        }

        private void RowsInit(int count) 
        {
            MainGrid.Rows.Clear();
            for (int i = 0; i < count; i++) 
            {
                MainGrid.Rows.Add(new DataGridViewRow()
                {
                   Height = 15
                });
            }
        }

        private void CellInit(int[,] matrix, int row, int column) 
        {
            var gridRow = MainGrid.Rows[row];
            int jobId = matrix[row, column];

            Color color;
            if (jobId == 0) color = Color.White;
            else if (Colors.Count >= jobId) color = Colors[jobId - 1];
            else color = Color.Red;
            gridRow.Cells[column].Style.BackColor = color;
            gridRow.Cells[column].Style.SelectionBackColor = color;

            if (jobId == 0) return;
            if (column == 0) gridRow.Cells[column].Value = jobId;
            else if (matrix[row, column - 1] != jobId)
                gridRow.Cells[column].Value = jobId;
        }

        private void ColorSettingsButton_Click(object sender, EventArgs e)
        {
            selectColors = new ColorSelectMenu(Colors);
            selectColors.Location = Cursor.Position;
            if (selectColors.ShowDialog() != DialogResult.OK) return;
            List<Color> colors = selectColors.GetColors();
            for (int i = 0; i < colors.Count; i++) Colors[i] = colors[i];
            TableInit(MainGrid.Tag as int[,]);
        }
    }
}
