//Write a guessing game where the user has to guess a secret number. After every guess the program tells the
//user whether their number was too large or too small. At the end the number of tries needed should be
//printed. It counts only as one try if they input the same number multiple times consecutively.


int n, numberScret, count;
numberScret = 15;
count = 0;

Console.Write("Escreva um número de 0 à 100: ");
n = int.Parse(Console.ReadLine());

    while (n != numberScret)
    {
        if (n <= 10)
        {
            Console.WriteLine("Este número é pequeno");
            Console.Write("Escreva um número de 0 à 100: ");
            count++;
        }
        else
        {
            Console.WriteLine("Este número é muito grande");
            Console.Write("Escreva um número de 0 à 100: ");
            count++;
            n = int.Parse(Console.ReadLine());
            count++;
       
         }


    }

   
Console.WriteLine("Parabéns você acertou o número secreto!!");
Console.Write("Numero de tentativas: " + count);
