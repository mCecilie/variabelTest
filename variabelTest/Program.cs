namespace variabelTest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("===MIN LOMMEREGNER===");

            //Først bruger jeg Random klassen
            Random terning = new Random();

            //Herefter definerer jeg mine variable
            int kast1 = terning.Next(1, 7); //Terningen kan vise mellem 1-6
            int kast2 = terning.Next(1, 7); //Terningen kan vise mellem 1-6

            int sum = kast1 + kast2;
        }
    }
}
