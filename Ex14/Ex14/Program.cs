//Write a function that checks whether an element occurs in a list.

namespace ListRandon
{
    public class Ex14
    {
        public static void Main(string[] args)
        {



            Console.WriteLine("Escreva cinco números de 1 a 100");
            int[] elements = new int[5];

            for (int i = 0; i < elements.Length; i++)
            {
                elements[i] = int.Parse(Console.ReadLine());
                while (elements[i] < 0 || elements[i] > 100) 
                {
                    Console.WriteLine("O número precisa ser entre 1 e 100, escreva um novo número:");
                    elements[i] = int.Parse(Console.ReadLine());
                }
            }

            Randonnum(elements);
        }




        public static void Randonnum (int[] elements)
        {
    
            int value = 15;

            for (int i = 0; i < elements.Length; i++)
            {
                if (elements[i] == value)
                {
                Console.WriteLine("Parabéns você acertou o número, que é: " + elements[i]);
        
                }
                else
                {
                    Console.WriteLine("Que pena não é o número:" + elements[i]);
                }
             }
        }
    }
}




    
    


