namespace Add_and_multiply
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Vänligen välj två nummer: ");
            int userChoice = Convert.ToInt32(Console.ReadLine());
            int userChoice2 = Convert.ToInt32(Console.ReadLine());

            Console.Clear();

            Console.WriteLine(Num(userChoice, userChoice2));

            Console.WriteLine(Mult(userChoice, userChoice2));

            Console.WriteLine(Div(userChoice, userChoice2));

            Console.WriteLine(sub(userChoice, userChoice2));
        }
        
        /// <summary>
        /// Adds the two numbers toghether
        /// </summary>
        /// <param name="one"></param>
        /// <param name="two"></param>
        /// <returns></returns>

        private static int Num(int one, int two)

        {

            int sum = one + two;
            return sum;
        }

        private static int Mult(int a, int b)
        {
            int sum = a * b;
            return sum;
        }

        private static int Div(int first, int second)
        {
            int sum = first / second;
            return sum;
        }

        private static int sub(int one, int two)
        {
            int sum = one - two;
            return sum; 
        }


        
    }
}
