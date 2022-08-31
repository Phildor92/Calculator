namespace Calculator.Backend
{
    public static class Arithmetic
    {
        public static double Add(double a, double b)
        {
            return a + b;
        }

        public static double Subtract(double a, double b)
        {
            return a - b;
        }

        public static double Multiply(double a, double b)
        {
            return a * b;
        }

        public static double Divide(double a, double b)
        {
            if (b == 0.0d)
            {
                throw new ArgumentException("Divide by zero error");
            }
            return a / b;
        }
    }
}