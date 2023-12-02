public class TestSumma
{
    static void Main(string[] args)
    {
        Console.WriteLine("Bienvenido al sistema de información. ¿Qué servicio deseas utilizar?");
        Console.WriteLine("1. Servicios por agente");
        Console.WriteLine("2. Servicios por funcionalidad");
        //Console.WriteLine("3. Todos los servicios");
        string opcion = Console.ReadLine();

        switch (opcion)
        {
            case "1":
                ServiciosPorAgente();
                break;
            case "2":
                ServiciosPorFuncionalidad();
                break;
            // case "3":
            //      Llamar a la función que maneja todos los servicios
            // break;
            default:
                Console.WriteLine("Opción no válida. Por favor, elige una opción del 1 al 2.");
                break;
        }
    }

    private static void ServiciosPorFuncionalidad()
    {
        Console.WriteLine("Has seleccionado servicios por Funcionalidad. ¿Qué función deseas utilizar?");
        Console.WriteLine("1. Obtener Promedio");
        Console.WriteLine("2. Obtener Media Armonica");
        Console.WriteLine("3. Obtener Mediana C");

        string opcion = Console.ReadLine();
        

        IServiciosMedia servicio = null;
        IAgente agente = null;
        switch (opcion)
        {
            case "1":
                servicio = new ServicioMedia(new AgenteA());
                break;
            case "2":
                servicio = new ServicioMedia(new AgenteB());
                break;
            case "3":
                servicio = new ServicioMedia(new AgenteC());
                break;
            default:
                Console.WriteLine("Opción no válida. Por favor, elige una opción del 1 al 3.");
                return;
        }

        Console.WriteLine("Por favor, introduce una lista de números separados por comas para calcular la media:");
        string numerosInput = Console.ReadLine();

        if (numerosInput == "")
        {
            throw new ArgumentException("La lista no puede estar vacia");

        }

        List<double> numeros = numerosInput.Split(',').Select(double.Parse).ToList(); 

        double media = servicio.CalcularMedia(numeros);
        Console.WriteLine("La media es: " + media);
    }

    public static void ServiciosPorAgente()
    {
        Console.WriteLine("Has seleccionado servicios por agente. ¿Qué agente deseas utilizar?");
        Console.WriteLine("1. Agente A");
        Console.WriteLine("2. Agente B");
        Console.WriteLine("3. Agente C");

        string opcion = Console.ReadLine();

        IAgente agente = null;
        switch (opcion)
        {
            case "1":
                agente = new AgenteA();
                break;
            case "2":
                agente = new AgenteB();
                break;
            case "3":
                agente = new AgenteC();
                break;
            default:
                Console.WriteLine("Opción no válida. Por favor, elige una opción del 1 al 3.");
                return;
        }

        Console.WriteLine("Por favor, introduce una lista de números separados por comas para calcular la media:");
        string numerosInput = Console.ReadLine();
        
        if (numerosInput == "")
        {
            throw new ArgumentException("La lista no puede estar vacia");

        }

        List<double> numeros = numerosInput.Split(',').Select(double.Parse).ToList();

        Console.WriteLine("Por favor, introduce un número entero para imprimir la escalera:");
        int n = int.Parse(Console.ReadLine());

        double media = agente.GetMedia(numeros);
        Console.WriteLine("La resultado es: " + media);

        string escalera = agente.GetStaircase(n);
        Console.WriteLine("La escalera es: \n" + escalera);
    }
}