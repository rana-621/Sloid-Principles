namespace SOLID.OCP.After
{
    class WHQuestion : Question
    {
        public override void Print()
        {
            Console.WriteLine($"{Title}[ {Marks}]");

            Console.WriteLine("___________________________");
            Console.WriteLine("___________________________");
            Console.WriteLine("___________________________");
        }
    }
}
