using System ;
using System.Collections.Generic;
using System.Text;

namespace Assignment.Homework
{
    public class homework
    {
        public static void Run()
        {
            Console.WriteLine($"You are about to perform permutation or combination");
            Console.WriteLine($"Enter p for pemutation and c for combination");
            string input = Console.ReadLine();
            Console.WriteLine($"Enter number values for n ");
            var n = int.Parse(Console.ReadLine());
            Console.WriteLine($"Enter number values for r ");
            var r = int.Parse(Console.ReadLine());
            var result = Factorial(n);
            
            if(input == "p")
            {
                int permu = Factorial(n) / Factorial(n - r);
                Console.WriteLine($"{n}! / {n - r}! = {permu}", n, n - r, permu);
            }
            else if (input == "c")
            {
                int combi = Factorial(n) / (Factorial(n - r) * Factorial(r));
                Console.WriteLine($" {n}! / {n - r}!*{r}! = {combi}", n, n - r * r, combi );
            }
        }
        public static int Factorial(int n)
        {
            // what to do
            int result = 1;
            //for(int i = 1; i<=n; i++)
            for (int i = n; i >= 1; i--)
            {
                result = result * i;
            }
            return result;
        }
        public static int permutation(int n, int r)
        {
            int permu = Factorial(n) / Factorial(n - r);
            return permu;
        }
        public static int combination(int n, int r)
        {
            int combi;
            combi = Factorial(n) / (Factorial(n - r) * Factorial(r));
            return combi;
        }
    }

}
