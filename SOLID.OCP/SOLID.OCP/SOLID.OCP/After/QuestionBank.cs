namespace SOLID.OCP.After
{
    internal static class QuestionBank
    {
        public static List<Question> Generate()
        {
            return new List<Question>
            {
                new WHQuestion
                {
                    Title = "What are the four pillars of oop ?",
                    Marks = 8
                },
                new MultipleChoiceQuestion
                {
                    Title = "What of the following are value types ?",
                    Marks = 6,
                    Choices = new List<string>
                    {
                        "A: Integer",
                        "B: Array",
                        "C: Single",
                        "D: String",
                        "E: Long",
                    }
                },
                new TrueFalseQuestion
                {
                    Title = "Earth is Bigger than sun?",
                    Marks = 4
                },
                new MultipleChoiceQuestion
                {
                    Title = "Which of the following is an 8-byte Integer?",
                    Marks = 6,
                    Choices = new List<string>
                    {
                       "A.  Char",
                       "B.  Long",
                       "C.  Short",
                       "D.  Byte",
                       "E.  Integer"
                    }
                },
                new MatchQuestion
                {
                    Title = "Match the following",
                    Marks = 10,
                    Matches = new Dictionary<string, string>
                    {
                        {"A", "1"},
                        {"B", "2"},
                        {"C", "3"},
                        {"D", "4"},
                        {"E", "5"}
                    }

                }
            };
        }
    }
}