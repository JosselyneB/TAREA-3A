class Program{
    
        static void Main(string[] args)
        {
            int num;

            do
            {
                Console.Write("DIGITE UN NUMERO ENTERO: ");
                num = int.Parse(Console.ReadLine());
            } while (num < 0);
            factorial(num);
           
        }
       
        static void factorial(int n)
        {
            int fact=1;
            for (int i = 1; i <= n; i++)
            {
                fact *= i;
            }
            Console.WriteLine("EL FACTORIAL DE " + n + " ES: " + fact);
        }
    }


