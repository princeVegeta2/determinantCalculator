namespace Laplace
{
    public partial class Form1 : Form
    {
        // MatrixClass class
        private MatrixClass matrix;

        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Generates the grid rows and columns using the user-specified dimensions
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void generateButton_Click(object sender, EventArgs e)
        {
            // Clearing previous data
            dataGridView.Columns.Clear();
            dataGridView.Rows.Clear();

            // Reading the number of rows and columns from the text boxes
            if (int.TryParse(textBoxRows.Text, out int rows) && int.TryParse(textBoxColumns.Text, out int columns))
            {
                // Check if the matrix is square
                if (rows != columns)
                {
                    MessageBox.Show("Please enter a square matrix (same number of rows and columns).");
                    return;
                }

                // Creating the columns
                for (int i = 0; i < columns; i++)
                {
                    dataGridView.Columns.Add($"Column{i + 1}", $"Column {i + 1}");
                }

                // Creating the rows
                for (int i = 0; i < rows; i++)
                {
                    dataGridView.Rows.Add();
                }

                // Adjusting the size of the DataGridView
                dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dataGridView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;

                // Disable adding new rows
                dataGridView.AllowUserToAddRows = false;

                // Disable resizing
                dataGridView.AllowUserToResizeColumns = false;
                dataGridView.AllowUserToResizeRows = false;

                // Initializing the matrix object
                matrix = new MatrixClass(rows, columns);
            }
            else
            {
                MessageBox.Show("Please enter a valid matrix dimension value");
            }
        }

        /// <summary>
        /// Populates the matrix object with values from the DataGridView, and calculates the determinant
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void calculateButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (matrix == null)
                {
                    MessageBox.Show("Please generate the matrix first");
                    return;
                }

                for (int i = 0; i < dataGridView.RowCount; i++)
                {
                    for (int j = 0; j < dataGridView.ColumnCount; j++)
                    {
                        // Checking if the cell's value is null
                        var cellValue = dataGridView[j, i].Value;
                        if (cellValue != null)
                        {
                            if (double.TryParse(cellValue.ToString(), out double value))
                            {
                                matrix.SetElement(i, j, value);
                            }
                            else
                            {
                                MessageBox.Show($"Invalid value at row {i + 1}, column {j + 1}");
                                return;
                            }
                        }
                        else
                        {
                            MessageBox.Show($"Empty cell at row {i + 1}, column {j + 1}. Please enter a value.");
                            return;
                        }
                    }
                }

                // Printing the matrix for debug
                matrix.PrintMatrix();

                // Calculating the determinant
                double determinant = matrix.CalculateDeterminant();
                MessageBox.Show($"Determinant: {determinant}");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }
        }
    }
}
