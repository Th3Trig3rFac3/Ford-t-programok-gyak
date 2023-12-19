namespace AXAF1W_Beadando
{
    partial class mainForm
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
            tableInputButton = new Button();
            inputStripLabel = new Label();
            inputStripTB = new TextBox();
            inputStripErr = new Label();
            printButton = new Button();
            tableInputErr = new Label();
            stackInputLabel = new Label();
            stackInputTB = new TextBox();
            SuspendLayout();
            // 
            // tableInputButton
            // 
            tableInputButton.Location = new Point(12, 48);
            tableInputButton.Name = "tableInputButton";
            tableInputButton.Size = new Size(75, 23);
            tableInputButton.TabIndex = 0;
            tableInputButton.Text = "Table Input";
            tableInputButton.UseVisualStyleBackColor = true;
            tableInputButton.Click += button1_Click;
            // 
            // inputStripLabel
            // 
            inputStripLabel.AutoSize = true;
            inputStripLabel.Location = new Point(12, 9);
            inputStripLabel.Name = "inputStripLabel";
            inputStripLabel.Size = new Size(62, 15);
            inputStripLabel.TabIndex = 1;
            inputStripLabel.Text = "Input Strip";
            // 
            // inputStripTB
            // 
            inputStripTB.Location = new Point(80, 6);
            inputStripTB.Name = "inputStripTB";
            inputStripTB.Size = new Size(216, 23);
            inputStripTB.TabIndex = 2;
            inputStripTB.TextChanged += inputStripTB_TextChanged;
            // 
            // inputStripErr
            // 
            inputStripErr.AutoSize = true;
            inputStripErr.Location = new Point(315, 11);
            inputStripErr.Name = "inputStripErr";
            inputStripErr.Size = new Size(0, 15);
            inputStripErr.TabIndex = 3;
            inputStripErr.Click += button1_Click;
            // 
            // printButton
            // 
            printButton.Location = new Point(12, 178);
            printButton.Name = "printButton";
            printButton.Size = new Size(75, 23);
            printButton.TabIndex = 4;
            printButton.Text = "Print";
            printButton.UseVisualStyleBackColor = true;
            printButton.Click += printButton_Click;
            // 
            // tableInputErr
            // 
            tableInputErr.AutoSize = true;
            tableInputErr.Location = new Point(106, 52);
            tableInputErr.Name = "tableInputErr";
            tableInputErr.Size = new Size(0, 15);
            tableInputErr.TabIndex = 5;
            // 
            // stackInputLabel
            // 
            stackInputLabel.AutoSize = true;
            stackInputLabel.Location = new Point(12, 87);
            stackInputLabel.Name = "stackInputLabel";
            stackInputLabel.Size = new Size(82, 15);
            stackInputLabel.TabIndex = 6;
            stackInputLabel.Text = "Stack first unit";
            // 
            // stackInputTB
            // 
            stackInputTB.Location = new Point(106, 87);
            stackInputTB.Name = "stackInputTB";
            stackInputTB.Size = new Size(216, 23);
            stackInputTB.TabIndex = 7;
            stackInputTB.TextChanged += stackInputTB_TextChanged;
            // 
            // mainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(489, 213);
            Controls.Add(stackInputTB);
            Controls.Add(stackInputLabel);
            Controls.Add(tableInputErr);
            Controls.Add(printButton);
            Controls.Add(inputStripErr);
            Controls.Add(inputStripTB);
            Controls.Add(inputStripLabel);
            Controls.Add(tableInputButton);
            Name = "mainForm";
            Text = "mainForm";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button tableInputButton;
        private Label inputStripLabel;
        private TextBox inputStripTB;
        private Label inputStripErr;
        private Button printButton;
        private Label tableInputErr;
        private Label stackInputLabel;
        private TextBox stackInputTB;
    }
}
