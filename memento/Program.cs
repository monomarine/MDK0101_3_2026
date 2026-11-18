namespace memento
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Character ch1 = new Character(100, 100, (0,0));

            ch1.MoveTo((10, 50));
            ch1.takeDamage(70);
            ch1.UseMana(50);

            ch1.Save();
            Console.WriteLine(ch1);

            ch1.MoveTo((30, 30));
            ch1.takeDamage(50);
            ch1.UseMana(80);
            Console.WriteLine(ch1);

            ch1.Load();
            Console.WriteLine(ch1);

        }
    }
}
