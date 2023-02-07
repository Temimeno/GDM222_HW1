class Program {

    private static double Cal(double x) {

        if ((x > -1) && (x <= 0)) {
            return Math.Sqrt(1 - (x*x));
        }
        else if ((x > 0) && (x <= 1)) {
            return -Math.Sqrt(1 - (x*x));
        }
        else if (x <= -1) {
            return Cal(x + 2);
        }
        else {
            return Cal(x - 2);
        }
    }

    public static void Main(String[] args) {

        Console.Clear();

        Console.Write("Input value of x: ");
        double x = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("f({0}) = {1}", x, Cal(x));
    }
}
