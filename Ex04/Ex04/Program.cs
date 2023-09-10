// Write a program that asks the user for a number n and prints the sum of the numbers 1 to n

int n, sum = 0;


Console.Write("Write a number: ");
n = int.Parse(Console.ReadLine());


   


for (int i = 1; i<=n; i++)
{
    sum += i;
}

Console.Write("The sum is: " + sum);



