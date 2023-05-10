namespace Trabajo_Git
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n1, n2;
            Console.Write("Ingresa un número: ");
            n1 = int.Parse(Console.ReadLine());
            Console.Write("Ingresa otro número: ");
            n2 = int.Parse(Console.ReadLine());
            Console.WriteLine("La suma para git es: "+(n1+n2));

        }
    }
}