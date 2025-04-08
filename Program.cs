using System.Transactions;

namespace OOPExtra
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Automovil subaru = new Automovil();
            Motocicleta BMW = new Motocicleta();
            subaru.Marca = "Subaru";
            subaru.Modelo = "Impreza";
            BMW.Marca = "BMW";
            BMW.Modelo = "Motorrad";
            subaru.MostrarInformacion();
            BMW.MostrarInformacion();
            subaru.Acelerar(100);
            BMW.Acelerar(500);
            subaru.Decelerar(60);
            BMW.Decelerar(200);
            Console.WriteLine("Nueva impresión");
            subaru.MostrarInformacion();
            BMW.MostrarInformacion();

        }
    }
}
