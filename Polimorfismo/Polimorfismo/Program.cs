namespace Polimorfismo
{
    public class Program
    {
        static void Main(string[] args)
        {
            Ferrari ferrari1 = new Ferrari();
            Porsche porsche1 = new Porsche();

            Vehiculo[] garaje = { ferrari1, porsche1 };

            Console.WriteLine("Entrando al Garaje para realizar viajes de prueba con los nuevos vehículos.");
            Console.WriteLine("Presione cualquier tecla para iniciar los viajes de prueba.");
            Console.WriteLine("Presione al finalizar el primer viaje para iniciar el segundo.");
            Console.ReadKey();

            foreach (Vehiculo item in garaje)
            {
                Console.WriteLine("---------------------------");
                Console.WriteLine(item.Arrancar());
                Console.WriteLine(item.Acelerar());
                Console.WriteLine(item.Cruise());
                Console.WriteLine(item.Desacelerar());
                Console.WriteLine(item.Estacionar());
                Console.WriteLine(item.Apagar());
                Console.WriteLine("---------------------------");
                Console.ReadKey();
            }

            Console.WriteLine("Así concluyen los viajes de prueba.");
            Console.WriteLine("Los vehículos nuevos funcionan bien y todo parece en órden.");
            Console.WriteLine("Presione cualquier tecla para finalizar la sesión.");
            Console.ReadKey();
        }
    }
}