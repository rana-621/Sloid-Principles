namespace SOLID.OCP.Before
{
    internal class Question
    {
        public string Title { get; set; }
        public int Marks { get; set; }
        public QuestionType QuestionType { get; set; }
        public List<string> Choices { get; set; } = new List<string>();
    }
}
