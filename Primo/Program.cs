internal class Program
{
    private static void Main(string[] args)
    {
        double n;
        int count = 0, primo = 0;

        Console.WriteLine("Digite um número: ");
        n = double.Parse(Console.ReadLine());

        count = int.Parse(n.ToString());

        while (count > 0)
        {
            if (n % count == 0)
            {
                primo++;
            }

            count--;
        }
            if (primo == 2) {
                Console.WriteLine("O número é primo");
            } else { Console.WriteLine("O número não é primo"); }

    }
}