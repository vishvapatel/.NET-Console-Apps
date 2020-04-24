using System;

namespace Constructor_overloading
{
    class Program
    {
        //Class to evaluate the cost of pencil
        public class Cost
        {
            private double Amount; //The amoount of one item 
            private int Qty; //The quamtity required
            public Cost(double amt, int qty)
            {
                Amount = amt;
                Qty = qty;
            }

            public Cost(int qty)
            {
                Amount = 0.5;
                Qty = qty;
            }

            public double Calc()
            {
                return this.Amount * this.Qty; //Formula to calculate the price.    
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("This is a program for constructor overloading");
            Cost c = new Cost(12);
            double price = c.Calc();
            Console.WriteLine("The total price to pay is Rs.{0}", price);
        }

    }
}
