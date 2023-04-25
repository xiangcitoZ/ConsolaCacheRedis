using ConsolaCacheRedis.Models;
using ConsolaCacheRedis.Services;

namespace ConsolaCacheRedis
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Cliente Movil de Azure Cache Redis");
            ServiceCacheRedis service = new ServiceCacheRedis();


            List<Producto> productos = service.GetProductosFavoritos();
            if(productos == null ) 
            {
                Console.WriteLine("No existen favoritos");
            
            }
            else
            {
                int i = 1;
                foreach(Producto p in productos) 
                {
                    Console.WriteLine(i + ".- " + p.Nombre);
                    i++;
                }
            }

            Console.WriteLine("Pulse ENTER para finalizar");
            Console.ReadLine();

        }
    }
}