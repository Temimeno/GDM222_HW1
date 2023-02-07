class Program {

    private static double Cal(double x) {

        if ( x*x <= 4) {
            return 2;
        }
        else {
            return 1 + Cal(x - ((4 * Math.Abs(x)) / x));
        }
    }

    public static void Main(String[] args) {

        Console.Clear();

        Console.Write("Input value of x: ");
        double x = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("f({0}) = {1}", x, Cal(x));
    }
}
