using Calculator.Backend;

namespace Calculator.FrontWF
{
    public partial class Form1 : Form
    {
        private CalcDevice calculator;

        public Form1()
        {
            InitializeComponent();
            calculator = new Backend.CalcDevice();
        }

        private void digitButton_Click(object sender, EventArgs e)
        {
            var buttonText = ((Button) sender).Text;
            var digit = double.Parse(buttonText);
            calculator.AddDigitToBuffer(digit);
            RefreshTextFields();
        }

        private void RefreshTextFields()
        {
            resultTextBox.Text = calculator.CurrentResult;
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            calculator.Add();
            RefreshTextFields();
        }

        private void equalsButton_Click(object sender, EventArgs e)
        {
            try
            {
                calculator.GetResult();
                RefreshTextFields();
            }
            catch (Exception exception)
            {
                resultTextBox.Text = exception.Message;
                //Clear buffer and refresh after n seconds?
            }
        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            calculator.ClearBuffer();
            RefreshTextFields();
        }

        private void subtractButton_Click(object sender, EventArgs e)
        {
            calculator.Subtract();
            RefreshTextFields();
        }

        private void multiplyButton_Click(object sender, EventArgs e)
        {
            calculator.Multiply();
            RefreshTextFields();
        }

        private void divideButton_Click(object sender, EventArgs e)
        {
            calculator.Divide();
            RefreshTextFields();
        }

        private void dotButton_Click(object sender, EventArgs e)
        {
            calculator.AddDecimalToBuffer();
            RefreshTextFields();
        }
    }
}