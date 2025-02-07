namespace EncapsulateWhatVarient
{
    public class Program
    {
        static void Main(string[] args)
        {

        }
    }

    public class Pizza
    {

        public virtual string Title => $"{nameof(Pizza)}";
        public virtual decimal Price => 10.0m;

        private static Pizza Create(string type)
        {
            Pizza pizza;
            if (type.Equals("CheesePizza"))
                pizza = new CheesePizza();
            else if (type.Equals("cheese"))
                pizza = new ChickenPizza();
            else
                pizza = new VegetrainPizza();
            return pizza;
        }

        private static void Prepare()
        {
            Console.WriteLine("Preparing...");
            Thread.Sleep(1000);
            Console.WriteLine("Completed");
        }
        private static void Cook()
        {
            Console.WriteLine("Cooking...");
            Thread.Sleep(1000);
            Console.WriteLine("Completed");
        }
        private static void Cut()
        {
            Console.WriteLine("Cutting and boxing...");
            Thread.Sleep(1000);
            Console.WriteLine("Completed");
        }
        public override string ToString()
        {
            return $"{Title} - {Price}";
        }
    }

    class CheesePizza : Pizza
    {
        public override string Title => $"{nameof(CheesePizza)}";
        public override decimal Price => base.Price + 7.0m;
    }
    class ChickenPizza : Pizza
    {
        public override string Title => $"{nameof(CheesePizza)}";
        public override decimal Price => base.Price + 5.0m;
    }
    class VegetrainPizza : Pizza
    {
        public override string Title => $"{nameof(VegetrainPizza)}";
        public override decimal Price => base.Price + 4.0m;
    }
}
