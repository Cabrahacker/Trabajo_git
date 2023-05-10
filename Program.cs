namespace Trabajo_Git
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name = "Sebastiàn :D", apellido = "Cabrera Gómez o_o", nombrecompleto;
            int n1, n2;
            Console.Write("Ingresa un número: ");
            n1 = int.Parse(Console.ReadLine());
            Console.Write("Ingresa otro número: ");
            n2 = int.Parse(Console.ReadLine());
            Console.WriteLine("La suma para git es: "+(n1+n2));
            nombrecompleto = name + apellido;
            Console.WriteLine(nombrecompleto);

        }
    }
}