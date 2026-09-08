namespace ExampleDesktop
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
            lblTitle = new Label();
            txtDesc = new TextBox();
            lblDesc = new Label();
            lblAmt = new Label();
            lblCat = new Label();
            txtAmt = new TextBox();
            cmbCategory = new ComboBox();
            btnAdd = new Button();
            btnClear = new Button();
            lstExpense = new ListBox();
            lblTotal = new Label();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AccessibleName = "Expense Tracker";
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblTitle.Location = new Point(31, 42);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(398, 45);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Personal Expense Tracker";
            lblTitle.Click += label1_Click;
            // 
            // txtDesc
            // 
            txtDesc.Location = new Point(187, 107);
            txtDesc.Name = "txtDesc";
            txtDesc.Size = new Size(200, 39);
            txtDesc.TabIndex = 1;
            txtDesc.TextChanged += TextBox1_TextChanged;
            // 
            // lblDesc
            // 
            lblDesc.AutoSize = true;
            lblDesc.Location = new Point(29, 107);
            lblDesc.Name = "lblDesc";
            lblDesc.Size = new Size(135, 32);
            lblDesc.TabIndex = 2;
            lblDesc.Text = "Description";
            // 
            // lblAmt
            // 
            lblAmt.AutoSize = true;
            lblAmt.Location = new Point(31, 174);
            lblAmt.Name = "lblAmt";
            lblAmt.Size = new Size(100, 32);
            lblAmt.TabIndex = 4;
            lblAmt.Text = "Amount";
            lblAmt.Click += lblAmt_Click;
            // 
            // lblCat
            // 
            lblCat.AutoSize = true;
            lblCat.Location = new Point(31, 237);
            lblCat.Name = "lblCat";
            lblCat.Size = new Size(110, 32);
            lblCat.TabIndex = 5;
            lblCat.Text = "Category";
            // 
            // txtAmt
            // 
            txtAmt.Location = new Point(187, 171);
            txtAmt.Name = "txtAmt";
            txtAmt.Size = new Size(200, 39);
            txtAmt.TabIndex = 7;
            // 
            // cmbCategory
            // 
            cmbCategory.FormattingEnabled = true;
            cmbCategory.Location = new Point(187, 237);
            cmbCategory.Name = "cmbCategory";
            cmbCategory.Size = new Size(242, 40);
            cmbCategory.TabIndex = 8;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(36, 314);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(150, 46);
            btnAdd.TabIndex = 9;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(207, 314);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(150, 46);
            btnClear.TabIndex = 10;
            btnClear.Text = "Reset";
            btnClear.UseVisualStyleBackColor = true;
            // 
            // lstExpense
            // 
            lstExpense.FormattingEnabled = true;
            lstExpense.Location = new Point(36, 395);
            lstExpense.Name = "lstExpense";
            lstExpense.Size = new Size(507, 164);
            lstExpense.TabIndex = 11;
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblTotal.Location = new Point(36, 589);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(255, 32);
            lblTotal.TabIndex = 12;
            lblTotal.Text = "Total Expenses: RM 0";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(813, 765);
            Controls.Add(lblTotal);
            Controls.Add(lstExpense);
            Controls.Add(btnClear);
            Controls.Add(btnAdd);
            Controls.Add(cmbCategory);
            Controls.Add(txtAmt);
            Controls.Add(lblCat);
            Controls.Add(lblAmt);
            Controls.Add(lblDesc);
            Controls.Add(txtDesc);
            Controls.Add(lblTitle);
            Name = "Form1";
            Text = "Expense Tracker App - Shin Thant Thi Ri";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private TextBox txtDesc;
        private Label lblDesc;
        private Label lblAmt;
        private Label lblCat;
        private TextBox txtAmt;
        private ComboBox cmbCategory;
        private Button btnAdd;
        private Button btnClear;
        private ListBox lstExpense;
        private Label lblTotal;
    }
}
