namespace Projeto_Hotel_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            Hotel hotel;

            Console.Write("Quantos quartos serão alugados? ");
            int quant = int.Parse(Console.ReadLine());

            Hotel[] vetor = new Hotel[10];

            for(int i = 1; i <= quant; i++)
            {
                Console.WriteLine();
                Console.WriteLine("Aluguel #" + i + ":");
                Console.Write("Nome: ");
                string nome = Console.ReadLine();
                Console.Write("Email: ");
                string email = Console.ReadLine();
                Console.Write("Quarto: ");
                int quarto = int.Parse(Console.ReadLine());
                Console.WriteLine();

                vetor[quarto] = new Hotel(nome, email);
            }

            Console.WriteLine("Quartos ocupados: ");
            for(int i = 0; i < 10; i++)
            {
                if(vetor[i] != null)
                {
                    Console.WriteLine(i + ": " + vetor[i]);
                }
            }
        }
    }
}
