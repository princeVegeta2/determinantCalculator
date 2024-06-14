namespace Laplace
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dimensionsLabel = new Label();
            textBoxRows = new TextBox();
            textBoxColumns = new TextBox();
            xLabel = new Label();
            generateButton = new Button();
            dataGridView = new DataGridView();
            calculateButton = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            SuspendLayout();
            // 
            // dimensionsLabel
            // 
            dimensionsLabel.AutoSize = true;
            dimensionsLabel.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            dimensionsLabel.Location = new Point(12, 36);
            dimensionsLabel.Name = "dimensionsLabel";
            dimensionsLabel.Size = new Size(212, 31);
            dimensionsLabel.TabIndex = 0;
            dimensionsLabel.Text = "Matrix dimensions:";
            // 
            // textBoxRows
            // 
            textBoxRows.Location = new Point(230, 42);
            textBoxRows.Name = "textBoxRows";
            textBoxRows.Size = new Size(25, 27);
            textBoxRows.TabIndex = 1;
            // 
            // textBoxColumns
            // 
            textBoxColumns.Location = new Point(283, 42);
            textBoxColumns.Name = "textBoxColumns";
            textBoxColumns.Size = new Size(25, 27);
            textBoxColumns.TabIndex = 2;
            // 
            // xLabel
            // 
            xLabel.AutoSize = true;
            xLabel.Location = new Point(261, 47);
            xLabel.Name = "xLabel";
            xLabel.Size = new Size(16, 20);
            xLabel.TabIndex = 3;
            xLabel.Text = "x";
            // 
            // generateButton
            // 
            generateButton.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            generateButton.Location = new Point(356, 36);
            generateButton.Name = "generateButton";
            generateButton.Size = new Size(127, 39);
            generateButton.TabIndex = 4;
            generateButton.Text = "Generate";
            generateButton.UseVisualStyleBackColor = true;
            generateButton.Click += generateButton_Click;
            // 
            // dataGridView
            // 
            dataGridView.AllowUserToAddRows = false;
            dataGridView.AllowUserToDeleteRows = false;
            dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView.Location = new Point(12, 138);
            dataGridView.Name = "dataGridView";
            dataGridView.RowHeadersWidth = 51;
            dataGridView.RowTemplate.Height = 29;
            dataGridView.Size = new Size(776, 300);
            dataGridView.TabIndex = 5;
            // 
            // calculateButton
            // 
            calculateButton.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            calculateButton.Location = new Point(12, 467);
            calculateButton.Name = "calculateButton";
            calculateButton.Size = new Size(776, 49);
            calculateButton.TabIndex = 6;
            calculateButton.Text = "Calculate";
            calculateButton.UseVisualStyleBackColor = true;
            calculateButton.Click += calculateButton_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 539);
            Controls.Add(calculateButton);
            Controls.Add(dataGridView);
            Controls.Add(generateButton);
            Controls.Add(xLabel);
            Controls.Add(textBoxColumns);
            Controls.Add(textBoxRows);
            Controls.Add(dimensionsLabel);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label dimensionsLabel;
        private TextBox textBoxRows;
        private TextBox textBoxColumns;
        private Label xLabel;
        private Button generateButton;
        private DataGridView dataGridView;
        private Button calculateButton;
    }
}