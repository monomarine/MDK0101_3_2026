namespace factoryMethod
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Cafe cafe = new Cafe(new JapanFactory());

            cafe.PrintCheck();
        }
    }
}
