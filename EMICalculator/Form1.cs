namespace EMICalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
              double emi;
                double p, r;
                int n;
                double totalPayment;
                //get the input
                // (P x rx (1+r)n ) / ((1+r)n - 1)
                p = double.Parse(amountTextBox.Text);
                 r = double.Parse(rateTextBox.Text)/ 1200;
            n = decimal.ToInt32(termNumericUpDown.Value);
                // Processing
                emi = (p * r * (Math.Pow((1 + r), n))) / (Math.Pow((1 + r), n) - 1);
               
                totalPayment = emi * n;
            // output result to label
            outputLabel.Text = "Payment/month is:" + emi.ToString() +
                "\r\nTotal Payment is:" + totalPayment.ToString();
            }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Click(object sender, EventArgs e)
        {

        }
    }
}