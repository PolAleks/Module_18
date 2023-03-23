using Builder.Builder;

namespace Builder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Conveyor conveyor = new CarConveyor();

            CarPlant factory = new CarPlant();
            factory.Construct(conveyor);
            Product product = conveyor.Product;
            product.Show();

            Console.WriteLine(new string('-', 50));

            conveyor = new MotoConveyor();
            factory.Construct(conveyor);
            product = conveyor.Product;
            product.Show();

            Console.WriteLine(new string('-',50));

            conveyor = new ScooterConveyor();
            factory.Construct(conveyor);
            product = conveyor.Product;
            product.Show();
        }
    }
}