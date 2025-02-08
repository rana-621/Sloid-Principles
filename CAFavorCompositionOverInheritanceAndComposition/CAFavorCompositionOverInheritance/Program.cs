﻿namespace CAFavorCompositionOverInheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
        }


        private static Pizza CreatePizza(int choice)
        {
            Pizza pizza = null;
            switch (choice)
            {
                case 1:
                    pizza = new Mexican();
                    break;
                case 2:
                    pizza = new Chicken();
                    break;
                case 3:
                    pizza = new Vegeterain();
                    break;
                default:
                    break;
            }
            return pizza;
        }

        class Pizza
        {
            public virtual string Title => $"{nameof(Title)}";
            public virtual decimal Price => 10m;
            public override string ToString()
            {
                return $"{Title} - {Price.ToString("C")}";
            }
        }
        class Mexican : Pizza
        {
            public override string Title => $"{base.Title}{nameof(Mexican)}";
            public override decimal Price => base.Price + 15m;
        }

        class Chicken : Pizza
        {
            public override string Title => $"{base.Title}{nameof(Chicken)}";
            public override decimal Price => base.Price + 5m;
        }
        class Vegeterain : Pizza
        {
            public override string Title => $"{base.Title}{nameof(Vegeterain)}";
            public override decimal Price => base.Price + 9m;
        }
    }

}