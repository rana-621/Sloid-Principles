namespace SOLID.OCP.Before
{
    internal class Quiz
    {
        public List<Question> Questions { get; }
        public Quiz(List<Question> questions)
        {
            this.Questions = questions;
        }
        public void Print()
        {
            foreach (var q in Questions)
            {
                Console.WriteLine($"{q.Title} [{q.Marks}]");
                switch (q.QuestionType)
                {
                    case QuestionType.WH:
                        Console.WriteLine("---------------------------------------");
                        Console.WriteLine("---------------------------------------");
                        Console.WriteLine("---------------------------------------");
                        break;
                    case QuestionType.TrueFalse:
                        Console.WriteLine(" 1. T");
                        Console.WriteLine(" 2. F");
                        break;
                    case QuestionType.MCQ:
                        foreach (var choice in q.Choices)
                        {
                            Console.WriteLine($"   {choice}");
                        }
                        break;
                    default: break;
                }
                Console.WriteLine("\n\n");
            }
        }
    }
}
