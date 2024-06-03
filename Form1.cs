namespace CSC240_08_03_ManyButtons_jmr
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void RedButton_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Red;

        }

        private void WhiteButton_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.White;
        }

        private void BlueButton_Click(object sender, EventArgs e)
        {
            this.BackColor= Color.Blue;
        }
    }
}
