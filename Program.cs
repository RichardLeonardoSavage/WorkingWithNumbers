namespace workingwithnumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(5 + 8);
            Console.WriteLine(5 - 3);
            Console.WriteLine(5 * 5);
            Console.WriteLine(100 / 10);
            Console.WriteLine( 5 + 4 * 3);
            Console.WriteLine((5 + 4) * 3);

            int num = 6;
            num++;
            Console.WriteLine(num);
            num--;
            Console.WriteLine(num);

            //math methods

            Console.WriteLine(Math.Abs(-40));
            Console.WriteLine(Math.Pow(5.2, 8));
            Console.WriteLine(Math.Sqrt(36));
            Console.WriteLine(Math.Max(50, 100));
            Console.WriteLine(Math.Min(50, 100));   
            Console.WriteLine(Math.Round(5.6));

            Console.ReadLine();
        }
    }
}
