namespace lab3._2
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
            btnSumDigits = new Button();
            btnCountEven = new Button();
            txtnumber = new TextBox();
            lblResult = new Label();
            SuspendLayout();
            // 
            // btnSumDigits
            // 
            btnSumDigits.Location = new Point(180, 40);
            btnSumDigits.Name = "btnSumDigits";
            btnSumDigits.Size = new Size(134, 29);
            btnSumDigits.TabIndex = 0;
            btnSumDigits.Text = "Sum of Digits";
            btnSumDigits.UseVisualStyleBackColor = true;
            btnSumDigits.Click += btnSumDigits_Click;
            // 
            // btnCountEven
            // 
            btnCountEven.Location = new Point(180, 82);
            btnCountEven.Name = "btnCountEven";
            btnCountEven.Size = new Size(151, 29);
            btnCountEven.TabIndex = 1;
            btnCountEven.Text = "Count Even Digits";
            btnCountEven.UseVisualStyleBackColor = true;
            btnCountEven.Click += btnCountEven_Click;
            // 
            // txtnumber
            // 
            txtnumber.Location = new Point(373, 65);
            txtnumber.Name = "txtnumber";
            txtnumber.Size = new Size(125, 27);
            txtnumber.TabIndex = 3;
            // 
            // lblResult
            // 
            lblResult.AutoSize = true;
            lblResult.Location = new Point(452, 165);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(0, 20);
            lblResult.TabIndex = 4;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblResult);
            Controls.Add(txtnumber);
            Controls.Add(btnCountEven);
            Controls.Add(btnSumDigits);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSumDigits;
        private Button btnCountEven;
        private TextBox txtnumber;
        private Label lblResult;
    }
}
