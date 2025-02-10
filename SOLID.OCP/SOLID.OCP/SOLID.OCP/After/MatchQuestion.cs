namespace SOLID.OCP.After
{
    class MatchQuestion : Question
    {
        public Dictionary<string, string> Matches { get; set; } = new Dictionary<string, string>();
        public override void Print()
        {
            Console.WriteLine($"{Title} [{Marks}]");

            foreach (var item in Matches)
            {
                Console.WriteLine($"{item.Key}                    {item.Value}");
            }
        }
    }
}
