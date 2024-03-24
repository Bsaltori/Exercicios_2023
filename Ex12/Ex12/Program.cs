//Write a function that returns the largest element in a list.

public class Metodo
{
    public static void Main(string[] args)
    {

        Console.Write("Digite cinco números interios: ");
        int[] numbers = new int[5];

        for (int i = 0; i < numbers.Length; i++)
        {
            numbers[i] = int.Parse(Console.ReadLine());
        }

        int r = LargestNumber(numbers);
        mostrar("O resultado é", r);

    }

    private static int LargestNumber(int[] numbers)
    {
        int value = 0;
        for (int i = 0; i < 5; i++)
        {
            if (numbers[i] > value)
            {
                value = numbers[i];

            }
        }
        return value;
    }
    private static void mostrar(string palavra, int resultado)
    {
        Console.WriteLine(palavra + ":" + resultado);
    }
}