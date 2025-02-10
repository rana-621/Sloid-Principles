namespace SOLID.OCP.After
{
    internal class TrueFalseQuestion : Question
    {
        public override void Print()
        {
            Console.WriteLine($"{Title}  [{Marks}]");
            Console.WriteLine("  1. T");
            Console.WriteLine("  1. F");
        }
    }
}
