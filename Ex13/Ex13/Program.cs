// Write function that reverses a list, preferably in place.
namespace Testes
{
    public class Ex13
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Escreva números inteiros: ");
            int[] numbers = new int[5];
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = int.Parse(Console.ReadLine());
            }

            Reverse(numbers);
        }
           
           


           

        private static void Reverse(int[] numbers)
        {
            int[] numbers2 = new int[numbers.Length];

            Console.WriteLine("Os números reversos são:");

            for (int i = 0; i < numbers.Length; i++)
            {
                numbers2[i] = numbers[numbers.Length - 1 - i];
                Console.WriteLine(numbers2[i]);
            }

        }
            
    }
              
}

        







