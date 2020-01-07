namespace operations
{
    public static class Division
    {
        public static int Quotient(int a, int b)
        {
            return a / b;
        }

        public static double Quotient(double a, double b)
        {
            return a / b;
        }

        public static double Quotient(double[] arrayA)
        {
            double c = 0.0;

            foreach (double a in arrayA)
            {
                c = Quotient(a, c);
            }

            return c;
        }

        public static int Quotient(int[] arrayA)
        {
            int c = 0;

            foreach (int a in arrayA)
            {
                c = Quotient(a, c);
            }

            return c;
        }
    }
}