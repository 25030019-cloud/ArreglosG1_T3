using Arreglos.Logica;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("---Operaciones de pila---\n");

        Console.WriteLine("Arreglo\n");
        MiArreglo oMiArreglo = new MiArreglo(5);

        try
        {
            oMiArreglo.Agregar(7);
            oMiArreglo.Agregar(-2);
            oMiArreglo.Agregar(8);
            
            Console.WriteLine(oMiArreglo);
            Console.WriteLine("Insertar 500 en posicion 1");
            Console.ReadKey();
            oMiArreglo.Insertar(500, 1);
            Console.WriteLine(oMiArreglo);

            Console.WriteLine("Eliminar 500 en posicion 1");
            Console.ReadKey();
            oMiArreglo.Eliminar(1);
            Console.WriteLine(oMiArreglo);

        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
            throw;
        }

        

       // Console.WriteLine(oMiArreglo);
        
        
        /*oMiArreglo.Llenar(1,20);

        Console.WriteLine("Arreglo desordenado\n");
        Console.WriteLine(oMiArreglo);


        Console.WriteLine("Arreglo ordenado ascendente\n");
        oMiArreglo.Ordenar();
        Console.WriteLine(oMiArreglo);

        Console.WriteLine("Arreglo ordenado descendente\n");
        oMiArreglo.Ordenar(false);
        Console.WriteLine(oMiArreglo);*/

        Console.ReadKey();
    }
}