namespace SOLID.OCP.After
{
    abstract class Question
    {
        public string Title { get; set; }
        public int Marks { get; set; }
        public abstract void Print();
    }
}
