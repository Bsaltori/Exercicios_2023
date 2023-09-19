int n, value, sum, product, result;

string choice = "";

while (!choice.Equals("s"))
{

    Console.Write("Digite um numero inteiro: ");

    n = int.Parse(Console.ReadLine());
    sum = 0;
    product = 1;
    result = 0;

    Console.Write("Digite 1 para somar ou 2 para calcular os produtos: ");

    value = int.Parse(Console.ReadLine());

    for (int i = 1; i <= n; i++)
    {
        if (value == 1)
        {
            sum += i;
            result = sum;
        }

        else if (value == 2)
        {
            product *= i;
            result = product;
        }
    }


    Console.WriteLine($"O resultado para o número {n} é {result}");
    Console.WriteLine("Tecle s para sair programa ");
    choice = Console.ReadLine();
}
