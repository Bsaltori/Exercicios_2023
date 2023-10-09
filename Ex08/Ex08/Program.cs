// Write a program that prints all prime numbers. (Note: if your programming language does not support
// arbitrary size numbers, printing all primes up to the largest number you can easily represent is fine too.)

using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        //Console.Write("Escreva um número: ");
        int n = 2;
        while (true)
        {
            int count = 0;

            for (int i = 1; i < n; i++)
            {
                if (n % i == 0)
                {
                    count++;
                }
            }

            if (count == 1)
            {
                Console.WriteLine("Numero " + n + " e primo.");
            }
            n++;
        }
    }
}