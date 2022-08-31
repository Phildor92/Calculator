using System.Globalization;

namespace Calculator.Backend
{
    public class CalcDevice
    {
        public List<double> BufferedNumbers { get; private set; }
        public string CurrentResult { get; private set; } = "";
        private Operation currentOperation = Operation.None;
        private int currentNumber =1;
        private bool decimalAdded;

        public CalcDevice()
        {
            BufferedNumbers = new List<double>();
        }

        public void GetResult()
        {
            if (BufferedNumbers.Count < 2 || currentOperation == Operation.None || decimalAdded) return;
            var result = currentOperation switch
            {
                Operation.Add => Arithmetic.Add(BufferedNumbers[0], BufferedNumbers[1]),
                Operation.Subtract => Arithmetic.Subtract(BufferedNumbers[0], BufferedNumbers[1]),
                Operation.Multiply => Arithmetic.Multiply(BufferedNumbers[0], BufferedNumbers[1]),
                Operation.Divide => Arithmetic.Divide(BufferedNumbers[0], BufferedNumbers[1]),
                _ => throw new ArgumentOutOfRangeException()
            };
            ClearBuffer();
            BufferedNumbers.Add(result);
            CurrentResult = result.ToString(CultureInfo.InvariantCulture);
            currentOperation = Operation.None;
            currentNumber = 1;
        }

        public void Add()
        {
            if(!CanAddOperation()) 
                return;
            currentOperation = Operation.Add;
            CurrentResult += "+";
            currentNumber++;
        }

        private bool CanAddOperation()
        {
            return BufferedNumbers.Count == 1 && currentOperation == Operation.None && !decimalAdded;
        }

        public void Subtract()
        {
            if (!CanAddOperation())
                return;
            currentOperation = Operation.Subtract;
            CurrentResult += "-";
            currentNumber++;
        }

        public void Multiply()
        {
            if (!CanAddOperation())
                return;
            currentOperation = Operation.Multiply;
            CurrentResult += "*";
            currentNumber++;
        }

        public void Divide()
        {
            if (!CanAddOperation())
                return;
            currentOperation = Operation.Divide;
            CurrentResult += "/";
            currentNumber++;
        }

        public void AddDigitToBuffer(double digit)
        {
            //if (!CanAddToBuffer()) return;
            if (BufferedNumbers.Count < currentNumber)
            {
                BufferedNumbers.Add(digit);
            }
            else if (decimalAdded)
            {
                BufferedNumbers[currentNumber - 1] = double.Parse(BufferedNumbers[currentNumber - 1] + "." + digit);
                decimalAdded = false;
            }
            else
            {
                BufferedNumbers[currentNumber - 1] = double.Parse(BufferedNumbers[currentNumber - 1] + "" + digit);
            }



            CurrentResult += digit;
        }

        public void ClearBuffer()
        {
            BufferedNumbers.Clear();
            CurrentResult = "";
        }

        private bool CanAddToBuffer()
        {
            return BufferedNumbers.Count < 1 || (BufferedNumbers.Count == 1 && currentOperation != Operation.None);
        }

        public void AddDecimalToBuffer()
        {
            if (BufferedNumbers.Count < currentNumber || BufferedNumbers[currentNumber-1].ToString(CultureInfo.InvariantCulture).Contains(".")) return;

            decimalAdded = true;
            CurrentResult += ".";
        }
    }

    public enum Operation
    {
        None,
        Add,
        Subtract,
        Multiply,
        Divide,
    }
}
