using ConsoleApp1.Dominio;

namespace ConsoleApp1
{
    class Program
    {
       static void Main()
        {
            Auto a1 = new Auto();

            Console.WriteLine("Cuanto KM quiere recorrer");
            a1.cKilometros = double.Parse(Console.ReadLine());
            Console.WriteLine("Cuanto Combustible tiene");
            a1.comustible = double.Parse(Console.ReadLine());
            Console.WriteLine("Usted " + a1.Conducir() + " podra recorer " + a1.cKilometros + "KM");

            Console.WriteLine("Cuanto litros quiere cargar?");
            a1.combustibleACargar = double.Parse(Console.ReadLine());
            Console.WriteLine("Usted tuvo una perdida de " + a1.CargarCombustible() + "L");
        }
    }
}