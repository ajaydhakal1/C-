 //Program to find if the number is prime or composite
    class PrimeCheck
    {
        public void Check(int num)
        {
            bool isPrime = true;

            for (int i = 2; i < num; i++)
            {
                if (num % i == 0)
                {
                    isPrime = false;
                    break; // Exit the loop as soon as a divisor is found
                }
            }

            if (isPrime)
            {
                Console.WriteLine("The Number Is Prime");
            }
            else
            {
                Console.WriteLine("The Number Is Composite");
            }
        }
    }