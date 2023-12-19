namespace AXAF1W_Beadando
{
    partial class tableInputForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tableDataGrid = new DataGridView();
            saveButton = new Button();
            clsoeButton = new Button();
            btnAddColumn = new Button();
            btnExport = new Button();
            btnLoadCsv = new Button();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewTextBoxColumn();
            Column7 = new DataGridViewTextBoxColumn();
            Column8 = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)tableDataGrid).BeginInit();
            SuspendLayout();
            // 
            // tableDataGrid
            // 
            tableDataGrid.AllowUserToOrderColumns = true;
            tableDataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tableDataGrid.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, Column5, Column6, Column7, Column8 });
            tableDataGrid.Location = new Point(106, 2);
            tableDataGrid.Name = "tableDataGrid";
            tableDataGrid.Size = new Size(944, 446);
            tableDataGrid.TabIndex = 0;
            tableDataGrid.CellContentClick += tableDataGrid_CellContentClick;
            tableDataGrid.CellStateChanged += tableDataGrid_CellStateChanged;
            // 
            // saveButton
            // 
            saveButton.Location = new Point(12, 56);
            saveButton.Name = "saveButton";
            saveButton.Size = new Size(75, 23);
            saveButton.TabIndex = 1;
            saveButton.Text = "Save";
            saveButton.UseVisualStyleBackColor = true;
            saveButton.Click += saveButton_Click;
            // 
            // clsoeButton
            // 
            clsoeButton.Location = new Point(12, 12);
            clsoeButton.Name = "clsoeButton";
            clsoeButton.Size = new Size(75, 23);
            clsoeButton.TabIndex = 2;
            clsoeButton.Text = "Close";
            clsoeButton.UseVisualStyleBackColor = true;
            clsoeButton.Click += clsoeButton_Click;
            // 
            // btnAddColumn
            // 
            btnAddColumn.Location = new Point(12, 146);
            btnAddColumn.Name = "btnAddColumn";
            btnAddColumn.Size = new Size(75, 23);
            btnAddColumn.TabIndex = 3;
            btnAddColumn.Text = "Add";
            btnAddColumn.UseVisualStyleBackColor = true;
            btnAddColumn.Click += btnAddColumn_Click;
            // 
            // btnExport
            // 
            btnExport.Location = new Point(12, 415);
            btnExport.Name = "btnExport";
            btnExport.Size = new Size(75, 23);
            btnExport.TabIndex = 4;
            btnExport.Text = "Export";
            btnExport.UseVisualStyleBackColor = true;
            btnExport.Click += btnExport_Click;
            // 
            // btnLoadCsv
            // 
            btnLoadCsv.Location = new Point(12, 356);
            btnLoadCsv.Name = "btnLoadCsv";
            btnLoadCsv.Size = new Size(75, 23);
            btnLoadCsv.TabIndex = 5;
            btnLoadCsv.Text = "Load";
            btnLoadCsv.UseVisualStyleBackColor = true;
            btnLoadCsv.Click += btnLoadCsv_Click;
            // 
            // Column1
            // 
            Column1.HeaderText = "Rows";
            Column1.Name = "Column1";
            // 
            // Column2
            // 
            Column2.HeaderText = "Column1";
            Column2.Name = "Column2";
            // 
            // Column3
            // 
            Column3.HeaderText = "Column2";
            Column3.Name = "Column3";
            // 
            // Column4
            // 
            Column4.HeaderText = "Column3";
            Column4.Name = "Column4";
            // 
            // Column5
            // 
            Column5.HeaderText = "Column4";
            Column5.Name = "Column5";
            // 
            // Column6
            // 
            Column6.HeaderText = "Column5";
            Column6.Name = "Column6";
            // 
            // Column7
            // 
            Column7.HeaderText = "Column6";
            Column7.Name = "Column7";
            // 
            // Column8
            // 
            Column8.HeaderText = "Column7";
            Column8.Name = "Column8";
            // 
            // tableInputForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1053, 450);
            Controls.Add(btnLoadCsv);
            Controls.Add(btnExport);
            Controls.Add(btnAddColumn);
            Controls.Add(clsoeButton);
            Controls.Add(saveButton);
            Controls.Add(tableDataGrid);
            Name = "tableInputForm";
            Text = "tableInputForm";
            SizeChanged += tableInputForm_SizeChanged;
            ((System.ComponentModel.ISupportInitialize)tableDataGrid).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView tableDataGrid;
        private Button saveButton;
        private Button clsoeButton;
        private Button btnAddColumn;
        private Button btnExport;
        private Button btnLoadCsv;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column6;
        private DataGridViewTextBoxColumn Column7;
        private DataGridViewTextBoxColumn Column8;
    }
}