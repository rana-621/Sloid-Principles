namespace SOLID.OCP.Before
{
    internal class QuestionBank
    {
        public static List<Question> Generate()
        {
            return new List<Question>
            {
                new Question
                {
                    Title = "What are the four pillars of oop ?",
                    QuestionType = QuestionType.WH,
                    Marks = 8
                },
                new Question
                {
                    Title = "What of the following are value types ?",
                    QuestionType = QuestionType.MCQ,
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
                new Question
                {
                    Title = "Earth is Bigger than sun?",
                    QuestionType = QuestionType.TrueFalse,
                    Marks = 4
                },
                new Question
                {
                    Title = "Which of the following is an 8-byte Integer?",
                    QuestionType = QuestionType.MCQ,
                    Marks = 6,
                    Choices = new List<string>
                    {
                       "A.  Char",
                       "B.  Long",
                       "C.  Short",
                       "D.  Byte",
                       "E.  Integer"
                    }
                }

            };
        }
    }
}