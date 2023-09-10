// Modify the previous program such that only multiples of three or five are considered in the sum,
// e.g. 3, 5, 6, 9, 10, 12, 15 for n=17

int n, sum = 0;


Console.Write("Write a number: ");
n = int.Parse(Console.ReadLine());




for (int i = 1; i <= n; i++)
{
    if (i % 3 == 0 || i % 5 == 0) {
        sum += i;
    }
   
}

Console.Write("The sum is: " + sum);
