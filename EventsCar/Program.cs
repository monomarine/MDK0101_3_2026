namespace EventsCar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car c1 = new Car("pervaya");
            Car c2 = new Car("vtoraya");
            Car c3 = new Car("tretya");

            Camera camera = new Camera(40);

            camera.SuscribeCar(c1);
            camera.SuscribeCar(c2);
            camera.SuscribeCar(c3);

            c1.Drive();

            Console.WriteLine();
            c2.Drive();

            Console.WriteLine();
            c3.Drive();
      
        }
    }
}
