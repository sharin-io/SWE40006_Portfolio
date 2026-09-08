using System;
using System.Windows.Forms;
using ExpenseTrackerLogic; // Importing the separate Class Library DLL

namespace ExampleDesktop
{
    public partial class Form1 : Form
    {
        // Instantiating the shared calculator logic from the external DLL
        private readonly ExpenseCalculator _calculator = new ExpenseCalculator();

        public Form1()
        {
            InitializeComponent();

            btnAdd.Click += btnAdd_Click;
            btnClear.Click += btnClear_Click;
        }

        private void Form1_Load(object? sender, EventArgs e)
        {
            cmbCategory.Items.AddRange(new object[] {
                "Food & Dining",
                "Transportation",
                "Groceries",
                "Utilities & Bills",
                "Entertainment",
                "Other"
            });

            if (cmbCategory.Items.Count > 0)
            {
                cmbCategory.SelectedIndex = 0;
            }
        }

        private void btnAdd_Click(object? sender, EventArgs e)
        {
            string description = txtDesc.Text.Trim();
            string amountText = txtAmt.Text.Trim();
            string category = cmbCategory.SelectedItem?.ToString() ?? "Other";

            if (string.IsNullOrWhiteSpace(description))
            {
                MessageBox.Show("Please enter a description for the expense.",
                                "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtDesc.Focus();
                return;
            }

            if (!decimal.TryParse(amountText, out decimal amount) || amount <= 0)
            {
                MessageBox.Show("Please enter a valid numeric amount greater than zero.",
                                "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtAmt.Focus();
                return;
            }

            // Calculation and formatting are handled by the external ExpenseTrackerLogic.dll
            decimal updatedTotal = _calculator.AddExpense(amount);
            string entry = _calculator.FormatEntry(category, description, amount);

            lstExpense.Items.Add(entry);
            lblTotal.Text = $"Total Expenses: RM {updatedTotal:F2}";

            txtDesc.Clear();
            txtAmt.Clear();
            txtDesc.Focus();
        }

        private void btnClear_Click(object? sender, EventArgs e)
        {
            _calculator.Reset();
            lstExpense.Items.Clear();
            lblTotal.Text = "Total Expenses: RM 0.00";
            txtDesc.Clear();
            txtAmt.Clear();
            txtDesc.Focus();
        }

        private void label1_Click(object? sender, EventArgs e) { }
        private void lblAmt_Click(object? sender, EventArgs e) { }
        private void TextBox1_TextChanged(object? sender, EventArgs e) { }
    }
}