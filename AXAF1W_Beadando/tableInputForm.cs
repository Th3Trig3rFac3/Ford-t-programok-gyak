using System.Text;

namespace AXAF1W_Beadando
{
    public partial class tableInputForm : Form
    {
        public static string[][]? tableData;
        public static int rowCount, columnCount;
        private bool hasSaved = false;
        public tableInputForm()
        {
            InitializeComponent();


            tableDataGrid.AllowUserToAddRows = true;
            tableDataGrid.AllowUserToOrderColumns = true;
            tableDataGrid.Width = this.Width - 100;
            tableDataGrid.Height = this.Height;
        }

        internal void tableDataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        internal void tableDataGrid_CellStateChanged(object sender, DataGridViewCellStateChangedEventArgs e)
        {

        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            tableDataGrid.EndEdit(DataGridViewDataErrorContexts.Commit);

            if (tableData == null)
            {
                tableData = new string[tableDataGrid.Rows.Count][];
                for (int i = 0; i < tableDataGrid.Rows.Count; i++)
                    tableData[i] = new string[tableDataGrid.ColumnCount];
            }

            for (int i = 0; i < tableDataGrid.Rows.Count; i++)
            {
                for (int j = 0; j < tableDataGrid.Columns.Count; j++)
                    tableData[i][j] = tableDataGrid.Rows[i].Cells[j].Value?.ToString() ?? "0";
            }

            rowCount = tableDataGrid.Rows.Count;
            columnCount = tableDataGrid.Columns.Count;

            hasSaved = true;
        }

        private void clsoeButton_Click(object sender, EventArgs e)
        {
            if (hasSaved) Close();
        }

        private void tableInputForm_SizeChanged(object sender, EventArgs e)
        {
            tableDataGrid.Width = this.Width - 100;
            tableDataGrid.Height = this.Height;
        }

        private void btnAddColumn_Click(object sender, EventArgs e)
        {
            string columnName = PromptForColumnName();

            if (columnName == null)
                return;

            tableDataGrid.Columns.Add(columnName, columnName);
            Width += 100;
            Height += 100;
        }
        private string PromptForColumnName()
        {
            return Microsoft.VisualBasic.Interaction.InputBox("Enter Column Name:", "New Column", "Column");
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            if (hasSaved)
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "CSV files (*.csv)|*.csv";
                saveFileDialog.Title = "Export to CSV";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    ExportToCsv(tableDataGrid, saveFileDialog.FileName);
                    MessageBox.Show("Export complete!");
                }
            }
            else
            {
                MessageBox.Show("Save your work first!");
            }
        }
        private void ExportToCsv(DataGridView dataGridView, string filePath)
        {
            string csvData = ConvertDataGridViewToCsv(dataGridView);
            File.WriteAllText(filePath, csvData);
        }

        private string ConvertDataGridViewToCsv(DataGridView dataGridView)
        {
            StringBuilder csvData = new StringBuilder();

            foreach (DataGridViewColumn column in dataGridView.Columns)
            {
                csvData.Append(column.HeaderText + ";");
            }
            csvData.AppendLine();

            foreach (DataGridViewRow row in dataGridView.Rows)
            {
                foreach (DataGridViewCell cell in row.Cells)
                {
                    csvData.Append(cell.Value + ";");
                }
                csvData.AppendLine();
            }

            return csvData.ToString();
        }

        private void btnLoadCsv_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "CSV files (*.csv)|*.csv";
            openFileDialog.Title = "Import CSV";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                LoadCsvIntoDataGridView(openFileDialog.FileName);
            }
        }
        private void LoadCsvIntoDataGridView(string filePath)
        {
            try
            {
                string[] lines = File.ReadAllLines(filePath);
                if (lines.Length > 0)
                {
                    // Assuming the CSV file has header row
                    string[] headers = lines[0].Split(';');

                    // Clear existing columns and data
                    tableDataGrid.Columns.Clear();
                    tableDataGrid.Rows.Clear();

                    // Add columns to DataGridView
                    foreach (string header in headers)
                    {
                        tableDataGrid.Columns.Add(header, header);
                    }

                    // Add data to DataGridView
                    for (int i = 1; i < lines.Length; i++)
                    {
                        string[] data = lines[i].Split(';');
                        tableDataGrid.Rows.Add(data);
                    }

                    MessageBox.Show("CSV file loaded successfully!");
                }
                else
                {
                    MessageBox.Show("CSV file is empty.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading CSV file: {ex.Message}");
            }
        }
    }
}
