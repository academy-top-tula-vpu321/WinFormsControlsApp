namespace WinFormsControlsApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            btnCancel.Click += BtnCancel_Click;

            txtCity.AutoCompleteSource = AutoCompleteSource.CustomSource;
            txtCity.AutoCompleteMode = AutoCompleteMode.SuggestAppend;

            txtCity.TextChanged += TxtCity_TextChanged;
            btnOk.Enabled = false;
        }

        private void TxtCity_TextChanged(object? sender, EventArgs e)
        {
            if (txtCity.Text.Trim() == "")
                btnOk.Enabled = false;
            else
                btnOk.Enabled = true;
        }

        private void BtnCancel_Click(object? sender, EventArgs e)
        {
            MessageBox.Show("Pressed button CANCEL");
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"Hello {txtCity.Text}");
        }

        private void btnIgnore_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"Mask text {maskedTextBox1.Text}");
        }
    }
}
