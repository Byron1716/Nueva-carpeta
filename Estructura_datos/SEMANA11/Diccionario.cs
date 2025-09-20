
public class Diccionarios
{
    public static Dictionary<string, string> traduccion = new Dictionary<string, string>
    {
        //Creamos un diccionario con el tipo de dato que tendrá la clave y el tipo de dato que tendrá el valor
        {"casa", "house"},                                                    //Agregamos todas las claves y los valores
        {"cocina", "kitchen"},
        {"ventana", "window"},
        {"sala", "living room"},
        {"año", "year"},
        {"mes", "month"},
        {"pais", "country"},
        {"ciudad", "city"},
        {"juego", "game"},
        {"futbol", "soccer"},
        {"carro", "car"},
        {"botella de vino", "wine bottle"},
        {"playa", "beach"},
        {"arena", "sand"},
        {"computadora", "computer"},
        {"esfero", "pen"},
        {"lapiz", "pencil"},
        {"conejo", "rabbit"},
        {"pato", "duck"},
        {"cielo", "sky"},
    };
    public static void TraducirFrase()
    {
        Console.WriteLine("\nIngresa la frase que deseas traducir (evita usar palabras con tilde)");
        string texto = Console.ReadLine();
        string[] palabras = texto.Split(' ');
        Console.WriteLine("\nTraducción parcial");
        foreach (string palabra in palabras)
        {
            string palabraLimpia = palabra.ToLower().Trim(',', '.', ';', ':', '!', '?'); // Limpia signos
            if (traduccion.ContainsKey(palabraLimpia))                                 //Ponemos condiciones para ver si la frase contiene palabras del diccionario para traducirlas
            {
                Console.Write(traduccion[palabraLimpia] + " ");                        //Hacemos una impresión de toda la frase aplicando la traducción de las palabras contenidas en el diccionario
            }
            else
            {
                Console.Write(palabra + " ");                                          //En caso de no existan palabras contenidas dentro del diccionario se imprimirá la frase sin modificaciones
            }
        }
    }
    public static void AgregarPalabras()
    {
        Console.WriteLine("\nEscribe la palabra en español (no escribas la tilde, Ej. si la palabra es canción solo escribe 'cacnción'):");
        string esp = Console.ReadLine();                                                //Pedimos una palabra al usuario que estará en español
        Console.WriteLine("Escribe la traducción en inglés:");
        string eng = Console.ReadLine();                                                //Pedimos la traducción de la palabra que se ingresó anteriormente

        if (!traduccion.ContainsKey(esp.ToLower()))                                     //Ponemos una condición para que analice si la palabra llave es existente
        {
            traduccion.Add(esp.ToLower(), eng.ToLower());                               //En caso de nos existir el sistema agrega la nueva palabra
            Console.WriteLine("✅Palabra agregada correctamente.");
        }
        else
        {
            Console.WriteLine("⚠️La palabra ya existe en el diccionario.");
        }
    }
    public static void MostrarDiccionario()
    {

        Console.WriteLine("\n📘 Diccionario Español-Inglés:");
        int indice = 1;
        foreach (var par in traduccion)

        {
            Console.WriteLine($"{indice}- {par.Key} → {par.Value}");
            indice++;

        }
        Console.WriteLine($"En total existen {indice-1} palabras en el diccionario");
    }
    public static void Salir()
    {
        Console.WriteLine("\nHasta Luego");
    }
    
    public static void MenuInteractivo()
    {
        string opcion;

        do
        {
            Console.WriteLine("\n====================== MENÚ =======================");
            Console.WriteLine("1. Traducir Frase");
            Console.WriteLine("2. Agregar palabras al Diccionario");
            Console.WriteLine("3. Mostrar Diccionario");
            Console.WriteLine("4. Salir");
            Console.WriteLine("===================================================");
            Console.WriteLine("\nEscribe una opción:");

            opcion = Console.ReadLine();

            while (string.IsNullOrWhiteSpace(opcion))
            {
                Console.WriteLine("⚠️ No puedes dejar la opción vacía. Intenta nuevamente.");
                Console.WriteLine("Escribe una opción:");
                opcion = Console.ReadLine();
            }

            switch (opcion)
            {
                case "1":
                    TraducirFrase();
                    break;
                case "2":
                    AgregarPalabras();
                    break;
                case "3":
                    MostrarDiccionario();
                    break;
                case "4":
                    Salir();
                    break;
                default:
                    Console.WriteLine("⚠️ Opción no válida. Intenta nuevamente.");
                    break;
            }

        } while (opcion != "4");
    }

}
