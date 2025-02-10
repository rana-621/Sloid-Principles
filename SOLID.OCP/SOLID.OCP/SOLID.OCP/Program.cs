﻿namespace SOLID.OCP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //var quiz = new Before.Quiz(Before.QuestionBank.Generate());
            //quiz.Print();

            var quiz = new After.Quiz(After.QuestionBank.Generate());
            quiz.Print();
            Console.ReadKey();
        }
    }
}
