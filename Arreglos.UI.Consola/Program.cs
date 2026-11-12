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

        MiArreglo oMyArreglo = new(50000);
        try
        {
            Console.WriteLine("\nArreglo\n");

            var tiempo1 = DateTime.Now;

            oMyArreglo.Llenar(1,999999);
            Console.WriteLine(oMyArreglo);
            var tiempo2 = DateTime.Now;

            var restaTiempo = tiempo2 - tiempo1;

            Console.WriteLine($"\nTiempo transcurrido:{restaTiempo.Minutes} minutos, {restaTiempo.Seconds} segundos, {restaTiempo.Milliseconds} milisegundos, {restaTiempo.Nanoseconds} nanosegundos");
            Console.ReadKey();

           /* Console.WriteLine("\nPares\n");
            var verPares = oMyArreglo.ObtenerPares();
            Console.WriteLine(verPares);
            Console.ReadKey();*/

           /* Console.WriteLine("\nPares ordenados\n");
            verPares.Ordenar();
            Console.WriteLine(verPares);
            Console.ReadKey();*/

            Console.WriteLine("\nPrimos\n");
            var tiempo3 = DateTime.Now;
            var verPrimos = oMyArreglo.ObtenerPrimos();
            var tiempo4 = DateTime.Now;
            var restaTiempo2 = tiempo4 - tiempo3;
            Console.WriteLine(verPrimos);
            Console.WriteLine($"\nTiempo transcurrido:{restaTiempo2.Minutes} minutos, {restaTiempo2.Seconds} segundos, {restaTiempo2.Milliseconds} milisegundos, {restaTiempo2.Nanoseconds} nanosegundos");
            Console.ReadKey();

            Console.WriteLine("\nPrimos ordenados\n");
            verPrimos.Ordenar();
            Console.WriteLine(verPrimos);
            Console.ReadKey();
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